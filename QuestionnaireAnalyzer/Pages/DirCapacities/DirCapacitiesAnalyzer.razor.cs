using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;
using ChartJs.Blazor.RadarChart;
using ChartJs.Blazor.Common;

namespace QuestionnaireAnalyzer.Pages.DirCapacities;

public partial class DirCapacitiesAnalyzer
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private RadarConfig _config = new();

    private float _politicians = 0;
    private float _state = 0;
    private float _technologies = 0;
    private float _financing = 0;
    private float _planning = 0;

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

        RadarDataset<float> dataset = new RadarDataset<float>(
            new List<float> { _politicians, _state, _technologies, _financing, _planning })
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
