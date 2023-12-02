using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;
using Microsoft.JSInterop;

namespace QuestionnaireAnalyzer.Pages.DirFeasibility;

public partial class DirFeasibilityPage
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

    [Parameter] public int? Id { get; set; }

    private DirFeasibilityModel _dirModel = new();

    private bool _isTableVisible;

    private int[] _ID_TableResult = new int[4];
    private int[] _PR_TableResult = new int[4];
    private int[] _DE_TableResult = new int[4];
    private int[] _RS_TableResult = new int[4];
    private int[] _RC_TableResult = new int[4];
    private int[] _TableResult = new int[4];

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _dirModel = await DataService.GetByIdAsync<DirFeasibilityModel>(Id.Value);

            TableCalculate();
        }
    }

    private async Task SaveToDb()
    {
        await DataService.CreateAsync<DirFeasibilityModel>(_dirModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }

    private async Task UpdateDbData()
    {
        await DataService.UpdateItemAsync<DirFeasibilityModel>(_dirModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }

    private async void OpenPreviousPage()
    {
        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }

    private void TableCalculate()
    {
        ProcessItems("ID", _ID_TableResult);
        ProcessItems("PR", _PR_TableResult);
        ProcessItems("DE", _DE_TableResult);
        ProcessItems("RS", _RS_TableResult);
        ProcessItems("RC", _RC_TableResult);
        
        for (int i = 0; i < _TableResult.Length; i++)
        {
            _TableResult[i] = _ID_TableResult[i] + _PR_TableResult[i] + _DE_TableResult[i] + _RS_TableResult[i] + _RC_TableResult[i];
        }
    }
    
    void ProcessItems(string prefix, int[] resultArray)
    {
        var items = typeof(DirFeasibilityModel).GetProperties()
            .Where(p => p.PropertyType == typeof(int) && p.Name.StartsWith(prefix))
            .Select(p => (int)p.GetValue(_dirModel));

        for (int i = 1; i <= 4; i++)
        {
            resultArray[i - 1] = items.Count(x => x == i);
        }
    }
}
