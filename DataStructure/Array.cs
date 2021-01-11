using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Array
    {
        //数组  将相同类型的元素 以不规则顺序排列  
        // 不同于栈和队列有限值只能在特定位置进行操作  数组可以在任意位置进行
        //数组与链表
        //   链表长度是可变的 数组是固定的
        //   链表不会根据有序位置存储
        //   链表的插入删除元素相对数组较为简单，不需要移动元素，且较为容易实现长度扩充，但是寻找某个元素较为困难；
        //
        //
        public void test()
        {
            int[] a = { 2,1,4,5,3};
            int max_inx = -1,max_val = -1;
            int min_inx = -1,min_val = 99;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max_val)
                {
                    max_val = a[i];
                    max_inx = i;
                }
                if (a[i] < min_val)
                {
                    min_val = a[i];
                    min_inx = i;
                }
            }
            int inx1 = max_inx;
            int inx2 = min_inx;
            if (max_inx < min_inx)
            {
                inx1 = min_inx;
                inx2 = max_inx;
            }
            for (int  i = inx1;  i< a.Length -1;  i++)
            {
                a[i] = a[i+1];
            }
            for (int i = inx2;i< a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            int score = 0;
            for (int i = 0; i < a.Length-2; i++)
            {
                score += a[i];
            }
            Console.WriteLine(score/3);
        }
    }
}
