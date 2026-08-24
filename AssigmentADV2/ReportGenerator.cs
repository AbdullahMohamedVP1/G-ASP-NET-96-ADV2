// ReportGenerator.cs
using System;
using System.Collections.Generic;

namespace AssigmentADV2
{
    public static class ReportGenerator{
        // Action<Product>: بتنفذ عملية على كل منتج (زي الطباعة) من غير ما ترجع أي قيمة
        public static void PrintReport(List<Product> products, Action<Product> action){
            foreach (var p in products){
                action(p);
            }
        }
        // Func<Product, TResult>: بتحول كل منتج لقيمة تانية (string أو أي نوع) وترجعها
        public static List<TResult> TransformProducts<TResult>(List<Product> products, Func<Product, TResult> transformer){
            var result = new List<TResult>();
            foreach (var p in products){
                result.Add(transformer(p));
            }
            return result;
        } // Predicate<Product>: بترجع true/false للفلترة، بترجع بس المنتجات اللي بتحقق الشرط
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