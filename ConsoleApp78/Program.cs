using System;

namespace ConsoleApp78
{
    public class Program
    {
        static void Main(string[] args)
        {
           bool check=true;
            do
            {
                Console.WriteLine("---------Menu----------");
                Console.WriteLine("Seciminizi edin");
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Tələbəyə imtahan əlavə et");
                Console.WriteLine("3. Tələbənin bir imtahan balına bax");
                Console.WriteLine("4. Tələbənin bütün imtahanlarını göstər");
                Console.WriteLine("5. Tələbənin imtahan ortalamasını göstər");
                Console.WriteLine("6.Tələbədən imtahan sil");
                string cohoice=Console.ReadLine();

                switch (cohoice)
                {
                    case "1":   
                    default:
                        break;
                }
            } while (check); 
        }
    }
}
