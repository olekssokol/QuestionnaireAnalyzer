using ClosedXML.Excel;
using QuestionnaireAnalyzer.Common.Helpers;
using QuestionnaireAnalyzer.Contracts.Interfaces.Services;
using QuestionnaireAnalyzer.Contracts.Models.Dir;

namespace QuestionnaireAnalyzer.Services;

public class ExcelService : IExcelService
{
    public DirCapacityModel GetDirCapacityFromExcel()
    {
        var model = new DirCapacityModel
        {
            
        };
        
        
        var filePath = "C:/Users/Oleksii/Desktop/1.xlsx"; //TODO: handling of an open file error

        using var workbook = new XLWorkbook(filePath);
        
        var worksheet = workbook.Worksheet(1);

        model.Name = worksheet.Cell("D3").Value.ToString();

        for (int i = 7; i <= 16; i++)
        {
            var cellValue = worksheet.Cell($"C{i}").Value.ToString();

            if (!string.IsNullOrWhiteSpace(cellValue))
            {
                model.Table1Elements.Add(new DirCapacityTable1Item
                {
                    Name = cellValue,
                    T1Q1 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell($"E{i}").Value),
                    T1Q2 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell($"F{i}").Value),
                    T1Q3 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell($"G{i}").Value),
                    T1Q4 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell($"H{i}").Value),
                });
            }
        }

        model.T2Q1P1 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E21").Value);
        model.pT2Q2P2 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E22").Value);
        model.T2Q2P3 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E23").Value);
        if (model.T2Q2P3)
        {
            model.T2Q2P3Name = worksheet.Cell("E24").Value.ToString();
        }
        model.T2Q2P4 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E25").Value);
        model.pT2Q2P5 = worksheet.Cell("E26").Value.ToString();
        model.T2Q2P6 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E27").Value);
        model.pT2Q2P7 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E28").Value);
        model.pT2Q2P8 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E29").Value);
        model.pT2Q2P8 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E29").Value);
        model.pT2Q2P9 = ParsingExcelHelper.GetIntValueFromCell(worksheet.Cell("E30").Value);
        
        model.T2Q3P10 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E31").Value);
        model.T2Q3P11 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E32").Value);
        model.T2Q3P12 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E33").Value);
        
        model.pT2Q4P13 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E34").Value);
        model.pT2Q4P14 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E35").Value);
        model.pT2Q4P15 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E36").Value);
        model.T2Q4P16 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E37").Value);
        model.T2Q4P17 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E38").Value);
        if (model.T2Q4P17)
        {
            model.T2Q4P17Location = worksheet.Cell("E39").Value.ToString();
        }
        model.T2Q4P18 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E40").Value);
        model.T2Q4P19 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E41").Value);
        model.T2Q4P20 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E42").Value);
        model.pT2Q4P21 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E43").Value);

        model.pT2Q5P22 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E44").Value);
        model.pT2Q5P23 = ParsingExcelHelper.GetFloatValueFromCell(worksheet.Cell("E45").Value);
        model.pT2Q5P24 = ParsingExcelHelper.GetFloatValueFromCell(worksheet.Cell("E46").Value);
        model.T2Q5P25 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E47").Value);
        model.T2Q5P26 = ParsingExcelHelper.GetFloatValueFromCell(worksheet.Cell("E48").Value);
        model.T2Q5P27 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E49").Value);
        
        model.T2Q6P28 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E50").Value);
        model.T2Q6P29 = ParsingExcelHelper.GetBoolValueFromCell(worksheet.Cell("E51").Value);


        model.T3Q1P1 = worksheet.Cell("E56").Value.ToString();
        
        model.T3Q2P2 = worksheet.Cell("E57").Value.ToString();
        model.T3Q2P3 = worksheet.Cell("E58").Value.ToString();
        model.T3Q2P4 = worksheet.Cell("E59").Value.ToString();
        model.T3Q2P5 = worksheet.Cell("E60").Value.ToString();
        model.T3Q2P6 = worksheet.Cell("E61").Value.ToString();
        model.T3Q2P7 = worksheet.Cell("E62").Value.ToString();
        model.T3Q2P8 = worksheet.Cell("E63").Value.ToString();
        model.T3Q2P9 = worksheet.Cell("E64").Value.ToString();
        
        model.T4Q1P10 = worksheet.Cell("E65").Value.ToString();
        model.T4Q1P11 = worksheet.Cell("E66").Value.ToString();
        model.T4Q1P12 = worksheet.Cell("E67").Value.ToString();
        
        model.T5Q1P13 = worksheet.Cell("E68").Value.ToString();
        model.T5Q1P14 = worksheet.Cell("E69").Value.ToString();
        model.T5Q1P15 = worksheet.Cell("E70").Value.ToString();
        model.T5Q1P16 = worksheet.Cell("E71").Value.ToString();
        model.T5Q1P17 = worksheet.Cell("E72").Value.ToString();
        model.T5Q1P18 = worksheet.Cell("E73").Value.ToString();
        model.T5Q1P19 = worksheet.Cell("E74").Value.ToString();
        model.T5Q1P20 = worksheet.Cell("E75").Value.ToString();
        model.T5Q1P21 = worksheet.Cell("E76").Value.ToString();
        
        model.T6Q1P22 = worksheet.Cell("E77").Value.ToString();
        model.T6Q1P23 = worksheet.Cell("E78").Value.ToString();
        model.T6Q1P24 = worksheet.Cell("E79").Value.ToString();
        model.T6Q1P25 = worksheet.Cell("E80").Value.ToString();
        model.T6Q1P26 = worksheet.Cell("E81").Value.ToString();
        model.T6Q1P27 = worksheet.Cell("E82").Value.ToString();
        
        model.T7Q1P28 = worksheet.Cell("E83").Value.ToString();
        model.T7Q1P29 = worksheet.Cell("E84").Value.ToString();
        
        return model;
    }
}
