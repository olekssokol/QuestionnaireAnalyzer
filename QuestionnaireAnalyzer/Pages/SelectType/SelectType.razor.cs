using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.SelectType;

public partial class SelectType
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;


    private void OpenDirPage()
    {
        _navigationManager.NavigateTo(ClientRoutes.Dir, true);
    }
}
