using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class SpatialComplexity
    {
        //空间复杂度
        //查找数组中出现最多的元素  
        //暴力解法 需要两个for  这里转换成词典的方式  降低时间复杂度
        public void test1()
        {
            int[] a = { 1, 2, 3, 4, 5, 5, 6, 6, 6 };
            Dictionary<int, int> temp = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (temp.ContainsKey(a[i]))
                {
                    temp[a[i]]++;
                }
                else
                {
                    temp[a[i]] = 1;
                }
            }
            int max = -1;
            int maxind = 0;
            foreach (var item in temp)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    maxind = item.Key;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(maxind);
            Console.ReadKey();
        }
    }
}
