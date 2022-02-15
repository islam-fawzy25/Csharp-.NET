using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {11,33,45,65,78,98,87,65,44,32,42,52,65,76,87,98,76,65,45,34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34 , 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34 , 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65 };

            IEnumerable<int> QueryResult = from x in A
                                             where x > 50
                                             orderby x descending
                                                select x;
            foreach (var item in QueryResult)
            {
                Console.WriteLine("\n\t" +item);
            }

            List<int> lst=new List<int> {11, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65, 44, 32, 42, 52, 65, 76, 87, 98, 76, 65, 45, 34, 33, 45, 65, 78, 98, 87, 65 };

            IEnumerable<int> OneValue =     from x in lst
                                            where x == 11
                                            select x;

            int OnlyOneValue = (from x in lst
                                where x == 11
                                select x).First();
            //------------------------XML--------------------------
            XElement empXMLFile = XElement.Load("employees.xml");
            var QryResult = from emp in empXMLFile.Descendants("Employee")
                            orderby emp.Element("FirstName").Value
                            select emp;
            foreach (var m in QryResult)
            {
                //Console.WriteLine("\n" + m);
                Console.WriteLine($"\n\t Employee {m.Element("FirstName").Value} " +
                    $"{m.Element("LastName").Value} works in {m.Element("Department").Value}" +
                    $" and lives in {m.Element("Location").Value}");
            }
        }
    }
}
