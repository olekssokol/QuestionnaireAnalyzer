using ChartJs.Blazor.Common;
using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Kii;
using ChartJs.Blazor.RadarChart;

namespace QuestionnaireAnalyzer.Pages.KiiFeasibility;

public partial class KiiFeasibilityAnalyzer
{
    [Inject] private IDataService DataService { get; set; }

    private RadarConfig _config = new();

    private int[] _ID_Data = new int[4];
    private int[] _PR_Data = new int[4];
    private int[] _DE_Data = new int[4];
    private int[] _RS_Data = new int[4];
    private int[] _RC_Data = new int[4];

    private float[] _ID_Result = new float[4];
    private float[] _PR_Result = new float[4];
    private float[] _DE_Result = new float[4];
    private float[] _RS_Result = new float[4];
    private float[] _RC_Result = new float[4];

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
                        Display = false,
                    },
                    PointLabels = new()
                    {
                        FontSize = 22,
                    },
                    Ticks = new()
                    {
                        Min = 0,
                        Max = 100,
                        StepSize = 10
                    }
                },
                Legend = new()
                {
                    Display = false
                }

            }
        };

        foreach (string type in new[] { "ID", "PR", "DE", "RS", "RC" })
        {
            _config.Data.Labels.Add(type);
        }

        RadarDataset<float> dataset = new RadarDataset<float>(
            new List<float> { _ID_Result[0], _PR_Result[0], _DE_Result[0], _RS_Result[0], _RC_Result[0] })
        {
            BorderColor = "#0e67ed",
            BorderWidth = 2,
        };

        _config.Data.Datasets.Add(dataset);
    }

    private async Task AnalyzeAsync()
    {
        var kiiModels = await DataService.GetAllAsync<KiiFeasibilityModel>();

        foreach (var model in kiiModels)
        {
            TableCalculate(model);
        }

        CalculatingInterest(_ID_Result, _ID_Data, 29 * kiiModels.Count);
        CalculatingInterest(_PR_Result, _PR_Data, 29 * kiiModels.Count);
        CalculatingInterest(_DE_Result, _DE_Data, 18 * kiiModels.Count);
        CalculatingInterest(_RS_Result, _RS_Data, 16 * kiiModels.Count);
        CalculatingInterest(_RC_Result, _RC_Data, 6 * kiiModels.Count);
    }

    private void TableCalculate(KiiFeasibilityModel model)
    {
        ProcessItems("ID", _ID_Data, model);
        ProcessItems("PR", _PR_Data, model);
        ProcessItems("DE", _DE_Data, model);
        ProcessItems("RS", _RS_Data, model);
        ProcessItems("RC", _RC_Data, model);
    }

    void ProcessItems(string prefix, int[] resultArray, KiiFeasibilityModel model)
    {
        var items = typeof(KiiFeasibilityModel).GetProperties()
            .Where(p => p.PropertyType == typeof(int) && p.Name.StartsWith(prefix))
            .Select(p => (int)p.GetValue(model));

        for (int i = 1; i <= 4; i++)
        {
            resultArray[i - 1] = items.Count(x => x == i);
        }
    }

    void CalculatingInterest(float[] resultArray, int[] dataArray, int totalAmount)
    {
        for (int i = 1; i <= 4; i++)
        {
            resultArray[i - 1] = (float)Math.Round((float)dataArray[0] / totalAmount * 100, 2);
        }
    }
}
