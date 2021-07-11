using System;

namespace Variables_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = 5;
            int SecondNum = 10;

            int anyvalue = FirstNum;
            FirstNum = SecondNum;
            SecondNum = anyvalue;
        }
    }
}
