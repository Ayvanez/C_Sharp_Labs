using System;
using System.Collections.Generic;
using упражнение_1;
namespace MyClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));
            Book b1 = new Book("Пушкин А.С.", "Капитанская дочка", publ, 123, 2018, 102, true);
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри", publ, 76, 2001, 103, true);
            Audit.RunAudit();
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Subs();
            Audit.StopAudit();
            Magazine mag2 = new Magazine("Наука и техника", 10, "Пороховое оружие", 2011, 1111, true);
            mag2.Subs();
            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, mag1, mag2 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itlist)
            {
                x.Print();
            }
            b2.TakeItem();
            b2.Print();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b2.PriceBook(3));
            mag1.TakeItem();
            mag1.Subs();
            mag1.Print();
            Console.WriteLine("\n Тестирование полиморфизма");
            b2.ReturnSrok();
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Print();
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Print();
        }
    }
}