namespace QuestionnaireAnalyzer.Contracts.Interfaces.Services;

public interface IDataService
{
    Task CreateAsync<T>(T item);
    Task<List<T>> GetAllAsync<T>();
    Task<T> GetByIdAsync<T>(int id);
    Task<bool> UpdateItemAsync<T>(T item);
    Task<bool> DeleteByIdAsync<T>(int id);

}