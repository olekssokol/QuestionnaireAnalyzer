using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.InputType;

public partial class InputType
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;

    private void OpenCreateDataPage()
    {
        _navigationManager.NavigateTo(NavigationHelper.InputTypeNextPage(_navigationManager.Uri));
    }
}
