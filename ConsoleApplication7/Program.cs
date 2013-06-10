using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "HA";

            string suit = input1[0].ToString();
            string number = input1[1].ToString();

            switch (number)
            {
                case ("A"):
                    {
                        number = "1";
                        break;
                    }
                case ("J"):
                    {
                        number = "11";
                        break;
                    }
                case ("Q"):
                    {
                        number = "12";
                        break;
                    }
                case ("K"):
                    {
                        number = "13";
                        break;
                    }
            }

            switch (suit)
            {
                case ("H"):
                    {
                        suit = "S";
                        break;
                    }
                case ("C"):
                    {
                        suit = "D";
                        break;
                    }
                case ("D"):
                    {
                        suit = "C";
                        break;
                    }
                case ("S"):
                    {
                        suit = "H";
                        break;
                    }
            }

            number = (14 - int.Parse(number)).ToString();

            Console.WriteLine(suit + number);
        }
    }
}
