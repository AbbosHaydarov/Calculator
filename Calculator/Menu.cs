using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Menu
    {
       public void ShowMenuu()
        {
            string message = "\n";

            message += "[1] - Plus\n\n";
            message += "[2] - Minus\n\n";
            message += "[3] - Multiply\n\n";
            message += "[4] - Divide\n\n";
            message += "[5] - Close\n\n";

            Console.WriteLine("# # # # # # KASR SONLAR USTIDA AMAL BAJARADIGAN KALKULYATOR # # # # # #");

            Console.WriteLine(message);
            Console.Write("Tanlovingiz: ");

            int.TryParse(Console.ReadLine(), out int tanlov);
            switch (tanlov)
            {
                case 1:
                    PlusUchun();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;
                
            }

        }

        public void PlusUchun()
        {
            Console.WriteLine("Birinchi sonning suratini kiriting: ");

            long surat;
            long.TryParse(Console.ReadLine(), out surat);

            Console.WriteLine("Birinchi sonning maxraj kiriting : ");

            long maxraj;
            long.TryParse(Console.ReadLine(), out maxraj);

            Kasr son1 = new Kasr(surat, maxraj);

            Console.WriteLine("Ikkinchi sonning suratini kiriting: ");

            long surat2;
            long.TryParse(Console.ReadLine(), out surat2);

            Console.WriteLine("Ikkinchi sonning maxraj kiriting : ");

            long maxraj2;
            long.TryParse(Console.ReadLine(), out maxraj2);

            Kasr son2 = new Kasr(surat2, maxraj2);

            
            // Console.WriteLine($"{surat}/{maxraj} + {surat2}/{maxraj2} = " + Kasr.Plus());
            Console.WriteLine($"test: {son1} + {son2} = {Kasr.Plus(son1, son2)}");
            //Kasr.Plus(son1, son2);
        }

    }
}
