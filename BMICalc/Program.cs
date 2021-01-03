using System;

namespace BMICalc
{
    internal class Program
    {
        public void calcBmi(double kilo, double boy)
        {
            if ((boy%1) == 0)
            {
                boy = boy / 100;
            }
            var bmi = kilo / (boy * boy);
            if (bmi >3 & bmi < 18.5)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0} ve Zayıfsınız",Math.Round(bmi,2));
            }
            else if (bmi>18.5 & bmi<24.9)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0} ve Kilonuz Normal",Math.Round(bmi,2));
            }
            else if (bmi > 25 & bmi < 29.9)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0} ve Fazla Kilolusunuz",Math.Round(bmi,2));
            }
            else if (bmi > 30 & bmi < 34.9)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0} ve I. Derece Obezsiniz",Math.Round(bmi,2));

            }
            else if (bmi > 35 & bmi < 39.9)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0} ve II. Derece Obezsiniz",Math.Round(bmi,2));

            }
            else if (bmi>40)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0} ve III. Derece Obezsiniz",Math.Round(bmi,2));

            }
            else
            {
                Console.WriteLine("ÖLÜSÜNÜZ!");
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu giriniz");
            var kilo = double.Parse(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz: ");
            var boy = double.Parse(Console.ReadLine());
            Program p = new Program();
            p.calcBmi(kilo, boy);

        }
    }
}