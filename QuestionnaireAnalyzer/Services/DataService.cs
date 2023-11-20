using LiteDB;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;

namespace QuestionnaireAnalyzer.Services;

public class DataService : IDataService
{
    private string dataCollectionName = "localdata";
    private readonly ISecureStorageService secureStorageService;

    public DataService(ISecureStorageService secureStorageService)
    {
        this.secureStorageService = secureStorageService;
    }

    public async Task<List<T>> GetAllAsync<T>()
    {
        dataCollectionName = typeof(T).Name.ToLower();

        using var db = new LiteDatabase(await GetConnectionStringAsync());

        var collection = db.GetCollection<T>(dataCollectionName);

        var items = collection.Query().ToList();

        return items;
    }
    public async Task<T> GetByIdAsync<T>(int id)
    {
        dataCollectionName = typeof(T).Name.ToLower();

        using var db = new LiteDatabase(await GetConnectionStringAsync());

        var collection = db.GetCollection<T>(dataCollectionName);

        //var query = Query.EQ("Id", id);

        var item = collection.FindById(id);

        return item ;
    }

    public async Task<bool> UpdateItemAsync<T>(T item)
    {
        dataCollectionName = typeof(T).Name.ToLower();

        using var db = new LiteDatabase(await GetConnectionStringAsync());

        var collection = db.GetCollection<T>(dataCollectionName);

        var result = collection.Update(item);

        return result;
    }

    public async Task<bool> DeleteByIdAsync<T>(int id)
    {
        dataCollectionName = typeof(T).Name.ToLower();

        using var db = new LiteDatabase(await GetConnectionStringAsync());

        var collection = db.GetCollection<T>(dataCollectionName);

        var query = Query.EQ("Id", id);

        int deleteCount = collection.DeleteMany(query);

        return deleteCount > 0;
    }

    public async Task CreateAsync<T>(T item)
    {
        dataCollectionName = item.GetType().Name.ToLower();

        using var db = new LiteDatabase(await GetConnectionStringAsync());

        var collection = db.GetCollection<T>(dataCollectionName);

        collection.Insert(item);
    }

    private async Task<string> GetConnectionStringAsync()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        var fullPath = Path.Combine(path, "QuestionnaireAnalyzer.db");

        var password = await secureStorageService.Get("password");

        if (password == null)
        {
            password = Guid.NewGuid().ToString();
            await secureStorageService.Save("password", password);
        }

        var connectionString = $"Filename={fullPath};Password={password}";

        return connectionString;
    }
}