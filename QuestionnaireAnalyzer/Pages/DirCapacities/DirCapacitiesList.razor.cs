﻿using Microsoft.AspNetCore.Components;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Pages.DirCapacities;

public partial class DirCapacitiesList
{
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDataService DataService { get; set; }

    private List<DirModel> _dirModels = new();

    protected override async Task OnInitializedAsync()
    {
        _dirModels = await DataService.GetAllAsync<DirModel>();
    }

    private void OpenDirById(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Dir}{ClientRoutes.Capacities}/{id}");
    }

    private void OpenDirByIdForUdate(int id)
    {
        _navigationManager.NavigateTo($"{ClientRoutes.Dir}{ClientRoutes.Capacities}{ClientRoutes.Update}/{id}");
    }

    private async Task DeleteFromDb(int id)
    {
        await DataService.DeleteByIdAsync<DirModel>(id);

        _dirModels = await DataService.GetAllAsync<DirModel>();

        StateHasChanged();
    }

    private void OpenInputTypePage()
    {
        _navigationManager.NavigateTo(NavigationHelper.ListNewItemNextPage(_navigationManager.Uri));
    }
}