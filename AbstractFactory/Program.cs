using AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Abstract Factory---
            Console.WriteLine("---Abstract Factory---");
            IQueryFactory goodQueryFactory = new GoodFactory();
            DbQuery goodQuery = new DbQuery(goodQueryFactory, new Good { Name = "Krakowska sucha" });
            Console.WriteLine(goodQuery.GetInsert());
            Console.WriteLine(goodQuery.GetSelect());

            IQueryFactory contractorQueryFactory = new ContractorFactory();
            DbQuery contractorQuery = new DbQuery(contractorQueryFactory, new Contractor { Name = "Atlas" });
            Console.WriteLine(contractorQuery.GetInsert());
            Console.WriteLine(contractorQuery.GetSelect());

            //---Simple Factory---
            Console.WriteLine("\n\n---Simple Factory---");
            DbQuery goodQuerySimple = new DbQuery(new Good { Name = "Mielonka" });
            Console.WriteLine(goodQuerySimple.GetInsert());
            Console.WriteLine(goodQuerySimple.GetSelect());
            goodQuerySimple = new DbQuery(new Contractor { Name = "Sonny" });
            Console.WriteLine(goodQuerySimple.GetInsert());
            Console.WriteLine(goodQuerySimple.GetSelect());



            Console.ReadKey();
        }
    }
}
