using QuestionnaireAnalyzer.Contracts.Models.Dir;
using QuestionnaireAnalyzer.Contracts.Models.Test;

namespace QuestionnaireAnalyzer.Pages.Dir;

public partial class DirPage
{
    DirModel Dir = new DirModel();
    private List<Table1> _table1s = new List<Table1>
    {
        new Table1
        {
            Name = "Name1",
            T1Q1 = true,
            T1Q2 = false,
            T1Q3 = false,
            T1Q4 = true,
        },
        new Table1
        {
            Name = "Name2",
            T1Q1 = false,
            T1Q2 = true,
            T1Q3 = true,
            T1Q4 = false,
        },

    };
}
