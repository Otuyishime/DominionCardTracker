using DominionCardTracker.IntegrationTests;
using DominionCardTracker.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            CardSetTests tests = new CardSetTests();
            tests.SelectAllTest();
        }
    }
}
