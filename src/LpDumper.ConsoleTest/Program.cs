using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace LpDumper.ConsoleTest
{
    class Program
    {
        [STAThread] //marking it STAThread is important for Console app
        static void Main(string[] args)
        {
            DumpTest();
        }

        private static void DumpTest()
        {
            var personList = new List<Person> {
                new Person { Name = "person2", Amount =100}, new Person { Name = "person3", Amount = 200 },
                new Person { Name = "person2", Amount =100}, new Person { Name = "person3", Amount = 100 },
                new Person { Name = "person2", Amount =100}, new Person { Name = "person1", Amount = 100 }
            };

            var group = personList.ToLookup(x => x.Name);

            Debugger.Break();

            group.Dump();
            group.DumpFile();

            Debugger.Break();
            //Open immediate window and type `group.Dump();`
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}