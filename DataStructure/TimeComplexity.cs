using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class TimeComplexity
    {
        //通常情况下 一个顺序执行的过程  时间复杂度为  O(1)
        //          for循换                     O(n)
        //      双层for嵌套为                    O(n²)
        //       二分查找法为                    O(logn)
        //10万条的处理数据 双重for需要计算100亿次  而转换为for 只需要10万次  转换为二分法 只需要17次 以2位底计算


        //复杂度计算与长系数无关   O(n) 与 O(2n)  一样
        //复杂度相加 以高者为准  O(n²)+O(n)  与 o(n²)一样
        //O(1) 表示与计算个数无关
    }
}
