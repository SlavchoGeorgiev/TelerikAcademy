using System;
//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console
class PrintCompanyInfo
{
    static void Main()
    {
        Company testCompany = new Company();
        Console.Write("Company name: ");
        testCompany.Name = Console.ReadLine();
        Console.Write("Company address: ");
        testCompany.Address = Console.ReadLine();
        Console.Write("Phone number: ");
        testCompany.Phone = Console.ReadLine();
        Console.Write("Fax number:");
        testCompany.Fax = int.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        testCompany.WebSiteAddress = Console.ReadLine();
        Console.Write("Manager first name:");
        testCompany.CompanyManager.FirstName = Console.ReadLine();
        Console.Write("Manager last name:");
        testCompany.CompanyManager.LastName = Console.ReadLine();
        Console.Write("Manager age:");
        testCompany.CompanyManager.Age = int.Parse(Console.ReadLine());
        Console.Write("Manager phone:");
        testCompany.CompanyManager.Phone = Console.ReadLine();
        testCompany.PrintFullInfo();

    }
}