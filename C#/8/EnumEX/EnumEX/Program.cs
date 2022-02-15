using System;

namespace EnumEX
{
    /*
     * 1- Enum is a set integers
     * 2- Human readable name are suger-coating over these integers
     * 3- int starts from 0 unless you explicitly, give another value
     */

    public enum Countries
    {
        Danmark = 45,  // default is 0
        Sverige,
        Norge ,
        Finland 
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int Country { get; set; }
        public Countries Country { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej!");
            Customer[] kunder = new Customer[7];
            //kunder[0] = new Customer() { Id = 1, Name = "Ole", Country = 1 };
            kunder[0] = new Customer() { Id = 1, Name = "Ole", Country = Countries.Danmark };
            kunder[1] = new Customer() { Id = 2, Name = "Kim", Country = Countries.Finland };
            kunder[2] = new Customer() { Id = 3, Name = "Ib", Country = Countries.Norge };
            kunder[3] = new Customer() { Id = 4, Name = "Ove", Country = Countries.Sverige };
            kunder[4] = new Customer() { Id = 5, Name = "Per", Country = Countries.Norge };
            kunder[5] = new Customer() { Id = 6, Name = "Mia", Country = Countries.Danmark };
            kunder[6] = new Customer() { Id = 7, Name = "Le", Country = Countries.Finland };

            foreach (Customer kunde in kunder)
            {
                Console.WriteLine($"\n\t Id = {kunde.Id}\t Name = {kunde.Name}\t Country = {kunde.Country}\t Enum-Integer = {(int)kunde.Country}");
                //Console.WriteLine($"\n\t Id = {kunde.Id}\t Name = {kunde.Name}\t Country = {GetCountryName(kunde.Country)}\t");
            }
            Countries NaboLand;
            Enum.TryParse("48", out NaboLand);
            Console.WriteLine("\n\t----------------------\n\t "+ NaboLand);
        }

        static string GetCountryName(int x)
        {
            switch (x)
            {
                case 4: return "Finland";
                case 3: return "Norge";
                case 2: return "Sverige";
                case 1: return "Danmark";
                default: return "Ukendt";
                   
            }
        }
    }
}
