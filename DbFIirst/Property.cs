using DbFIirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


//C:\Users\JeniferY\Desktop\iinterchange\Console\DbFIirst\DbFIirst\DbFIirst.csproj
namespace DbFIirst
{
    internal class PropertyPropShop

    {
        public static void getUserInput()
        {

            Property p = new Property();
            Console.WriteLine("Enter the property name");
            p.Propname = Console.ReadLine();
            Console.WriteLine("Enter the address");
            p.Address = Console.ReadLine();
            Console.WriteLine("What do you like to do buy/sell/rent");
            p.Purpose = Console.ReadLine();
            Console.WriteLine("Enter the price:");
            p.Price = Convert.ToInt32(Console.ReadLine());

           // return p;
           
            
        }

        public static void insertProperty()
        {

            using (var db = new igtContext())
            {
               // getUserInput();
               // Property p = new Property();
                Property p = new Property();
                Console.WriteLine("Enter the property name");
                p.Propname = Console.ReadLine();
                Console.WriteLine("Enter the address");
                p.Address = Console.ReadLine();
                Console.WriteLine("What do you like to do buy/sell/rent");
                p.Purpose = Console.ReadLine();
                Console.WriteLine("Enter the price:");
                p.Price = Convert.ToInt32(Console.ReadLine());
                db.Add(p);
                db.SaveChanges();
                Console.WriteLine("property is successfully added");
            }
        }
        public static void deleteProperty()
        {
            using (var db = new igtContext())
            {
                Property p = new Property();
                Console.WriteLine("Enter the property id");
                string propid = Console.ReadLine();
                if (Guid.TryParse(propid, out Guid propertyId ))
                {
                    p.Propid = propertyId;
                    db.Properties.Remove(p);
                }
               else
                {
                    Console.WriteLine("Invalid property Id");
                }
               
                db.SaveChanges();
            }
        }
        public static void updateProperty()
        {
            using (var db = new igtContext())
            {
                Property p = new Property();
                Console.WriteLine("Enter the property id");
                string propid = Console.ReadLine();
                if (Guid.TryParse(propid, out Guid propertyId))
                {
                    p.Propid = propertyId;
                    Console.WriteLine("Enter the property name");
                    p.Propname = Console.ReadLine();
                    Console.WriteLine("Enter the address");
                    p.Address = Console.ReadLine();
                    Console.WriteLine("What do you like to do buy/sell/rent");
                    p.Purpose = Console.ReadLine();
                    Console.WriteLine("Enter the price:");
                    p.Price = Convert.ToInt32(Console.ReadLine());

                    db.Update(p);
                    db.SaveChanges();
                }

                else
                {
                    Console.WriteLine("Invalid property Id");
                }

               
            }
        }
        public static void selectProperty()
        {
            using (var db = new igtContext())
            {
                List<Property> propshop = db.Properties.ToList();
                foreach(Property p in propshop)
                {
                    Console.WriteLine("Property Id : {0} \n Property Name: {1} \n Address : {2} \n Purpose : {3}\n Price:{4}", p.Propid, p.Propname, p.Address, p.Purpose, p.Price);
                }

            }
        }


    }
}
