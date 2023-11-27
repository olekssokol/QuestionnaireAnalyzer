using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Pages.Methodology;

public partial class Methodology
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;

    private void OpenFeasibilityPage()
    {
        _navigationManager.NavigateTo(NavigationHelper.MethodologyNextPage(_navigationManager.Uri, ClientRoutes.Feasibility));
    }

    private void OpenCapacityPage()
    {
        _navigationManager.NavigateTo(NavigationHelper.MethodologyNextPage(_navigationManager.Uri, ClientRoutes.Capacity));
    }
}
