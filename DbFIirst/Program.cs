

using DbFIirst;

class Program
{
    public static void Menu()
    {
        Console.WriteLine("Enter the choice : 1.Select property \n" +
            "2.Insert property \n 3.Delete Property \n 4.Update Property");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                PropertyPropShop.selectProperty();
                break;
            case 2:
                PropertyPropShop.insertProperty();
                break;
            case 3:
                PropertyPropShop.deleteProperty();
                break;
            case 4:
                PropertyPropShop.updateProperty();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
    public static void Main(string[] args)
    {
        Menu();
        Console.WriteLine("Would you like to continue Y / N");
        char option = Convert.ToChar(Console.ReadLine());
        while(option!='N' && option=='Y')
        {
            Menu();
        }
    }
}