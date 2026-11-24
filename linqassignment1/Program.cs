using System;
using System.Linq;
namespace linqassignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 
            var q1 = Source.ProductList.Where(p => p.Category == "Seafood");
            foreach (var p in q1)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion
            
        }
    }
}
