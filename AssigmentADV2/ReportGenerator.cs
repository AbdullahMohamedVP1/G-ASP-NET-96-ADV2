// ReportGenerator.cs
using System;
using System.Collections.Generic;

namespace AssigmentADV2
{
    public static class ReportGenerator{
        public static void PrintReport(List<Product> products, Action<Product> action){
            foreach (var p in products){
                action(p);
            }
        }
        public static List<TResult> TransformProducts<TResult>(List<Product> products, Func<Product, TResult> transformer){
            var result = new List<TResult>();
            foreach (var p in products){
                result.Add(transformer(p));
            }
            return result;
        }
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
        {
            var result = new List<Product>();
            foreach (var p in products){
                if (predicate(p)){
                    result.Add(p);
                }
            }
            return result;
        }
    }
}