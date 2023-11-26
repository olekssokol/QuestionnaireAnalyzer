using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Kii;

namespace QuestionnaireAnalyzer.Pages.KiiCapacity;

public partial class KiiCapacityList
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private List<KiiCapacityModel> _kiiModels = new();

    protected override async Task OnInitializedAsync()
    {
        _kiiModels = await DataService.GetAllAsync<KiiCapacityModel>();
    }

    private void OpenKiiById(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Kii}{ClientRoutes.Capacity}/{id}");
    }

    private void OpenKiiByIdForUdate(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Kii}{ClientRoutes.Capacity}{ClientRoutes.Update}/{id}");
    }

    private async Task DeleteFromDb(int id)
    {
        await DataService.DeleteByIdAsync<KiiCapacityModel>(id);

        _kiiModels = await DataService.GetAllAsync<KiiCapacityModel>();

        StateHasChanged();
    }

    private void OpenInputTypePage()
    {
        _navigationManager.NavigateTo(NavigationHelper.ListNewItemNextPage(_navigationManager.Uri));
    }
}
