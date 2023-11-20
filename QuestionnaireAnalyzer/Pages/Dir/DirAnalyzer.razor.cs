using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;
using ChartJs.Blazor.RadarChart;
using ChartJs.Blazor.Common;

namespace QuestionnaireAnalyzer.Pages.Dir;

public partial class DirAnalyzer
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private RadarConfig _config = new();

    private float politicians = 0.71f;
    private float state = 0.60f;
    private float technologies = 0.73f;
    private float financing = 0.30f;
    private float planning = 0.49f;

    protected override async Task OnInitializedAsync()
    {
        await AnalyzeAsync();

        _config = new RadarConfig
        {
            Options = new RadarOptions
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = false,
                },
                Scale = new()
                {
                    AngleLines = new()
                    {
                        Display = true,
                    },
                    PointLabels = new()
                    {
                        FontSize = 22,
                    },
                    Ticks = new()
                    {
                        Min = 0,
                        Max = 1,
                        StepSize = 0.1f
                    }
                },
                Legend = new()
                {
                    Display = false
                }

            }
        };

        foreach (string type in new[] { "політики", "штат", "технології", "фінансування", "планування" })
        {
            _config.Data.Labels.Add(type);
        }

        RadarDataset<float> dataset = new RadarDataset<float>(new List<float> { politicians, state, technologies, financing, planning })
        {
            BorderColor = "#0e67ed",
            BorderWidth = 2,
        };

        _config.Data.Datasets.Add(dataset);

    }

    private async Task AnalyzeAsync()
    {
        var dirModels = await DataService.GetAllAsync<DirModel>();

        foreach (var model in dirModels)
        {
            var politiciansProperties = typeof(DirModel).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) && p.Name.StartsWith("T2Q2"))
            .Select(p => (bool)p.GetValue(model));

            int politicians = politiciansProperties.Count(b => b);
        }
    }
}
