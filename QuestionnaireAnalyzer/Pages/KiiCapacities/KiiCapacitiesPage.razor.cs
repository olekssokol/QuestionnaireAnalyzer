using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using Microsoft.JSInterop;
using QuestionnaireAnalyzer.Contracts.Models.Kii;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Pages.KiiCapacities;

public partial class KiiCapacitiesPage
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

    [Parameter] public int? Id { get; set; }

    private KiiCapacitiesModel _kiiModel = new();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _kiiModel = await DataService.GetByIdAsync<KiiCapacitiesModel>(Id.Value);
        }
    }

    private void RemoveTable1Item(KiiCapacitiesTable1Item item)
    {
        _kiiModel.Table1Elements.Remove(item);
    }

    private void AddTable1Item()
    {
        _kiiModel.Table1Elements.Add(new KiiCapacitiesTable1Item());

        StateHasChanged();
    }

    private async Task SaveToDb()
    {
        await DataService.CreateAsync<KiiCapacitiesModel>(_kiiModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }
    private async Task UpdateDbData()
    {
        await DataService.UpdateItemAsync<KiiCapacitiesModel>(_kiiModel);

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
}
