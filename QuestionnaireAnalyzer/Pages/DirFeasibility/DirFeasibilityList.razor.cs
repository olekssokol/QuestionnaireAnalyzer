using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Pages.DirFeasibility;

public partial class DirFeasibilityList
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private List<DirCapacityModel> _dirModels = new();

    protected override async Task OnInitializedAsync()
    {
        _dirModels = await DataService.GetAllAsync<DirCapacityModel>();
    }

    private void OpenDirById(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Dir}{ClientRoutes.Capacity}/{id}");
    }

    private void OpenDirByIdForUdate(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Dir}{ClientRoutes.Capacity}{ClientRoutes.Update}/{id}");
    }

    private async Task DeleteFromDb(int id)
    {
        await DataService.DeleteByIdAsync<DirCapacityModel>(id);

        _dirModels = await DataService.GetAllAsync<DirCapacityModel>();

        StateHasChanged();
    }

    private void OpenInputTypePage()
    {
        _navigationManager.NavigateTo(NavigationHelper.ListNewItemNextPage(_navigationManager.Uri));
    }
}
