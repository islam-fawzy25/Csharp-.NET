using System;

namespace StructVsClass
{
    class ClassCustomer
    {
        int id;
        string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public ClassCustomer()
        {
           // Console.WriteLine("\n\t parameterless constructor");
        }

        public ClassCustomer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void ClassInfo()
        {
            Console.WriteLine($"\n\t Info from inside the class --> Id = {this.id}\t Name  = {this.name}");
        }
    }

    struct StructCustomer
    {
        int id;
        string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        //public StructCustomer()
        //{
        //    Console.WriteLine("\n\t parameterless constructor");
        //}

        public StructCustomer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void StructInfo()
        {
            Console.WriteLine($"\n\t Info from inside the Struct --> Id = {this.id}\t Name  = {this.name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t---------------------Class------------------------------------------\n");
            ClassCustomer cc = new ClassCustomer();
            cc.Id = 1; cc.Name = "Mark";
            cc.ClassInfo();
            ModifyClassInfo(cc);
            cc.ClassInfo();

            Console.WriteLine("\n\t---------------------Struct--------------------------------------------\n");
            StructCustomer sc = new StructCustomer();
            sc.Id = 2; sc.Name = "Søren";
            sc.StructInfo();
            ModifyStructInfo(sc);
            sc.StructInfo();

            Console.ReadKey();
        }

        private static void ModifyStructInfo(StructCustomer sc)
        {
            sc.Id = 2222; sc.Name = "New Name Ib Ibsen";
            Console.WriteLine($"\n\t Info from inside ModifyMethod --> Id = {sc.Id}\t Name  = {sc.Name}");
        }

        private static void ModifyClassInfo(ClassCustomer cc)
        {
            cc.Id = 1111; cc.Name = "New Name Ole Olsen";
            Console.WriteLine($"\n\t Info from inside ModifyMethod --> Id = {cc.Id}\t Name  = {cc.Name}");
        }
    }
}
