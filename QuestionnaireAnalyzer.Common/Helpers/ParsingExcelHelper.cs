using ClosedXML.Excel;

namespace QuestionnaireAnalyzer.Common.Helpers;

public static class ParsingExcelHelper
{
    public static bool GetBoolValueFromCell(XLCellValue data)
    {
        var value = data.ToString();

        if (!string.IsNullOrWhiteSpace(value))
        {
            return value is "Так" or "так";
        }

        return false;
    }
    
    public static int GetIntValueFromCell(XLCellValue data)
    {
        var value = data.ToString();

        if (!string.IsNullOrWhiteSpace(value))
        {
            if (int.TryParse(value, out int num))
            {
                return num;
            }
        }

        return 0;
    }
    
    public static float GetFloatValueFromCell(XLCellValue data)
    {
        var value = data.ToString();

        if (!string.IsNullOrWhiteSpace(value))
        {
            if (float.TryParse(value, out float num))
            {
                return num;
            }
        }

        return 0f;
    }
}