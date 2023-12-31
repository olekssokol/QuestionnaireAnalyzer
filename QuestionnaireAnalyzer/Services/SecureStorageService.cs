﻿using QuestionnaireAnalyzer.Contracts.Interfaces.Services;

namespace QuestionnaireAnalyzer.Services;

public class SecureStorageService : ISecureStorageService
{
    public async Task<string> Get(string key, string defaultValue = null)
    {
        var result = await SecureStorage.Default.GetAsync(key);

        if (result == null)
        {
            return defaultValue;
        }

        return result;
    }

    public async Task Save(string key, string value)
    {
        await SecureStorage.SetAsync(key, value);
    }
}