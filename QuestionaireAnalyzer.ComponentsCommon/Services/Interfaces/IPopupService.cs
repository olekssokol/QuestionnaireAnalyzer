using QuestionaireAnalyzer.ComponentsCommon.Models;

namespace QuestionaireAnalyzer.ComponentsCommon.Services.Interfaces;

public interface IPopupService
{
    IReadOnlyList<ModalModel> Modals { get; }

    event Action? OnUpdate;
    event Action<ModalModel>? OnOverlayClicked;

    void Open(ModalModel modalModel);
    void Close(ModalModel modalModel);
    void FireOverlayClicked(ModalModel modalModel);
}
