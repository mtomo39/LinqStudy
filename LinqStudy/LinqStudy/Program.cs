using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 84, 95, 95, 40, 6 };

            //foreach (var x in list)
            //{
            //    Debug.WriteLine(x);
            //}

            // 偶数を取り出す (Where と FindAll は一緒）
            var findAllList = list.FindAll(x => x % 2 == 0);
            Debug.WriteLine("=== findAllList ===");
            foreach(var x in findAllList)
            {
                Debug.WriteLine(x);
            }

            //　3倍にする (Select と ConvertAll は一緒）
            var convertAllIst = list.ConvertAll(x => x * 3);
            Debug.WriteLine("=== convertAllIst ===");
            foreach(var x in convertAllIst)
            {
                Debug.WriteLine(x);
            }

            // 最初の要素
            Debug.WriteLine($"First: {list.First()}");

            // 最後の要素
            Debug.WriteLine($"Last: {list.Last()}");

            // Maxの要素
            Debug.WriteLine($"Max: {list.Max()}");

            // Minの要素
            Debug.WriteLine($"Min: {list.Min()}");

            // 平均
            Debug.WriteLine($"Average: {list.Average()}");

            // 合計
            Debug.WriteLine($"Sum: {list.Sum()}");

            // 要素数
            Debug.WriteLine($"Count: {list.Count()}");

            // 配列に変換
            int[] array = list.ToArray();
            Debug.WriteLine("=== array ===");
            foreach(var x in array)
            {
                Debug.WriteLine(x);
            }

            var objectList = list.Cast<object>().ToList();
            Debug.WriteLine("=== objectList ===");
            foreach(var x in objectList)
            {
                Debug.WriteLine(x);
            }

            // 重複を除去して取得
            var distinctList = list.Distinct();
            Debug.WriteLine("=== distinctList ===");
            foreach(var x in distinctList)
            {
                Debug.WriteLine(x);
            }

            // 先頭から指定数をスキップして残りを取得
            var skipList = list.Skip(3);
            Debug.WriteLine("=== skipList ===");
            foreach(var x in skipList)
            {
                Debug.WriteLine(x);
            }

            // 先頭から指定数の要素を取得する
            var takeList = list.Take(3);
            Debug.WriteLine("=== takeList ===");
            foreach(var x in takeList)
            {
                Debug.WriteLine(x);
            }

            // 判定： すべての要素が 100未満 かどうか
            Debug.WriteLine($"All: {list.All(x => x < 100)}");

            // 判定： いずれかの要素が 0未満 かどうか
            Debug.WriteLine($"Any: {list.Any(x => x < 0)}");

            // 判定： 40 に一致する要素が含まれているか
            Debug.WriteLine($"Contains: {list.Contains(40)}");

            var list1 = new List<int> { 1, 84, 95, 95, 40, 6 };
            var list2 = new List<int> { 1, 16, 39, 33, 7, 84 };

            // 和集合
            var unionList = list1.Union(list2);
            Debug.WriteLine("=== unionList ===");
            foreach(var x in unionList)
            {
                Debug.WriteLine(x);
            }

            // 差集合
            var exceptList = list1.Except(list2);
            Debug.WriteLine("=== exceptList ===");
            foreach(var x in exceptList)
            {
                Debug.WriteLine(x);
            }

            // 積集合
            var intersectList = list1.Intersect(list2);
            Debug.WriteLine("=== intersectList ===");
            foreach(var x in intersectList)
            {
                Debug.WriteLine(x);
            }


            var fruitList = new[]
            {
                new {name = "りんご", Price = 300, size = 10},
                new {name = "ばなな", Price = 200, size = 20},
                new {name = "パイナップル", Price = 1000, size = 30},
                new {name = "いちご", Price = 500, size = 40},
                new {name = "みかん", Price = 300, size = 9},
            };

            //foreach (var fruit in fruitList)
            //{
            //    Debug.WriteLine(fruit);
            //}

            // ソート：　Price 昇順
            var orderByList = fruitList.OrderBy(x => x.Price).ThenBy(x => x.size);
            Debug.WriteLine("=== orderByList ===");
            foreach(var x in orderByList)
            {
                Debug.WriteLine(x);
            }

            // ソート：　Price 降順
            var orderByDescendingList = fruitList.OrderByDescending(x => x.Price).ThenByDescending(x => x.size);
            Debug.WriteLine("=== orderByDescendingList ===");
            foreach(var x in orderByDescendingList)
            {
                Debug.WriteLine(x);
            }

            // ソート：　逆順
            var reverseList = fruitList.Reverse();
            Debug.WriteLine("=== reverseList ===");
            foreach(var x in reverseList)
            {
                Debug.WriteLine(x);
            }

            var list3 = new List<int> { 1, 84, 95, 95, 40, 6 };

            // 組み合わせ
            var resultList1 = list3
                                .Distinct()         // 重複除去
                                .Skip(2)            // スキップ
                                .OrderBy(x => x);   // ソート
            Debug.WriteLine("=== resultList1 ===");
            foreach(var x in resultList1)
            {
                Debug.WriteLine(x);
            }

            // 組み合わせ
            var resultList2 = list3
                                .FindAll(x => x % 2 == 0)       // 偶数取り出し
                                .OrderBy(x => x)                // ソート
                                .ToList()                       // ConvertAll のため List に変換
                                .ConvertAll(x => x * 3);
            Debug.WriteLine("=== resultList2 ===");
            foreach(var x in resultList2)
            {
                Debug.WriteLine(x);
            }


            // FindAll を Where、ConvertAll を Select に書き換える　 ToList() がいらない
            var resultList3 = list3
                                .Where(x => x % 2 == 0)
                                .OrderBy(x => x)
                                .Select(x => x * 3);
            Debug.WriteLine("=== resultList3 ===");
            foreach(var x in resultList3)
            {
                Debug.WriteLine(x);
            }



        }
    }
}
