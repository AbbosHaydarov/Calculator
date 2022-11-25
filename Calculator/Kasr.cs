using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Kasr
    {

        #region kasr sonning surat va maxraji uchun o'zgaruvchilar yaratdik
        public long  surat;
        public long maxraj;
        #endregion

        #region kasr sonlar uchunn propertylar yaratdik
        public long Surat
        {
            get
            {
                return surat;
            } 
                }
        public long Maxraj 
        {
            get
            {
                return maxraj;
            }
        }
        #endregion

        public Kasr(long surat, long maxraj)
        {
            this.surat = surat;
            this.maxraj = maxraj;
        }

        public override string ToString()
        {
            return surat + "/" + maxraj;
        }

        #region EKUB va EKUK ni topish
        public static long EKUB(long a, long b)
        {
            long Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }

        public static long EKUK(long a, long b)
        {
            long num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }
        #endregion


        public static long KasrQisqartirish(long surat, long maxraj)
        {
            if (surat == maxraj)
                return 1;
            else
                return EKUB(surat, maxraj);
        }

        public static long UmumiyMaxraj(Kasr son1, Kasr son2)
        {
            long result = 0;

            if (son1.maxraj == son2.maxraj)
                return son1.maxraj;

            else if (son1.maxraj != son2.maxraj)
            {
                son1.surat = son1.surat * (EKUK(son1.maxraj, son2.maxraj) / son1.maxraj);
                son2.surat = son2.surat * (EKUK(son1.maxraj, son2.maxraj) / son2.maxraj);
                // to do
                return EKUK(son1.maxraj, son2.maxraj);
            }

            else if (son1.maxraj == 0)
                return 0;

            else if (son2.maxraj == 0)
                return 0;

            else // yo'lini topsak shu qatordi yuqotamiz
                return result;
 
        }
                    
        public static long Plus(Kasr son1, Kasr son2)
        {
           
            UmumiyMaxraj(son1, son2);
            son1.surat =  son1.surat + son2.surat;

            return KasrQisqartirish(son1.surat, UmumiyMaxraj(son1, son2));
        }

        public static long Minus(Kasr son1, Kasr son2)
        { 
            UmumiyMaxraj(son1, son2);
            son1.surat = son1.surat - son2.surat;

            return KasrQisqartirish(son1.surat, UmumiyMaxraj(son1, son2));
        }

        public static long Multiply(Kasr son1, Kasr son2)
        {
            son1.surat =  son1.surat * son2.surat;
            son1.maxraj = son1.maxraj * son2.maxraj;

            return KasrQisqartirish(son1.surat, son1.maxraj);
        }

        public static long Divide(Kasr son1, Kasr son2)
        {
            son1.surat = son1.surat * son2.maxraj;
            son1.maxraj = son2.surat * son1.maxraj;

            return KasrQisqartirish(son1.surat, son1.maxraj);
        }


    }
}
