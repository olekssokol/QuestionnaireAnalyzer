using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;
using Microsoft.JSInterop;

namespace QuestionnaireAnalyzer.Pages.DirCapacities;

public partial class DirCapacitiesPage
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }
    [Inject] private IJSRuntime JSRuntime { get; set; }

    [Parameter] public int? Id { get; set; }

    private DirModel _dirModel = new();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _dirModel = await DataService.GetByIdAsync<DirModel>(Id.Value);
        }
    }

    private void RemoveTable1Item(Table1Item item)
    {
        _dirModel.Table1Elements.Remove(item);
    }

    private void AddTable1Item()
    {
        _dirModel.Table1Elements.Add(new Table1Item());

        StateHasChanged();
    }

    private async Task SaveToDb()
    {
        await DataService.CreateAsync<DirModel>(_dirModel);

        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }


    private void UpdateLocation(string location)
    {
        _dirModel.T2Q4P17Location = location;
    }

    private async void OpenPreviousPage()
    {
        await JSRuntime.InvokeVoidAsync("openPreviousPage");
    }
}
