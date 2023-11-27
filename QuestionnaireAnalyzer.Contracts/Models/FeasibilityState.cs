using System.Runtime.ConstrainedExecution;
namespace QuestionnaireAnalyzer.Contracts.Models;

public class FeasibilityState
{
    public string Current { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
    public string Measures{ get; set; } = string.Empty;
}
