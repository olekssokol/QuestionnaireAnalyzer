using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Pages.Dir;

public partial class DirPage
{
    [Inject] private NavigationManager NavigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    [Parameter] public int? Id { get; set; }

    private bool _showLoader;

    private DirModel _dirModel = new();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _showLoader = true;
            StateHasChanged();

            _dirModel = await DataService.GetByIdAsync<DirModel>(Id.Value);

            _showLoader = false;
            StateHasChanged();
        }
    }

    private void AddTable1Item()
    {
        _dirModel.Table1Elements.Add(new Table1Item());

        StateHasChanged();
    }

    private async Task SaveToDb()
    {
        await DataService.CreateAsync<DirModel>(_dirModel);

        var x = await DataService.GetAllAsync<DirModel>();
    }
}
