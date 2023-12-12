using System.Xml;

class Program
{
    public static XmlElement CreateBookElement(XmlDocument xmldoc, string id, string title, string author)
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

        return bookElement;
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

            Console.WriteLine("Book Id =>" + id);
            Console.WriteLine("Title =>" + title);
            Console.WriteLine("Author =>" + author);
        }
    }

    public static void Main(string[] args)
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

        XmlElement bookElement1 = CreateBookElement(xmldoc, "100", "Ikigai", "paul");
        XmlElement bookElement2 = CreateBookElement(xmldoc, "200", "Inferno", "dan brown");

        //append the book elements to book store / root element

        rootElement.AppendChild(bookElement1);
        rootElement.AppendChild(bookElement2);

        xmldoc.Save("../mybooks.xml");

        Console.WriteLine("Xml document is created successfully");


        ReadXml();


    }
}


//C: \Users\JeniferY\Desktop\iinterchange\Console\DbFIirst\XMLDemo\mybooks.xml




