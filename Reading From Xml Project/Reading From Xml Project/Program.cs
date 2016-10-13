using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reading_From_Xml_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> myPlant = new List<Plant>();

                XmlDocument plantDoc = new XmlDocument();
                plantDoc.Load("C:\\Users\\iykef\\Downloads\\plant_catalog.xml");
                XmlNode myCategoryNode = plantDoc.DocumentElement.SelectSingleNode("/CATALOG");

                foreach (XmlNode subCategory in myCategoryNode.ChildNodes)
                {
                    Plant myPlant1 = new Plant();

                        foreach (XmlNode subSubCategory in subCategory.ChildNodes)

                        {

                            switch (subSubCategory.Name)

                            {

                                case "COMMON":

                                    {

                                        myPlant1.Common = subSubCategory.InnerText;

                                        break;

                                    }

                                case "BOTANICAL":

                                    {

                                        myPlant1.Botanical = subSubCategory.InnerText;

                                        break;

                                    }

                                case "DESCRIPTION":

                                    {

                                        myPlant1.Description = subSubCategory.InnerText;

                                        break;

                                    }

                                case "LIGHT":

                                    {

                                        myPlant1.Light = subSubCategory.InnerText;

                                        break;

                                    }

                                case "ZONE":

                                    {

                                        myPlant1.Zone = subSubCategory.InnerText;

                                        break;

                                    }

                                case "PRICE":

                                    {

                                        myPlant1.Price = subSubCategory.InnerText;

                                        break;

                                    }

                                case "AVAILABILITY":

                                    {

                                        myPlant1.Availability = subSubCategory.InnerText;

                                        break;

                                    }

                                default:

                                    {

                                        break;


                                    }
                            }
                        }
                        myPlant.Add(myPlant1);
                    }

                    foreach (Plant p in myPlant)

                    {
                        Console.Title = ("Plant Inventory v1");
                        Console.WriteLine("\n");
                        Console.WriteLine(string.Format("Common Name: {0}", p.Common));
                        Console.WriteLine(string.Format("Botanical Name: {0}", p.Botanical));
                        Console.WriteLine(string.Format("Description: {0}", p.Description));
                        Console.WriteLine(string.Format("Light: {0}", p.Light));
                        Console.WriteLine(string.Format("Zone: {0}", p.Zone));
                        Console.WriteLine(string.Format("Price: {0}", p.Price));
                        Console.WriteLine(string.Format("Availability: {0}", p.Availability));
                        Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
