using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DateFormXml.configuration.AppConfiguration;
namespace DateFormXml.Service
{
    internal static class DateService
    {
        public static void CreateXml()
        {
            if (!File.Exists(DatePath))
            {
                XDocument document = XDocument.Parse(@"<Queries></Queries>");
                document.Save(DatePath);
            }
        }


        public static void AddDate(string dayOfWeek, int dayOfMonth,string month, string year, string result)
        {
            XDocument document = XDocument.Load(DatePath);
            XElement? dateElement = document.Descendants("Queries")
                .FirstOrDefault();
            if(dateElement == null)
            {
                return;
            }
            XElement query = new(
                "Query",
                new XElement("Day", dayOfWeek),
                new XElement("DayMonth", dayOfMonth),
                new XElement("Month", month),
                new XElement("Year", year),
                new XElement("Result", result)
                );
            dateElement?.Add(query);

            document.Save(DatePath);

        }


    }
}
