using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using Microsoft.JSInterop;
using QuestionnaireAnalyzer.Contracts.Models.Kii;

namespace QuestionnaireAnalyzer.Pages.KiiCapacity;

public partial class KiiCapacityPage
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

    [Parameter] public int? Id { get; set; }

    private KiiCapacityModel _kiiModel = new();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _kiiModel = await DataService.GetByIdAsync<KiiCapacityModel>(Id.Value);
        }
    }

    private void RemoveTable1Item(KiiCapacityTable1Item item)
    {
        _kiiModel.Table1Elements.Remove(item);
    }

    private void AddTable1Item()
    {
        _kiiModel.Table1Elements.Add(new KiiCapacityTable1Item());

        StateHasChanged();
    }

    private async Task SaveToDb()
    {
        await DataService.CreateAsync<KiiCapacityModel>(_kiiModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }
    private async Task UpdateDbData()
    {
        await DataService.UpdateItemAsync<KiiCapacityModel>(_kiiModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }

    private void UpdateLocation(string location)
    {
        _kiiModel.T2Q4P14Location = location;
    }

    private async void OpenPreviousPage()
    {
        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }
    
    private void UpdateIntData(string dataName, string intName)
    {
        var dataProperty = _kiiModel.GetType().GetProperty(dataName);
        var rangeProperty = _kiiModel.GetType().GetProperty(intName);

        if (dataProperty != null && rangeProperty != null)
        {
            bool checkboxValue = (bool)dataProperty.GetValue(_kiiModel);

            dataProperty.SetValue(_kiiModel, !checkboxValue);

            if (!checkboxValue)
            {
                rangeProperty.SetValue(_kiiModel, 100);
            }
            else
            {
                rangeProperty.SetValue(_kiiModel, 0);
            }
        }

        StateHasChanged();
    }
}
