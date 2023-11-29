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

    private bool _isTablelVisible;
    private bool _isIDVisible;
    private bool _isPRVisible;
    private bool _isDEVisible;
    private bool _isRSVisible;
    private bool _isRCVisible;


    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _dirModel = await DataService.GetByIdAsync<DirFeasibilityModel>(Id.Value);
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
}
