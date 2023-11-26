using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Kii;
using ChartJs.Blazor.RadarChart;
using ChartJs.Blazor.Common;

namespace QuestionnaireAnalyzer.Pages.KiiCapacities;

public partial class KiiCapacitiesAnalyzer
{
    [Inject] private IDataService DataService { get; set; }

    private RadarConfig _config = new();

    private float _state = 0;
    private float _politicians = 0;
    private float _technologies = 0;
    private float _financing = 0;
    private float _planning = 0;

    private const int _maxState = 7;
    private const int _maxPoliticians = 3;
    private const int _maxTechnologies = 9;
    private const int _maxFinancing = 3;
    private const int _maxPlanning = 2;

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
        var dirModels = await DataService.GetAllAsync<KiiCapacitiesModel>();

        if (dirModels.Count == 0)
        {
            return;
        }

        foreach (var model in dirModels)
        {
            var stateProperties = typeof(KiiCapacitiesModel).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) && (p.Name.StartsWith("T2Q1") || p.Name.StartsWith("T2Q2")))
            .Select(p => (bool)p.GetValue(model));

            _state += stateProperties.Count(b => b);


            var politiciansProperties = typeof(KiiCapacitiesModel).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) && p.Name.StartsWith("T2Q3"))
            .Select(p => (bool)p.GetValue(model));

            _politicians += politiciansProperties.Count(b => b);


            var technologiesProperties = typeof(KiiCapacitiesModel).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) && p.Name.StartsWith("T2Q4"))
            .Select(p => (bool)p.GetValue(model));

            _technologies += technologiesProperties.Count(b => b);


            var financingProperties = typeof(KiiCapacitiesModel).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) && p.Name.StartsWith("T2Q5"))
            .Select(p => (bool)p.GetValue(model));

            _financing += financingProperties.Count(b => b);


            var planningProperties = typeof(KiiCapacitiesModel).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) && p.Name.StartsWith("T2Q6"))
            .Select(p => (bool)p.GetValue(model));

            _planning += planningProperties.Count(b => b);
        }

        _state /= dirModels.Count * _maxState;
        _politicians /= dirModels.Count * _maxPoliticians;
        _technologies /= dirModels.Count * _maxTechnologies;
        _financing /= dirModels.Count * _maxFinancing;
        _planning /= dirModels.Count * _maxPlanning;
    }
}
