using ManagedCode.Communication;
using QuestionnaireAnalyzer.Contracts.Commands.Test;
using QuestionnaireAnalyzer.Contracts.Interfaces.Handlers;
using QuestionnaireAnalyzer.Contracts.Models.Test;

namespace QuestionnaireAnalyzer.Services.Handlers;

public class TempsHendler : ITempsHendler
{
    public Task<Result<TempModel>> CreateTempAsync(UpsertTempCommand upsertTempCommand)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteTempAsync(string tempId)
    {
        throw new NotImplementedException();
    }

    public Task<Result<TempModel>> GetTempAsync(string tempId)
    {
        throw new NotImplementedException();
    }

    public Task<CollectionResult<TempModel>> GetTempsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Result<TempModel>> UpdateTempAsync(UpsertTempCommand upsertTempCommand)
    {
        throw new NotImplementedException();
    }
}
    