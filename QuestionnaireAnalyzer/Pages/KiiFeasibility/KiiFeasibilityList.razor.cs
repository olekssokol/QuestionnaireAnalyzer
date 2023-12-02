using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Kii;

namespace QuestionnaireAnalyzer.Pages.KiiFeasibility;

public partial class KiiFeasibilityList
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private List<KiiFeasibilityModel> _kiiModels = new();

    protected override async Task OnInitializedAsync()
    {
        _kiiModels = await DataService.GetAllAsync<KiiFeasibilityModel>();
    }

    private void OpenKiiById(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Kii}{ClientRoutes.Feasibility}/{id}");
    }

    private void OpenKiiByIdForUdate(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Kii}{ClientRoutes.Feasibility}{ClientRoutes.Update}/{id}");
    }

    private async Task DeleteFromDb(int id)
    {
        await DataService.DeleteByIdAsync<KiiFeasibilityModel>(id);

        _kiiModels = await DataService.GetAllAsync<KiiFeasibilityModel>();

        StateHasChanged();
    }

    private void OpenInputTypePage()
    {
        _navigationManager.NavigateTo(NavigationHelper.ListNewItemNextPage(_navigationManager.Uri));
    }
}
