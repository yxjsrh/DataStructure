using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class recursion
    {
        //递归 汉诺塔问题
        public void test()
        {
            String x = "x";
            String y = "y";
            String z = "z";
            hanio(3, x, y, z);
        }
        //可以拆分为3部  
        //1.将n-1个盘子移动到y 
        //2.将最大的盘子移动到z
        //3.将n-1个盘子移动到z
        public void hanio(int n, String x, String y, String z)
        {
            if (n < 1)
            {
                Console.WriteLine("汉诺塔的层数不能小于1");
            }
            else if (n == 1)
            {
                Console.WriteLine("移动: " + x + " -> " + z);
                return;
            }
            else
            {
                hanio(n - 1, x, z, y);
                Console.WriteLine("移动: " + x + " -> " + z);
                hanio(n - 1, y, x, z);
            }
        }
    }
}
