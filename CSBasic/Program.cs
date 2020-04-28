using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "윤" + "인" + "성";
            Console.Write("Hello C#");
            //주석
            /*여러줄
             * 주석*/
            Console.WriteLine("Hello World");
            Console.Write("Hello world");
            Console.Write("Hello world");

            Console.Write(52);
            Console.Write(7 % 3);
            Console.Write('A');
            Console.Write("A");

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가" + "나" + "다");

            Console.WriteLine("안녕"[100]);

            Console.WriteLine(true);
        }
    }
}
