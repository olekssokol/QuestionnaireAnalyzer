using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.SelectType;

public partial class SelectType
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;

    private void OpenDataListPage()
    {
        if (_navigationManager.Uri.Contains(ClientRoutes.Dir))
        {
            _navigationManager.NavigateTo(ClientRoutes.DirList, true);
        }
        else if (_navigationManager.Uri.Contains(ClientRoutes.Kii))
        {
            _navigationManager.NavigateTo(ClientRoutes.KiiList, true);
        }
    }

    private void OpenInputTypePage()
    {
        if (_navigationManager.Uri.Contains(ClientRoutes.Dir))
        {
            _navigationManager.NavigateTo(ClientRoutes.Dir + ClientRoutes.InputType, true);
        }
        else if (_navigationManager.Uri.Contains(ClientRoutes.Kii))
        {
            _navigationManager.NavigateTo(ClientRoutes.Kii + ClientRoutes.InputType, true);
        }
    }

    private void OpenAnalyzerPage()
    {
        if (_navigationManager.Uri.Contains(ClientRoutes.Dir))
        {
            _navigationManager.NavigateTo(ClientRoutes.Dir + ClientRoutes.Analyzer, true);
        }
        else if (_navigationManager.Uri.Contains(ClientRoutes.Kii))
        {
            _navigationManager.NavigateTo(ClientRoutes.Kii + ClientRoutes.Analyzer, true);
        }
    }
}
