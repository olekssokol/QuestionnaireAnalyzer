using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Pages.InputType;

public partial class InputType
{
    [Inject] private NavigationManager _navigationManager { get; set; } = null!;
    [Inject] private IDataService DataService { get; set; }
    [Inject] private IExcelService ExcelService { get; set; } = null!;

    private bool _isLoading = true;

    private async void ExportFromExcel(InputFileChangeEventArgs e)
    {
        _isLoading = true;
        StateHasChanged();
        
        var model = ExcelService.GetDirCapacityFromExcel();
        
        await DataService.CreateAsync<DirCapacityModel>(model);

        _isLoading = false;
    }
    private void OpenCreateDataPage()
    {
        _navigationManager.NavigateTo(NavigationHelper.InputTypeNextPage(_navigationManager.Uri));
    }
}
