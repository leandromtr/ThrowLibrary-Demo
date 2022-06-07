using HelperLibrary;
using System.Text.RegularExpressions;
using Throw;

List<string?> nameList = new List<string?>()
{
    "Leandro Reis",
    "Lucas Silva",
    "Mateus Reis",
    "Lessa de Oliveira",
    "",
    null
};


List<string> uriList = new List<string>()
{
    "https://github.com/leandromtr/DemoFeatures",
    "https://www.oquevisitar.com.br/",
    "http://www6.teste.com/",
    "https://github.com/amantinband/throw"
};

List<DateTime> dateList = new List<DateTime>()
{
    DateTime.Now,
    DateTime.Now.AddDays(-10000),
    DateTime.Now.AddDays(10000),
};


List<int> ageList = new List<int>()
{
    34,
    11,
    143,
    76,
    18,
    -2
};

List<string> nameLisXt = new List<string>()
{
    "Leandro Reis",
    "Lucas Silva",
    "Lessa de Oliveira",
    "Ana Sa",
    "Mateus Reis",
    "Raxptos Xavier",
    "Ana Sa",
    ""
};

ThrowMethods helpers = new();


//String Validation
Console.WriteLine("");
Console.WriteLine("Example String Validations");
Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.WriteLine("Name                 - Error");
Console.WriteLine("--------------------------------------------------------------------------------------------");
foreach (var item in nameLisXt)
{
    Console.WriteLine(string.Format("{0} - {1}", item.PadRight(20, ' '), helpers.NameValidationX(item)));
}


//DateTime Validation
Console.WriteLine("");
Console.WriteLine("Example DateTime Validations");
Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.WriteLine("Date                 - Error");
Console.WriteLine("--------------------------------------------------------------------------------------------");
foreach (var item in dateList)
{
    Console.WriteLine(string.Format("{0} - {1}", item.ToString().PadRight(20, ' '), helpers.DateValidation(item)));
}


////URI Validation
//Console.WriteLine("");
//Console.WriteLine("Example URI Validations");
//Console.WriteLine("--------------------------------------------------------------------------------------------");
//Console.WriteLine("URI                  - Error");
//Console.WriteLine("--------------------------------------------------------------------------------------------");
//foreach (var item in uriList)
//{
//    Console.WriteLine(string.Format("{0} - {1}", item.PadRight(20, ' '), helpers.URIValidation(item)));
//}


//Numbers Validation
Console.WriteLine("");
Console.WriteLine("Example Numbers Validations");
Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.WriteLine("Number               - Error");
Console.WriteLine("--------------------------------------------------------------------------------------------");
foreach (var item in ageList)
{
    Console.WriteLine(string.Format("{0} - {1}", item.ToString().PadRight(20, ' '), helpers.AdultAgeValidation(item)));
}
Console.ReadLine();