using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2lab1
{
    class Phone
    {
        public string Name;
        public string Model;
        public string ReleaseYear;
        public int YearOfPurchase;
        public string BatteryCapacity;
        public string ProcessorName;
        public string AmountOfCores;
        public string AmountOfRAM;
        public string AmountOfMemory;
        public string Diagonal;
        public bool Has3Cameras;
        public bool HasWirelessCharging;

        public double getGaranteEndingYear()
        {
            if (Name == "iPhone") return YearOfPurchase + 1;
            else if (Name == "Samsung") return YearOfPurchase + 2;
            else return YearOfPurchase + 3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть фiрму телефона: ");
            string sName = Console.ReadLine();

            Console.Write("Введiть назву моделi: ");
            string sModel = Console.ReadLine();

            Console.Write("Введiть рiк виходу телефону: ");
            string sReleaseYear = Console.ReadLine();

            Console.Write("Введiть рiк покупки телефону: ");
            int sYearOfPurchase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть ємність акамулятору (mA/h): ");
            string sBatteryCapacity = Console.ReadLine();

            Console.Write("Введiть назву процесора: ");
            string sProcessorName = Console.ReadLine();

            Console.Write("Введiть кiлькiсть ядер в процесорi: ");
            string sAmountOfCores = Console.ReadLine();

            Console.Write("Введiть кiлькiсть пам'ятi(Гб): ");
            string sAmountOfMemory = Console.ReadLine();

            Console.Write("Введiть кiлькiсть оперативноi пам'ятi(Гб): ");
            string sAmountOfRAM = Console.ReadLine();

            Console.Write("Введiть довжину дiагоналi екрану телефона(дюймiв): ");
            string sDiagonal = Console.ReadLine();

            Console.Write("Чи є у телефона 3 камери? (у-так, n-нi): ");
            ConsoleKeyInfo keyHas3Cameras = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Чи є у телефона бездротова зарядка? (у-так, n-нi): ");
            ConsoleKeyInfo keyHasWirelessCharging = Console.ReadKey();
            Console.WriteLine();

            Phone YourPhone = new Phone();
            YourPhone.Name = sName;
            YourPhone.Model = sModel;
            YourPhone.ReleaseYear = sReleaseYear;
            YourPhone.YearOfPurchase = sYearOfPurchase; 
            YourPhone.AmountOfCores = sAmountOfCores;
            YourPhone.BatteryCapacity = (sBatteryCapacity);
            YourPhone.ProcessorName = (sProcessorName);
            YourPhone.AmountOfMemory = (sAmountOfMemory);
            YourPhone.AmountOfRAM = (sAmountOfRAM);
            YourPhone.Diagonal = (sDiagonal);
            YourPhone.Has3Cameras = keyHas3Cameras.Key == ConsoleKey.Y ? true : false;
            YourPhone.HasWirelessCharging = keyHasWirelessCharging.Key == ConsoleKey.Y ? true : false;
            
            double GaranteEndingYear = YourPhone.getGaranteEndingYear();
            
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Данi про об'ект: ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Фiрма: " + YourPhone.Name);
            Console.WriteLine("Модель: " + YourPhone.Model);
            Console.WriteLine("Рiк випуску: " + YourPhone.ReleaseYear);
            Console.WriteLine("Рiк покупки: " + YourPhone.YearOfPurchase);
            Console.WriteLine("Процессор: " + YourPhone.ProcessorName);
            Console.WriteLine("Кiлькiсть ядер: " + YourPhone.AmountOfCores);
            Console.WriteLine($"Ємнiсть акамулятора:  { YourPhone.BatteryCapacity}мA/г");
            Console.WriteLine($"Кiлькiсть пам'ятi: " + YourPhone.AmountOfMemory);
            Console.WriteLine($"Кiлькiсть оперативноi пам'ятi: {YourPhone.AmountOfRAM}Гб ");
            Console.WriteLine($"Дiагональ екрану: {YourPhone.Diagonal} дюймiв");
            Console.WriteLine(YourPhone.Has3Cameras ?
            "Має три або бiльше камер " : "Має меньше трьох камер");
            Console.WriteLine(YourPhone.HasWirelessCharging ?
            "Телефон має бездротову зарядку" : "Не має бездротовоi зарядки");
            if (GaranteEndingYear >= 2023) Console.WriteLine
                    ($"Гарантiя закiнчується в {GaranteEndingYear} роцi ");
            else Console.WriteLine($"Гарантiя закiнчилась в {GaranteEndingYear} роцi ");
            Console.WriteLine("\n \n Виконав: Лiвак Саша 2IСТ-23б");
            Console.ReadKey();
        }
    }
}
