namespace QuestionnaireAnalyzer.Contracts.Constants;

public class ApiEndpoints
{
    private const string IdPlaceholder = "{id}";

    public static class Temps
    {
        private const string Base = "/temps";

        public const string GetAll = Base;
        public const string GetById = $"{Base}/{IdPlaceholder}";
        public const string Create = Base;
        public const string Update = Base;
        public const string Delete = $"{Base}/{IdPlaceholder}";
    }
}
