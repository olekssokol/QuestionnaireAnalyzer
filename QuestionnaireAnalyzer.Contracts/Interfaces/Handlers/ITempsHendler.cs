using ManagedCode.Communication;
using QuestionnaireAnalyzer.Contracts.Commands.Test;
using QuestionnaireAnalyzer.Contracts.Models.Test;

namespace QuestionnaireAnalyzer.Contracts.Interfaces.Handlers;

public interface ITempsHendler
{
    Task<CollectionResult<TempModel>> GetTempsAsync();
    Task<Result<TempModel>> GetTempAsync(string tempId);
    Task<Result<TempModel>> CreateTempAsync(UpsertTempCommand upsertTempCommand);
    Task<Result<TempModel>> UpdateTempAsync(UpsertTempCommand upsertTempCommand);
    Task<Result> DeleteTempAsync(string tempId);
}
