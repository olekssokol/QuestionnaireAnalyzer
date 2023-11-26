namespace QuestionnaireAnalyzer.Contracts.Models.Dir;

public class DirCapacityModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly Data { get; set; } //TODO: need implement

    #region Таблиця 1

    public List<DirCapacityTable1Item> Table1Elements { get; set; } = new();

    #endregion

    #region Таблиця 2

    #region Організаційна структура
    public bool T2Q1P1 { get; set; }
    #endregion

    #region Штатна структура
    public bool T2Q2P2 { get; set; }
    public bool T2Q2P3 { get; set; }
    public string T2Q2P3Name { get; set; } = string.Empty;
    public bool T2Q2P4 { get; set; }
    public string T2Q2P5 { get; set; } = string.Empty;
    public bool T2Q2P6 { get; set; }
    public bool T2Q2P7 { get; set; }
    public bool T2Q2P8 { get; set; }
    public int T2Q2P9 { get; set; }
    #endregion

    #region Політики
    public bool T2Q3P10 { get; set; }
    public bool T2Q3P11 { get; set; }
    public bool T2Q3P12 { get; set; }
    #endregion

    #region Технології
    public bool T2Q4P13 { get; set; }
    public bool T2Q4P14 { get; set; }
    public bool T2Q4P15 { get; set; }
    public bool T2Q4P16 { get; set; }
    public bool T2Q4P17 { get; set; }
    public string T2Q4P17Location { get; set; } = string.Empty;
    public bool T2Q4P18 { get; set; }
    public bool T2Q4P19 { get; set; }
    public bool T2Q4P20 { get; set; }
    public bool T2Q4P21 { get; set; }
    #endregion

    #region Фінансування
    public bool T2Q5P22 { get; set; }
    public float T2Q5P23 { get; set; }
    public float T2Q5P24 { get; set; }
    public bool T2Q5P25 { get; set; }
    public float T2Q5P26 { get; set; }
    public bool T2Q5P27 { get; set; }
    #endregion

    #region Планування
    public bool T2Q6P28 { get; set; }
    public bool T2Q6P29 { get; set; }
    #endregion

    #endregion

    #region Таблиця 3

    #region Організаційна структура
    public string T3Q1P1 { get; set; } = string.Empty;
    #endregion

    #region Персонал
    public string T3Q2P2 { get; set; } = string.Empty;
    public string T3Q2P3 { get; set; } = string.Empty;
    public string T3Q2P4 { get; set; } = string.Empty;
    public string T3Q2P5 { get; set; } = string.Empty;
    public string T3Q2P6 { get; set; } = string.Empty;
    public string T3Q2P7 { get; set; } = string.Empty;
    public string T3Q2P8 { get; set; } = string.Empty;
    public string T3Q2P9 { get; set; } = string.Empty;
    #endregion

    #endregion

    #region Таблиця 4

    #region Політики
    public string T4Q1P10 { get; set; } = string.Empty;
    public string T4Q1P11 { get; set; } = string.Empty;
    public string T4Q1P12 { get; set; } = string.Empty;
    #endregion

    #endregion

    #region Таблиця 5

    #region Технології
    public string T5Q1P13 { get; set; } = string.Empty;
    public string T5Q1P14 { get; set; } = string.Empty;
    public string T5Q1P15 { get; set; } = string.Empty;
    public string T5Q1P16 { get; set; } = string.Empty;
    public string T5Q1P17 { get; set; } = string.Empty;
    public string T5Q1P18 { get; set; } = string.Empty;
    public string T5Q1P19 { get; set; } = string.Empty;
    public string T5Q1P20 { get; set; } = string.Empty;
    public string T5Q1P21 { get; set; } = string.Empty;
    #endregion

    #endregion

    #region Таблиця 6

    #region Фінансування
    public string T6Q1P22 { get; set; } = string.Empty;
    public string T6Q1P23 { get; set; } = string.Empty;
    public string T6Q1P24 { get; set; } = string.Empty;
    public string T6Q1P25 { get; set; } = string.Empty;
    public string T6Q1P26 { get; set; } = string.Empty;
    public string T6Q1P27 { get; set; } = string.Empty;
    #endregion

    #endregion

    #region Таблиця 7

    #region Планування
    public string T7Q1P28 { get; set; } = string.Empty;
    public string T7Q1P29 { get; set; } = string.Empty;
    #endregion

    #endregion

}
