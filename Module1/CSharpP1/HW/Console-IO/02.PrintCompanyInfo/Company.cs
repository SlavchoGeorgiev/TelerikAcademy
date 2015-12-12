using System;

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int Fax { get; set; }
    public string WebSiteAddress { get; set; }
    public Manager CompanyManager = new Manager();
    public void PrintFullInfo()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine("Address: {0}", this.Address);
        Console.WriteLine("Tel. {0}", this.Phone);
        Console.WriteLine("Fax: {0}", this.Fax);
        Console.WriteLine("Web site: {0}", this.WebSiteAddress);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", this.CompanyManager.FirstName, this.CompanyManager.LastName, this.CompanyManager.Age, this.CompanyManager.Phone);
    }

}
