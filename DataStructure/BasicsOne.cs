using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BasicsOne
    {
        //链表
        //  线性单向   单向循环
        //  双向    双向循环


        public void test()
        {

            LinkedList<int> h = new LinkedList<int>();   //双向链表：新帆船下水
            h.AddFirst(2);                           //让一个兄弟坐到船首
            h.AddFirst(1);                          //船首：7进去休息吧，我来换班
            h.AddLast(3);                           //让一个兄弟做到船尾
            h.AddLast(4);                            //船尾：25进去休息吧，我来换班
                                                     //船首 船尾必须有一人值班：即我只能命令这两个值班位置上的人

            foreach (int a in h)                     //列队！！
            {
                Console.WriteLine(a + " ");                      //报数：62 7 25 8
            }
            LinkedListNode<int> cur = h.Find(3);   //62在吗？！ 
                                                    //依次敲门去找到62
            if (cur != null)                        //到！
            {
                h.AddBefore(cur, 0);                //53去他前面站着！
                h.AddAfter(cur, 9);                //21去他后面站着！
            }

            foreach (int a in h)                    //列队！
            {
                Console.WriteLine(a+ " ");                     //报数：53 62 21 7 25 8
            }
        }
    }
}
