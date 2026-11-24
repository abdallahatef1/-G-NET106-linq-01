using System;
using System.Linq;
namespace linqassignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 
            //var q1 = Source.ProductList.Where(p => p.Category == "Seafood");
            //foreach (var p in q1)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion

            #region q2
            //var q2 = Source.ProductList.Select(p => p.ProductName);
            //foreach (var name in q2)
            //    Console.WriteLine(name);

            #endregion

            #region q3
            //var q3 =Source.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var p in q3)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion

            #region q4
            //var q4 = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in q4)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion

            #region q5
            //var q5 =Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");
            //foreach (var p in q5)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            #endregion

            #region q6
            //var q6 = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //foreach (var item in q6)
            //    Console.WriteLine($"{item.Name} | {item.Price} | {item.StockStatus}");
            #endregion

            #region 7
            //var q7 = Source.ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            //foreach (var line in q7)
            //    Console.WriteLine(line);
            #endregion


        }
    }
}
