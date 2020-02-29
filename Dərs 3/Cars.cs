using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dərs_2
{
    class Cars
    {
        public string Marka;
        public string Model;
        public int FullPower;
        public double FullKm;
        public double CurrentFuel;
        public double LocalKm;
        public double GlobalKm;
       
        public Cars(string Marka, string Model, int FullPower, double FullKm, double CurrentFuel=0)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.FullKm = FullKm;
            this.FullPower = FullPower;
            this.CurrentFuel = CurrentFuel;
        }

        public void Go()
        {
           
            double neededKm = 0;

            while (neededKm == 0)
            {
                Console.WriteLine("Nece km yol getmek isteyirsiniz?");
                string userInput = Console.ReadLine();
                if (IsEmpty(userInput))
                {
                    neededKm = Convert.ToDouble(userInput);
                    if (CurrentFuel >= (neededKm / 100) * FullKm)
                    {
                        CurrentFuel -= (neededKm / 100) * FullKm;
                        Console.WriteLine($"Siz {neededKm} qeder yol getdiniz. {CurrentFuel} litr benzininiz qaldi.");
                        GlobalKm += neededKm;
                        LocalKm += neededKm;
                    }
                    else
                    {
                        Console.WriteLine("Sizin masinda kifayet qeder benzin yoxdu :P . Zehmet olmasa benzi doldurun >:(");
                    }
                }
            }

        }
        
        public void TopUp()
        {

            Console.WriteLine("Nece litr benzin doldurmaq isteyirsiniz?");
            double neededpower = 0;
            string inp = Console.ReadLine();

            while (neededpower == 0)
            {
                if (IsEmpty(inp))
                {
                neededpower = Convert.ToDouble(inp);
                    if(CurrentFuel+neededpower<=FullPower)
                    {
                        CurrentFuel += neededpower;
                        Console.WriteLine($"Benzin ugurla dolduruldu sizin {CurrentFuel}  benzininiz var");
                    }else
                    {
                        Console.WriteLine("Sizin max benzininiz var");
                    }

                   
                  
                }
            }

        }

        public void Stop()
        {
            LocalKm = 0;
            Console.WriteLine($"Local km sifirlandi km: {GlobalKm}");
        }

        public void Lckm()
        {
            Console.WriteLine($"Global km: {GlobalKm}. Local km: {LocalKm}");
        }
        bool IsEmpty(string inp)
        {
            try
            {
                Convert.ToDouble(inp);
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
