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

List<string> nameLisXt = new List<string>()
{
    "Leandro Reis",
    "Lucas Silva",
    "Mateus Reis",
    "Lessa de Oliveira",
    ""
};

ThrowMethods helpers = new();

int decades = helpers.AgeInDecades(43);
Console.WriteLine($"43 is { decades } decades old");

decades = helpers.AgeInDecades(49);
Console.WriteLine($"49 is { decades } decades old");

try
{
    decades = helpers.AgeInDecades(-200);
    Console.WriteLine($"-200 is { decades } decades old");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    decades = helpers.AgeInDecades(200);
    Console.WriteLine($"200 is { decades } decades old");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//string? name = "hello";
//name.Throw().IfWhiteSpace(); // System.ArgumentException: String should not be white space only. (Parameter 'name')
//name.Throw().IfLengthEquals(7); // System.ArgumentException: String length should not be equal to 7. (Parameter 'name')
//name.Throw().IfLengthNotEquals(10); // System.ArgumentException: String length should be equal to 10. (Parameter 'name')
//name.Throw().IfShorterThan(10); // System.ArgumentException: String should not be shorter than 10 characters. (Parameter 'name')
//name.Throw().IfLongerThan(3); // System.ArgumentException: String should not be longer than 3 characters. (Parameter 'name')
//name.Throw().IfEquals("Amichai"); // System.ArgumentException: String should not be equal to 'Amichai' (comparison type: 'Ordinal'). (Parameter 'name')
//name.Throw().IfEquals("Amichai", StringComparison.InvariantCulture); // System.ArgumentException: String should not be equal to 'Amichai' (comparison type: 'InvariantCulture'). (Parameter 'name')
//name.Throw().IfEqualsIgnoreCase("AMICHAI"); // System.ArgumentException: String should not be equal to 'AMICHAI' (comparison type: 'OrdinalIgnoreCase'). (Parameter 'name')
//name.Throw().IfNotEquals("Dan"); // System.ArgumentException: String should be equal to 'Dan' (comparison type: 'Ordinal'). (Parameter 'name')
//name.Throw().IfNotEquals("Dan", StringComparison.InvariantCultureIgnoreCase); // System.ArgumentException: String should be equal to 'Dan' (comparison type: 'InvariantCultureIgnoreCase'). (Parameter 'name')
//name.Throw().IfNotEqualsIgnoreCase("Dan"); // System.ArgumentException: String should be equal to 'Dan' (comparison type: 'OrdinalIgnoreCase'). (Parameter 'name')
//name.Throw().IfContains("substring"); // System.ArgumentException: String should not contain 'substring' (comparison type: 'Ordinal'). (Parameter 'name')
////name.Throw().IfContains("substring", ComparisonType.InvariantCulture); // System.ArgumentException: String should contain 'substring' (comparison type: 'InvariantCulture'). (Parameter 'name')
//name.Throw().IfNotContains("substring"); // System.ArgumentException: String should contain 'substring' (comparison type: 'Ordinal'). (Parameter 'name')
////name.Throw().IfNotContains("substring", ComparisonType.InvariantCultureIgnoreCase); // System.ArgumentException: String should contain 'substring' (comparison type: 'InvariantCultureIgnoreCase'). (Parameter 'name')
//name.Throw().IfStartsWith("Jer"); // System.ArgumentException: String should not start with 'Jer' (comparison type: 'Ordinal'). (Parameter 'name')
//name.Throw().IfStartsWith("JER", StringComparison.OrdinalIgnoreCase); // System.ArgumentException: String should not start with 'JER' (comparison type: 'OrdinalIgnoreCase'). (Parameter 'name')
//name.Throw().IfNotStartsWith("dan"); // System.ArgumentException: String should start with 'dan' (comparison type: 'Ordinal'). (Parameter 'name')
//name.Throw().IfNotStartsWith("dan", StringComparison.InvariantCultureIgnoreCase); // System.ArgumentException: String should start with 'dan' (comparison type: 'InvariantCultureIgnoreCase'). (Parameter 'name')
//name.Throw().IfEndsWith("emy"); // System.ArgumentException: String should not end with 'emy' (comparison type: 'Ordinal'). (Parameter 'name')
//name.Throw().IfEndsWith("EMY", StringComparison.OrdinalIgnoreCase); // System.ArgumentException: String should not end with 'EMY' (comparison type: 'OrdinalIgnoreCase'). (Parameter 'name')
//name.Throw().IfNotEndsWith("dan"); // System.ArgumentException: String should end with 'dan' (comparison type: 'Ordinal'). (Parameter 'name')
//name.Throw().IfNotEndsWith("dan", StringComparison.OrdinalIgnoreCase); // System.ArgumentException: String should end with 'dan' (comparison type: 'OrdinalIgnoreCase'). (Parameter 'name')
//name.Throw().IfMatches("J.*y"); // System.ArgumentException: String should not match RegEx pattern 'J.*y' (Parameter 'name')
//name.Throw().IfMatches("[a-z]{0,10}", RegexOptions.IgnoreCase); // System.ArgumentException: String should not match RegEx pattern '[a-z]{0,10}' (Parameter 'name')
//name.Throw().IfNotMatches("^[0-9]+$"); // System.ArgumentException: String should match RegEx pattern '^[0-9]+$' (Parameter 'name')
//name.Throw().IfNotMatches("abc ", RegexOptions.IgnorePatternWhitespace); // System.ArgumentException: String should match RegEx pattern '^[0-9]+$' (Parameter 'name')

string testString = "    Vai Corinthians!! ";
string results;

results = testString.TrimStart();
Console.WriteLine($"'{results}'");

results = testString.TrimEnd();
Console.WriteLine($"'{results}'");

results = testString.Trim();
Console.WriteLine($"'{results}'");

testString = "1.15";
results = testString.PadLeft(10, '0');
Console.WriteLine(results);

results = testString.PadRight(10, '0');
Console.WriteLine(results);


//Name Validation
Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.WriteLine("Name                 | Error");
Console.WriteLine("--------------------------------------------------------------------------------------------");
foreach (var item in nameLisXt)
{
    Console.WriteLine(string.Format("{0} - {1}", item.PadRight(20, ' '), helpers.NameValidationX(item)));
}
Console.ReadLine();
