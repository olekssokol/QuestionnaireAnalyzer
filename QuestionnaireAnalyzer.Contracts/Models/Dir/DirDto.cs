using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireAnalyzer.Contracts.Models.Dir;

public class DirDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly Data { get; set; }
}
