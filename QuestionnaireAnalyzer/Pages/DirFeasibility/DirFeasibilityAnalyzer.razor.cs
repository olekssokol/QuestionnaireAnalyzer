using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;
using ChartJs.Blazor.RadarChart;

namespace QuestionnaireAnalyzer.Pages.DirFeasibility;

public partial class DirFeasibilityAnalyzer
{
    [Inject] private IDataService DataService { get; set; }

    private RadarConfig _config = new();

    protected override async Task OnInitializedAsync()
    {
        await AnalyzeAsync();
    }

    private async Task AnalyzeAsync()
    {
        var dirModels = await DataService.GetAllAsync<DirFeasibilityModel>();
    }
}
