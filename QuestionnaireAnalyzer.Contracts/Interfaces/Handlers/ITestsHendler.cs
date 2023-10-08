using ManagedCode.Communication;
using QuestionnaireAnalyzer.Contracts.Commands.Test;
using QuestionnaireAnalyzer.Contracts.Models.Test;

namespace QuestionnaireAnalyzer.Contracts.Interfaces.Handlers;

public interface ITestsHendler
{
    Task<CollectionResult<TestModel>> GetAgenciesAsync();
    Task<Result<TestModel>> GetAgencyAsync(string agencyId);
    Task<Result<TestModel>> CreateAgencyAsync(UpsertTestCommand upsertAgencyCommand);
    Task<Result<TestModel>> UpdateAgencyAsync(UpsertTestCommand upsertAgencyCommand);
    Task<Result> DeleteAgencyAsync(string agencyId);
}
