using System;

namespace TryCatch_ParseTryParseConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInt = "5";
            string sWrongIntFormat = "blablatextbutnotInteger";
            string sNull = null;
            string sOutOfRangInt = "56565656565656565666";

            int x;
           
            try
            {
                //---------------------Parse---------------1/4-
                //x = int.Parse(sInt);            OK
                //x = int.Parse(sWrongIntFormat);    //Error
                //x = int.Parse(sNull);             //Error
                //x = int.Parse(sOutOfRangInt);     //Error

                //---------------Convert.Int32()--------------2/4
                // x = Convert.ToInt32(sInt);       OK
                //x = Convert.ToInt32(sWrongIntFormat);  //Error
                //x = Convert.ToInt32(sNull);    //OK with default 0
                //x = Convert.ToInt32(sOutOfRangInt);   //Error
                //Console.WriteLine("\n\t x = " + x);

                //----------TryParse-----------------4/4
                bool CanBeConverted;
                //CanBeConverted = int.TryParse(sInt, out x);    OK
                // CanBeConverted = int.TryParse(sWrongIntFormat, out x);  //OK with default 0
                //CanBeConverted = int.TryParse(sNull, out x);   //OK with default 0
                CanBeConverted = int.TryParse(sOutOfRangInt, out x);  //OK with default 0 
                Console.WriteLine($"\n\t Can be Converted? {CanBeConverted}\t x = {x}" );
            }
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("\n\t error = " + fe);
            //}
            //catch (ArgumentNullException fe)
            //{
            //    Console.WriteLine("\n\t error = " + fe);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("\n\t error = " + ex);
            }
            finally
            {
                Console.WriteLine("\n\t Finally code always runs - ");
            }

            Console.ReadKey();
        }
    }
}
