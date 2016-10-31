using DominionCardTracker.DataLayer.Repositories;
using System;

namespace testMain
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            CardSetRepository repo = new CardSetRepository();
            Console.WriteLine("Size: ", repo.SelectAll().Count);
        }
    }
}
