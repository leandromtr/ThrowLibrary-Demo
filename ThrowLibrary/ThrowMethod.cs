using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Throw;

namespace HelperLibrary;

public class ThrowMethods
{
    public int AgeInDecades(int age)
    {
        age.Throw()
            .IfNegative()
            .IfGreaterThan(130);

        return age / 10;
    }

    public void NameValidation(string? name)
    {
        try
        {
            name.ThrowIfNull()
                .IfEmpty()
                .IfWhiteSpace()
                .IfEqualsIgnoreCase("Leandro Reis")
                .IfLongerThan(12); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public string NameValidationX(string name)
    {
        try
        {
            name.ThrowIfNull()
                .IfEmpty()
                .IfWhiteSpace()
                .IfEqualsIgnoreCase("Leandro Reis")
                .IfLongerThan(12);
            return "Ok";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }
}

