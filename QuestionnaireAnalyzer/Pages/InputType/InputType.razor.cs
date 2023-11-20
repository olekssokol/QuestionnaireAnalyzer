using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.InputType;

public partial class InputType
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;

    private void OpenCreateDataPage()
    {
        if (_navigationManager.Uri.Contains(ClientRoutes.Dir))
        {
            _navigationManager.NavigateTo(ClientRoutes.Dir, true);
        }
        else if (_navigationManager.Uri.Contains(ClientRoutes.Kii))
        {
            _navigationManager.NavigateTo(ClientRoutes.Kii, true);
        }
    }
}
