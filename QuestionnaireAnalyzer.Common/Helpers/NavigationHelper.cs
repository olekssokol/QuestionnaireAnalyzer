using QuestionnaireAnalyzer.Contracts.Constants;

namespace QuestionnaireAnalyzer.Common.Helpers;

public static class NavigationHelper
{
    public static string MethodologyNextPage(string uri, string methodologyUri)
    {
        if (uri.Contains(ClientRoutes.Dir))
        {
            return ClientRoutes.Dir + methodologyUri + ClientRoutes.SelectType;
        }
        else if (uri.Contains(ClientRoutes.Kii))
        {
            return ClientRoutes.Kii + methodologyUri + ClientRoutes.SelectType;
        }

        throw new ArgumentException("Invalid uri");
    }

    public static string SelectTypeNextPage(string uri, string typeUri)
    {
        return uri.Replace(ClientRoutes.SelectType, string.Empty) + typeUri;
    }

    public static string ListNewItemNextPage(string uri)
    {
        return uri.Replace(ClientRoutes.List, string.Empty) + ClientRoutes.InputType;
    }

    public static string InputTypeNextPage(string uri)
    {
        return uri.Replace(ClientRoutes.InputType, string.Empty);
    }
}
