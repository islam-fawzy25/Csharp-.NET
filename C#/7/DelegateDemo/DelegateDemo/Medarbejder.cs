using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Medarbejder
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Erfaring { get; set; }
        public double Løn { get; set; }

        //public static void LønForHøjelse(List<Medarbejder> MaList)  // 1
        public static void LønForHøjelse(List<Medarbejder> MaList, LønforhøjelseDelegate dele)
        {
            foreach (Medarbejder m in MaList)
            {
                //if (m.Erfaring >5)
                //if (m.Løn < 25000)
                //{
                //    Console.WriteLine($"\n\t {m.Navn}'s gammel løn = {m.Løn}");
                //    m.Løn += 2000;
                //    Console.WriteLine($"\n\t {m.Navn}'s løn fra nu af = {m.Løn}");
                //}
                //-------------------------------
                if (dele(m))
                {
                    Console.WriteLine($"\n\t {m.Navn}'s gammel løn = {m.Løn}");
                    m.Løn += 2000;
                    Console.WriteLine($"\n\t {m.Navn}'s løn fra nu af = {m.Løn}");
                }
            }
        }
    }
}
