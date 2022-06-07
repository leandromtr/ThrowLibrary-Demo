using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Throw;

namespace HelperLibrary;

public class ThrowMethods
{
    public string AdultAgeValidation(int age)
    {
        try
        {
            age.Throw()
            .IfNegative()
            .IfLessThan(18)
            .IfGreaterThan(130);
            return "Ok";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }    
    
    //public string URIValidation(string uri)
    //{
    //    try
    //    {
    //        uri.Throw()
    //            .IfNotHttps(uri);
    //        return "Ok";
    //    }
    //    catch (Exception ex)
    //    {
    //        return ex.Message;
    //    }
    //}

    public void NameValidation(string? name)
    {
        try
        {
            name.ThrowIfNull()
                .IfEmpty()
                .IfWhiteSpace()
                .IfEqualsIgnoreCase("Leandro Reis")
                .IfLongerThan(12)
                .IfContains("xpto");
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
                .IfShorterThan(7)
                .IfLongerThan(12);
            return "Ok";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }    
    
    public string DateValidation(DateTime date)
    {
        try
        {
            date.ThrowIfNull()
                .IfGreaterThan(p => p.Date, DateTime.Now.AddYears(-20));
            return "Ok";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}

