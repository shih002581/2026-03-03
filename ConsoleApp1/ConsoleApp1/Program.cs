using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userlnput;
            Console.Write("請輸入第1個運算元=>");
            userlnput = Console.ReadLine() ?? "0";

            int x = Convert.ToInt32(userlnput);
            Console.Write("請輸入第2個運算元=>");
            userlnput = Console.ReadLine() ?? "0";

            int y = Convert.ToInt32(userlnput);
            Console.Write("請輸入索引值");
            userlnput = Console.ReadLine() ?? "0";

            int index = Convert.ToInt32(userlnput);

            try
            {
                Console.WriteLine("例外處理開始");

                string[] names = new string[5];
                string name = names[index];
                Console.WriteLine(":" + (x / y));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("程式錯誤:" + ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("程式錯誤:" + ex.ToString());
            }
            finally
            {
                Console.WriteLine("例外處理結束");
            }
            Console.Read();

        }
    }
}
