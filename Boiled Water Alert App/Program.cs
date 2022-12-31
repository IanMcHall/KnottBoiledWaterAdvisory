bool z41701 = false;
bool z41640 = false;
bool z41822 = false;
bool z41844 = false;
bool z41773 = false;
bool z41817 = false;
bool z41722 = false;
bool z41630 = false;
bool z41862 = false;
bool z41740 = false;
bool z41828 = false;
bool z41725 = false;
bool z41843 = false;
bool z41847 = false;
bool z41836 = false;
bool z41831 = false;
bool z41834 = false;
bool z41839 = false;
bool z41772 = false;
bool z41859 = false;
bool z41743 = false;
bool z41759 = false;
bool z41861 = false;
bool z41643 = false;


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
            z41701 = true;
            break;
        case "41640":
            z41640 = true;
            break;
        case "41822":
            z41822 = true;
            break;
        case "41844":
            z41844 = true;
            break;
        case "41773":
            z41773 = true;
            break;
        case "41817":
            z41817 = true;
            break;
        case "41722":
            z41722 = true;
            break;
        case "41630":
            z41630 = true;
            break;
        case "41862":
            z41862 = true;
            break;
        case "41740":
            z41740 = true;
            break;
        case "41828":
            z41828 = true;
            break;
        case "41725":
            z41725 = true;
            break;
        case "41843":
            z41843 = true;
            break;
        case "41847":
            z41847 = true;
            break;
        case "41836":
            z41836 = true;
            break;
        case "41831":
            z41831 = true;
            break;
        case "41834":
            z41834 = true;
            break;
        case "41839":
            z41839 = true;
            break;
        case "41772":
            z41772 = true;
            break;
        case "41859":
            z41859 = true;
            break;
        case "41743":
            z41743 = true;
            break;
        case "41759":
            z41759 = true;
            break;
        case "41861":
            z41861 = true;
            break;
        case "41643":
            z41643 = true;
            break;
            default:
            Console.WriteLine("Invalid Area Code. Please try again.");
            break;
    }
}

void CheckCurrentStatus()
{
    Console.WriteLine("41701 = " + (z41701));
    Console.WriteLine("41640 = " + (z41640));
    Console.WriteLine("41822 = " + (z41822));
    Console.WriteLine("41844 = " + (z41844));
    Console.WriteLine("41773 = " + (z41773));
    Console.WriteLine("41817 = " + (z41817));
    Console.WriteLine("41722 = " + (z41722));
    Console.WriteLine("41630 = " + (z41630));
    Console.WriteLine("41862 = " + (z41862));
    Console.WriteLine("41740 = " + (z41740));
    Console.WriteLine("41828 = " + (z41828));
    Console.WriteLine("41725 = " + (z41725));
    Console.WriteLine("41843 = " + (z41843));
    Console.WriteLine("41847 = " + (z41847));
    Console.WriteLine("41836 = " + (z41836));
    Console.WriteLine("41831 = " + (z41831));
    Console.WriteLine("41834 = " + (z41834));
    Console.WriteLine("41839 = " + (z41839));
    Console.WriteLine("41772 = " + (z41772));
    Console.WriteLine("41859 = " + (z41859));
    Console.WriteLine("41743 = " + (z41743));
    Console.WriteLine("41759 = " + (z41759));
    Console.WriteLine("41861 = " + (z41861));
    Console.WriteLine("41643 = " + (z41643));
}
