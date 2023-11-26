using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.SelectType;

public partial class SelectType
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;

    private void OpenDataListPage()
    {
        _navigationManager.NavigateTo(NavigationHelper.SelectTypeNextPage(_navigationManager.Uri, ClientRoutes.List));
    }

    private void OpenInputTypePage()
    {
        _navigationManager.NavigateTo(NavigationHelper.SelectTypeNextPage(_navigationManager.Uri, ClientRoutes.InputType));
    }

    private void OpenAnalyzerPage()
    {
        _navigationManager.NavigateTo(NavigationHelper.SelectTypeNextPage(_navigationManager.Uri, ClientRoutes.Analyzer));
    }
}
