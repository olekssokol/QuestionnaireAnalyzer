using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Contracts.Interfaces.Services;

public interface IExcelService
{
    DirCapacityModel GetDirCapacityFromExcel();

}