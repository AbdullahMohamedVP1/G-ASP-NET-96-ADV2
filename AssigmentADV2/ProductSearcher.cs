// ProductSearcher.cs
using System;
using System.Collections.Generic;

namespace AssigmentADV2
{
    public static class ProductSearcher{
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> predicate){
            var result = new List<Product>();
            foreach (var product in products){
                if (predicate(product)){
                    result.Add(product);
                }
            }
            return result;
        }

        public static void PrintProducts(List<Product> products){
            foreach (var p in products){
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }
        }
    }
}