using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Pages.Dir;

public partial class DirList
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private List<DirModel> _dirModels = new();

    protected override async Task OnInitializedAsync()
    {
        _dirModels = await DataService.GetAllAsync<DirModel>();
    }

    private void OpenDirById(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Dir}/{id}", true);
    }
}
