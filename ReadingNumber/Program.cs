using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(readNumber(4978));
            Console.ReadLine();
        }

        private static string readNumber(int v)
        {
            string result = "";

            if (v > 0 && v < 9999)
            {
                switch (v/1000)
                {
                    case 1:
                        result += "one thousand ";
                        break;
                    case 2:
                        result +="two thousand ";
                        break;
                    case 3:
                        result +="three thousand ";
                        break;
                    case 4:
                        result +="four thousand ";
                        break;
                    case 5:
                        result +="five thousand ";
                        break;
                    case 6:
                        result +="six thousand ";
                        break;
                    case 7:
                        result +="seven thousand ";
                        break;
                    case 8:
                        result +="eight thousand ";
                        break;
                    case 9:
                        result +="nine thousand ";
                        break;
                    default:
                        break;
                }

                switch (v / 100 % 10)
                {
                    case 1:
                        result +="one hundred ";
                        break;
                    case 2:
                        result +="two hundred ";
                        break;
                    case 3:
                        result +="three hundred ";
                        break;
                    case 4:
                        result +="four hundred ";
                        break;
                    case 5:
                        result +="five hundred ";
                        break;
                    case 6:
                        result +="si xhundred ";
                        break;
                    case 7:
                        result +="seven hundred ";
                        break;
                    case 8:
                        result +="eight hundred ";
                        break;
                    case 9:
                        result +="nine hundred ";
                        break;
                    default:
                        break;
                }

                switch (v / 10 % 10)
                {
                    case 1:
                        switch (v % 100)
                        {
                            case 10:
                                result += "ten";
                                break;
                            case 11:
                                result += "eleven";
                                break;
                            case 12:
                                result += "twelve";
                                break;
                            case 13:
                                result += "thirteen";
                                break;
                            case 14:
                                result += "fourteen";
                                break;
                            case 15:
                                result += "fifteen";
                                break;
                            case 16:
                                result += "sixteen";
                                break;
                            case 17:
                                result += "seventeen";
                                break;
                            case 18:
                                result += "eightteen";
                                break;
                            case 19:
                                result += "nineteen";
                                break;
                        }
                        return v + " : " + result;
                    case 2:
                        result +="twenty ";
                        break;
                    case 3:
                        result +="thirty ";
                        break;
                    case 4:
                        result +="forty ";
                        break;
                    case 5:
                        result +="fifty ";
                        break;
                    case 6:
                        result +="sixty ";
                        break;
                    case 7:
                        result +="seventy ";
                        break;
                    case 8:
                        result +="eighty ";
                        break;
                    case 9:
                        result +="ninety ";
                        break;
                    default:
                        break;
                }

                switch (v % 10)
                {
                    case 1:
                        result +="one";
                        break;
                    case 2:
                        result +="two";
                        break;
                    case 3:
                        result +="three";
                        break;
                    case 4:
                        result +="four";
                        break;
                    case 5:
                        result +="five";
                        break;
                    case 6:
                        result +="six";
                        break;
                    case 7:
                        result +="seven";
                        break;
                    case 8:
                        result +="eight";
                        break;
                    case 9:
                        result +="nine";
                        break;
                    default:
                        break;
                }
            }

            return v + " : " + result;
        }
    }
}
