namespace QuestionnaireAnalyzer.Contracts.Interfaces.Services;

public interface ISecureStorageService
{
    Task Save(string key, string value);
    Task<string> Get(string key, string defaultValue = null);
}