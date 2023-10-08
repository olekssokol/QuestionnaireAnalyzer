using ManagedCode.Communication;
using QuestionnaireAnalyzer.Contracts.Commands.Test;
using QuestionnaireAnalyzer.Contracts.Interfaces.Handlers;
using QuestionnaireAnalyzer.Contracts.Models.Test;

namespace QuestionnaireAnalyzer.Services.Handlers;

public class TestsHendler : ITestsHendler
{
    public Task<Result<TestModel>> CreateAgencyAsync(UpsertTestCommand upsertAgencyCommand)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteAgencyAsync(string agencyId)
    {
        throw new NotImplementedException();
    }

    public Task<CollectionResult<TestModel>> GetAgenciesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Result<TestModel>> GetAgencyAsync(string agencyId)
    {
        throw new NotImplementedException();
    }

    public Task<Result<TestModel>> UpdateAgencyAsync(UpsertTestCommand upsertAgencyCommand)
    {
        throw new NotImplementedException();
    }
}
    