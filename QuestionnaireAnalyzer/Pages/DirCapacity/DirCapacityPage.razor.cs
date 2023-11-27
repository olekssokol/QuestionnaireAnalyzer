using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;
using Microsoft.JSInterop;
using System.Reflection;

namespace QuestionnaireAnalyzer.Pages.DirCapacity;

public partial class DirCapacityPage
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

    [Parameter] public int? Id { get; set; }

    private DirCapacityModel _dirModel = new();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _dirModel = await DataService.GetByIdAsync<DirCapacityModel>(Id.Value);
        }
    }

    private void RemoveTable1Item(DirCapacityTable1Item item)
    {
        _dirModel.Table1Elements.Remove(item);
    }

    private void AddTable1Item()
    {
        _dirModel.Table1Elements.Add(new DirCapacityTable1Item());

        StateHasChanged();
    }

    private async Task SaveToDb()
    {
        await DataService.CreateAsync<DirCapacityModel>(_dirModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }

    private async Task UpdateDbData()
    {
        await DataService.UpdateItemAsync<DirCapacityModel>(_dirModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }

    private void UpdateLocation(string location)
    {
        _dirModel.T2Q4P17Location = location;
    }

    private void UpdateIntData(string dataName, string intName)
    {
        var dataProperty = _dirModel.GetType().GetProperty(dataName);
        var rangeProperty = _dirModel.GetType().GetProperty(intName);

        if (dataProperty != null && rangeProperty != null)
        {
            bool checkboxValue = (bool)dataProperty.GetValue(_dirModel);

            dataProperty.SetValue(_dirModel, !checkboxValue);

            if (!checkboxValue)
            {
                rangeProperty.SetValue(_dirModel, 100);
            }
            else
            {
                rangeProperty.SetValue(_dirModel, 0);
            }
        }

        StateHasChanged();
    }

    private async void OpenPreviousPage()
    {
        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }
}
