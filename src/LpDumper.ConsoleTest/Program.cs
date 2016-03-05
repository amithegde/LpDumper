using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace LpDumper.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DumpTest();
        }

        private static void DumpTest()
        {
            //dump chaining
            var personList = new List<Person> {
                new Person { Name = "person2", Amount =100}, new Person { Name = "person3", Amount = 200 },
                new Person { Name = "person2", Amount =100}, new Person { Name = "person3", Amount = 100 },
                new Person { Name = "person2", Amount =100}, new Person { Name = "person1", Amount = 100 }
            }.Dump().ToLookup(x => x.Name).Dump("Lookup");

            Debugger.Break();
            //Open immediate window and type `personList.Dump();`
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}