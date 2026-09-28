//ชื่อ-นามสกุล: พรหมพิริยะ เล็กสุวรรณ
//Section: 129C
//รหัสนักศึกษา: 1690702293
//เลขที่: N / A

using System.Collections;
using System.Diagnostics.Metrics;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hpHero = 100;
            int atkHero = 20;
            int VillainHp = 40;
            int VillainAtk = 10;
            int healHero = 10;

            Console.WriteLine($"Game Title : Hero vs. Villain");
            Console.WriteLine($"ACTION1: ATTACK");
            Console.WriteLine($"ACTION2: HAVE ATTACK");
            Console.WriteLine($"ACTION3: HEAL");
            Console.WriteLine($"Enter your action:(1-3)");
            bool important = int.TryParse(Console.ReadLine(), out int action);

            if (important || action < 1 || action > 3)
            {
                Console.WriteLine("Invalid action. Please enter 1, 2, or 3.");
            }
            else if (action == 1)
            {
                VillainHp -= atkHero;
                if (VillainHp <= 0)
                {
                    Console.WriteLine("Hero attacks Villain! Villain is defeated!");
                }
                else
                {
                    Console.WriteLine($"Hero attacks Villain! Villain's HP is now {VillainHp}.");
                }
                Console.WriteLine("Hero chooses to have attack!");
            }
            else if (action == 2)
            {
                VillainHp -= atkHero;
                if (VillainHp <= 0)
                {
                    Console.WriteLine("Hero attacks Villain! Villain is defeated!");
                }
                else
                {
                    Console.WriteLine($"Hero attacks Villain! Villain's HP is now {VillainHp}.");
                }
                Console.WriteLine("Hero chooses to have attack!");
            }
            else
            {
                hpHero += healHero;
            }


        }
    }
}