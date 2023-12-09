﻿using QuestionaireAnalyzer.ComponentsCommon.Models;
using QuestionaireAnalyzer.ComponentsCommon.Services.Interfaces;

namespace QuestionaireAnalyzer.ComponentsCommon.Services;

public class PopupService : IPopupService
{
    public IReadOnlyList<ModalModel> Modals { get; }
    public event Action? OnUpdate;
    public event Action<ModalModel>? OnOverlayClicked = null!;

    private readonly List<ModalModel> _modals = new();

    public PopupService()
    {
        Modals = _modals;
    }

    public void Open(ModalModel modalModel)
    {
        if (_modals.Contains(modalModel)) return;

        _modals.Add(modalModel);
        OnUpdate?.Invoke();
    }

    public void Close(ModalModel modalModel)
    {
        if (!_modals.Contains(modalModel)) return;

        _modals.Remove(modalModel);
        OnUpdate?.Invoke();
    }

    public void FireOverlayClicked(ModalModel modalModel)
    {
        OnOverlayClicked?.Invoke(modalModel);
    }
}
