using Boiled_Water_Alert_App;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

Zip z41701 = new Zip();
z41701.zipCode = "41701";
z41701.status = false;

Zip z41640 = new Zip();
z41640.zipCode = "41640";
z41640.status = false;

Zip z41822 = new Zip();
z41822.zipCode = "41822";
z41822.status = false;

Zip z41844 = new Zip();
z41844.zipCode = "41844";
z41844.status = false;

Zip z41773 = new Zip();
z41773.zipCode = "41773";
z41773.status = false;

Zip z41817 = new Zip();
z41817.zipCode = "41817";
z41817.status = false;

Zip z41722 = new Zip();
z41722.zipCode = "41722";
z41722.status = false;

Zip z41630 = new Zip();
z41630.zipCode = "41630";
z41630.status = false;

Zip z41862 = new Zip();
z41862.zipCode = "41862";
z41862.status = false;

Zip z41740 = new Zip();
z41740.zipCode = "41740";
z41740.status = false;

Zip z41828 = new Zip();
z41828.zipCode = "41828";
z41828.status = false;

Zip z41725 = new Zip();
z41725.zipCode = "41725";
z41725.status = false;

Zip z41843 = new Zip();
z41843.zipCode = "41843";
z41843.status = false;

Zip z41847 = new Zip();
z41847.zipCode = "41847";
z41847.status = false;

Zip z41836 = new Zip();
z41836.zipCode = "41836";
z41836.status = false;

Zip z41831 = new Zip();
z41831.zipCode = "41831";
z41831.status = false;

Zip z41834 = new Zip();
z41834.zipCode = "41834";
z41834.status = false;

Zip z41839 = new Zip();
z41839.zipCode = "41839";
z41839.status = false;

Zip z41772 = new Zip();
z41772.zipCode = "41772";
z41772.status = false;

Zip z41859 = new Zip();
z41859.zipCode = "41859";
z41859.status = false;

Zip z41743 = new Zip();
z41743.zipCode = "41743";
z41743.status = false;

Zip z41759 = new Zip();
z41759.zipCode = "41759";
z41759.status = false;

Zip z41861 = new Zip();
z41861.zipCode = "41861";
z41861.status = false;

Zip z41643 = new Zip();
z41643.zipCode = "41643";
z41643.status = false;

List<Zip> zipCodes = new List<Zip>();
    void WriteToCsv(List<Zip> zipCodes)
    {
    using (var writer = new StreamWriter("CurrentData.csv"))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
        csv.WriteRecords(zipCodes);
    }
    }
 List<Zip> ReadFromCsv()
{
    var config = new CsvConfiguration(CultureInfo.InvariantCulture);
    using (var reader = new StreamReader("CurrentData.csv"))
    using (var csv = new CsvReader(reader, config))
    {
        var characters = csv.GetRecords<Zip>().ToList();
        return zipCodes;
    }
}

Console.WriteLine("Knott County Boiled Water Advisory Automated System");
Console.WriteLine("Please select an option:");

string userSelection;
do
{
    Console.WriteLine("1. Update Boiled Water Advisory Alerts");
    Console.WriteLine("2. Check Current Status");
    Console.WriteLine("3. Add New Customer");
    Console.WriteLine("4. Alter Existing Customer");
    Console.WriteLine("9. Exit");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            UpdateBoiledWaterAdvisoryAlerts();
            break;
        case "2":
            CheckCurrentStatus();
            break;
        case "3": 
            //AddNewCustomer();
            break;
        case "4":
            //AlterExisitngCustomer();
            break;
    }
} while (userSelection != "9");

void UpdateBoiledWaterAdvisoryAlerts()
{
    Console.WriteLine("Please Enter the Zip Code of the Affected Area");
   string userResponse = Console.ReadLine();
    switch(userResponse)
    {
        case "41701":
            z41701.status = true;
            break;
        case "41640":
            z41640.status = true;
            break;
        case "41822":
            z41822.status = true;
            break;
        case "41844":
            z41844.status = true;
            break;
        case "41773":
            z41773.status = true;
            break;
        case "41817":
            z41817.status = true;
            break;
        case "41722":
            z41722.status = true;
            break;
        case "41630":
            z41630.status = true;
            break;
        case "41862":
            z41862.status = true;
            break;
        case "41740":
            z41740.status = true;
            break;
        case "41828":
            z41828.status = true;
            break;
        case "41725":
            z41725.status = true;
            break;
        case "41843":
            z41843.status = true;
            break;
        case "41847":
            z41847.status = true;
            break;
        case "41836":
            z41836.status = true;
            break;
        case "41831":
            z41831.status = true;
            break;
        case "41834":
            z41834.status = true;
            break;
        case "41839":
            z41839.status = true;
            break;
        case "41772":
            z41772.status = true;
            break;
        case "41859":
            z41859.status = true;
            break;
        case "41743":
            z41743.status = true;
            break;
        case "41759":
            z41759.status = true;
            break;
        case "41861":
            z41861.status = true;
            break;
        case "41643":
            z41643.status = true;
            break;
            default:
            Console.WriteLine("Invalid Area Code. Please try again.");
            break;
    }
}

void CheckCurrentStatus()
{
    Console.WriteLine("41701 = " + (z41701.status));
    Console.WriteLine("41640 = " + (z41640.status));
    Console.WriteLine("41822 = " + (z41822.status));
    Console.WriteLine("41844 = " + (z41844.status));
    Console.WriteLine("41773 = " + (z41773.status));
    Console.WriteLine("41817 = " + (z41817.status));
    Console.WriteLine("41722 = " + (z41722.status));
    Console.WriteLine("41630 = " + (z41630.status));
    Console.WriteLine("41862 = " + (z41862.status));
    Console.WriteLine("41740 = " + (z41740.status));
    Console.WriteLine("41828 = " + (z41828.status));
    Console.WriteLine("41725 = " + (z41725.status));
    Console.WriteLine("41843 = " + (z41843.status));
    Console.WriteLine("41847 = " + (z41847.status));
    Console.WriteLine("41836 = " + (z41836.status));
    Console.WriteLine("41831 = " + (z41831.status));
    Console.WriteLine("41834 = " + (z41834.status));
    Console.WriteLine("41839 = " + (z41839.status));
    Console.WriteLine("41772 = " + (z41772.status));
    Console.WriteLine("41859 = " + (z41859.status));
    Console.WriteLine("41743 = " + (z41743.status));
    Console.WriteLine("41759 = " + (z41759.status));
    Console.WriteLine("41861 = " + (z41861.status));
    Console.WriteLine("41643 = " + (z41643.status));
}
