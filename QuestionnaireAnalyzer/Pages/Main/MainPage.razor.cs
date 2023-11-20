using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.Main;

public partial class MainPage
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;


    private void OpenDirSelectTypePage()
    {
        _navigationManager.NavigateTo(ClientRoutes.Dir + ClientRoutes.SelectType, true);
    }

    private void OpenKiiSelectTypePage()
    {
        _navigationManager.NavigateTo(ClientRoutes.Dir, true);
    }
}
