using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class characterString
    {
        //字符串
        //字符串的顺序存储结构，是用一组地址连续的存储单元来存储串中的字符序列，一般是用定长数组来实现。
        //字符串的链式存储结构，与线性表是相似的，但由于串结构的特殊性（结构中的每个元素数据都是一个字符），如果也简单地将每个链结点存储为一个字符，就会造成很大的空间浪费。因此，一个结点可以考虑存放多个字符，如果最后一个结点未被占满时，可以使用 "#" 或其他非串值字符补全
        //如果字符串中包含的数据量很大，但是可用的存储空间有限，那么就需要提高空间利用率，相应地减少结点数量。
        //而如果程序中需要大量地插入或者删除数据，如果每个节点包含的字符过多，操作字符就会变得很麻烦，为实现功能增加了障碍。因此，串的链式存储结构除了在连接串与串操作时有一定的方便之外，总的来说，不如顺序存储灵活，在性能方面也不如顺序存储结构好。
        //字符串和线性表的操作很相似，但由于字符串针对的是字符集，所有元素都是字符，因此字符串的基本操作与线性表有很大差别。线性表更关注的是单个元素的操作，比如增删查一个元素，而字符串中更多关注的是查找子串的位置、替换等操作。
        //
        //
        public void test()
        {
            string s = "goodgoogle";
            string t = "google";
            int isfind = 0;

            for (int i = 0; i < s.Length - t.Length + 1; i++)
            {
                if (s.Substring(i, 1) == t.Substring(0, 1))
                {
                    int jc = 0;
                    for (int j = 0; j < t.Length; j++)
                    {
                        if (s.Substring(i + j, 1) != t.Substring(j, 1))
                        {
                            break;
                        }
                        jc = j;
                    }
                    if (jc == t.Length - 1)
                    {
                        isfind = 1;
                    }
                }
            }
            Console.WriteLine(isfind);
        }
        public void test2()
        {
            string a = "blue is sky the";
            string b = "";
            string[] arrA = a.Split(" ");
            for (int i = arrA.Length - 1; i >= 0; i--)
            {
                string c = arrA[i];
                b+=arrA[i]+" ";
            }
            Console.WriteLine(b);

        }

      
    }
}
