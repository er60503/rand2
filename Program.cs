using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int j = 0; j < 10; j++)
            {

                //將號碼放入List
                List<int> numbers = new List<int>();

                for (int i = 1; i <= 42; i++)
                {
                    numbers.Add(i);
                }

                Random rand = new Random();
                //重複2.3六次
                for (int i = 0; i < 6; i++)
                {
                    //隨機挑選一個印出
                    int r = rand.Next(1, numbers.Count);
                    Console.Write(numbers[r] + " ");

                    //並從List中刪除
                    numbers.RemoveAt(r);
                    

                }
            }
            
            Console.ReadKey();

        }
    }
}
