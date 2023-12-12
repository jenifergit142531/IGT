using System.Xml;
using System.Xml.Schema;

class Program
{
    public static XmlElement CreateBookElement(XmlDocument xmldoc, string id, string title, string author,decimal price)
    {
        //create a book element
        XmlElement bookElement = xmldoc.CreateElement("Book");

        //create a id attribute

        XmlAttribute idAttribute = xmldoc.CreateAttribute("Id");
        idAttribute.Value = id;
        bookElement.Attributes.Append(idAttribute);

        //create title element

        XmlElement titleElement = xmldoc.CreateElement("Title");
        titleElement.InnerText = title;
        bookElement.AppendChild(titleElement);

        //create author element

        XmlElement authorElement = xmldoc.CreateElement("Author");
        authorElement.InnerText = author;
        bookElement.AppendChild(authorElement);

        //create price element

        XmlElement priceElement = xmldoc.CreateElement("Price");
        priceElement.InnerText = price.ToString();
        bookElement.AppendChild(priceElement);


        return bookElement;
    }

    public static void ValidateXmlFile()
    {
        try
        {

            //load xml document

            XmlDocument xmldoc = new XmlDocument();
             xmldoc.Load("../mybooks.xml");

            //load xml schema

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(null, "C:\\Users\\JeniferY\\Desktop\\iinterchange\\Console\\DbFIirst\\XMLDemo\\BookStore.xsd");

            //validate the xml document against the xml schema
            xmldoc.Schemas.Add(schemaSet);
            xmldoc.Validate(ValidationEventHandler);

            Console.WriteLine("XML is valid");
        }
        catch(XmlSchemaValidationException ex)
        {
            Console.WriteLine($"validation error :{ex.Message}");
        }

        catch(Exception ex)
        {
            Console.WriteLine($"error : {ex.Message}");
        }
    }

    static void ValidationEventHandler(object sender,ValidationEventArgs e)
    {
        Console.WriteLine($"Error : {e.Message}");
    }

    public static void ReadXml()
    {
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load("../mybooks.xml");

        //select all the book nodes
        XmlNodeList bookNodes = xmldoc.SelectNodes("/BookStore/Book");

        //display book information

        foreach(XmlNode bookNode in bookNodes)
        {
            string id = bookNode.Attributes["Id"].Value;
            string title = bookNode.SelectSingleNode("Title").InnerText;
            string author = bookNode.SelectSingleNode("Author").InnerText;
            string price = bookNode.SelectSingleNode("Price").InnerText;

            Console.WriteLine("Book Id =>" + id);
            Console.WriteLine("Title =>" + title);
            Console.WriteLine("Author =>" + author);
            Console.WriteLine("Price =>" + price);

        }
    }


    public static void createXmlFile()
    {
        //create xml document
        XmlDocument xmldoc = new XmlDocument();


        //create xml declation

        XmlDeclaration xmldeclaration = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        xmldoc.AppendChild(xmldeclaration);

        //create a root element
        XmlElement rootElement = xmldoc.CreateElement("BookStore");
        xmldoc.AppendChild(rootElement);

        //create book element 

        XmlElement bookElement1 = CreateBookElement(xmldoc, "100", "Ikigai", "paul", 150);
        XmlElement bookElement2 = CreateBookElement(xmldoc, "200", "Inferno", "dan brown", 29);



        //append the book elements to book store / root element

        rootElement.AppendChild(bookElement1);
        rootElement.AppendChild(bookElement2);

        xmldoc.Save("../mybooks.xml");

        Console.WriteLine("Xml document is created successfully");
    }
    public static void Main(string[] args)
    {


        createXmlFile();

        //ReadXml();

        ValidateXmlFile();


    }
}


//C: \Users\JeniferY\Desktop\iinterchange\Console\DbFIirst\XMLDemo\mybooks.xml




