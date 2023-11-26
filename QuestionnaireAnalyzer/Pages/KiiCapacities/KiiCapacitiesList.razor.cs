using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Kii;

namespace QuestionnaireAnalyzer.Pages.KiiCapacities;

public partial class KiiCapacitiesList
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private List<KiiCapacitiesModel> _kiiModels = new();

    protected override async Task OnInitializedAsync()
    {
        _kiiModels = await DataService.GetAllAsync<KiiCapacitiesModel>();
    }

    private void OpenKiiById(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Kii}{ClientRoutes.Capacities}/{id}");
    }

    private void OpenKiiByIdForUdate(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Kii}{ClientRoutes.Capacities}{ClientRoutes.Update}/{id}");
    }

    private async Task DeleteFromDb(int id)
    {
        await DataService.DeleteByIdAsync<KiiCapacitiesModel>(id);

        _kiiModels = await DataService.GetAllAsync<KiiCapacitiesModel>();

        StateHasChanged();
    }

    private void OpenInputTypePage()
    {
        _navigationManager.NavigateTo(NavigationHelper.ListNewItemNextPage(_navigationManager.Uri));
    }
}
