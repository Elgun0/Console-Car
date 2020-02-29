using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dərs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars("BMW", "M5", 80, 15, 50);
            Cars mer = new Cars("Mercedes", "E350", 80, 15);
            string input;
            do
            {
                Console.WriteLine(">>>>>>>>>> Please write only button number <<<<<<<<<<");

                Console.WriteLine("1. Go");
                Console.WriteLine("2. Top up");
                Console.WriteLine("3. Stop");
                Console.WriteLine("4. Local km and Global km");
                Console.WriteLine("5. Exit");

                Console.WriteLine(">>>>>>>>>> AzPetrol | Azpetrol yaxsi yol :) <<<<<<<<<<");

                input = Console.ReadLine();


               

                if (IsEmpty(input))
                {
                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            car.Go();

                            break;
                        case "2":
                            Console.Clear();
                            car.TopUp();

                            break;
                        case "3":
                            Console.Clear();
                            car.Stop();
                            Console.WriteLine("Dayandiniz");
                            break;
                        case "4":
                            Console.Clear();
                            car.Lckm();  
                            Console.WriteLine("Total");
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Tesekkurler");
                            break;



                        default:
                            break;
                    }
                }

            } while (input!="5");
        }
        
        static bool IsEmpty(string inp)
        {
            try
            {
                Convert.ToInt32(inp);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Please write number in the menu");
                return false;
            }
        }
    }

}
