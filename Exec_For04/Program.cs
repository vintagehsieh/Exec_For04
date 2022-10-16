using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exec)For04
            //呈現1~20，若是3的倍數顯示foo，若是5的倍數顯示bar，
            //若是呈現15的倍數顯示foobar，其餘顯示數值


            //METHOD 1 利用for與if的巢套
            for (int i = 1; i <= 20; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("foobar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("bar");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();


            //METHOD 2: 使用三元運算
            for ( int i = 1; i <= 20; i++)
            {
                string result;
                result = (i % 15 == 0) ? "foobar" : (i % 3 == 0) ? "foo" : (i % 5 == 0) ? "bar" : i.ToString();
                Console.WriteLine(result);


			}
        }
    }
}
