
/*
 * Student ID : 1690702293
 * Name       : พรหมพิริยะ เล็กสุวรรณ
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("=====BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();
            // คำนวณเปอร์เซ็นต์
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine($"Kirin takes 60 damage!");
            Console.WriteLine();
            // ลด HP ของบอสลง 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("=====BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine("===== Dark Fantasy =====");
            //ชื่อตัวละคร
            string HumanName = "Odysseus";
            string KnightName = "Agamemnon";
            string CreatureName = "Scylla";
            string WitchName = "Circe";
            // ระดับของตัวละคร
            char HumanRank = 'A';
            char KnightRank = 'S';
            char CreatureRank = 'C';
            char WitchRank = 'C';
            // เผ่าพันธุ์ของตัวละคร
            string raceOdysseus = "Human";
            string raceAgamemnon = "Knight";
            string raceScylla = "Creature";
            string raceCirce = "Witch";
            // อาชีพของตัวละคร
            string classOdysseus = "Paladin";
            string classAgamemnon = "General";
            string classScylla = "Monster";
            string classCirce = "Mage";
            // เลเวลของตัวละคร
            int levelOdysseus = 5;
            int levelAgamemnon = 10;
            int levelScylla = 4;
            int levelCirce = 3;
            // ค่าพลังโจมตีของตัวละคร
            float attackPowerOdysseus = 16.5f;
            float attackPowerAgamemnon = 30.0f;
            float attackPowerScylla = 20.6f;
            float attackPowerCirce = 25.5f;
            // ค่าพลังชีวิตของตัวละคร
            int maxHpOdysseus = 100;
            int maxHpAgamemnon = 200;
            int maxHpScylla = 70;
            int maxHpCirce = 100;
            // ค่าตัวคูณคริติคอลของตัวละคร
            double critMultiplierOdysseus = 1.4;
            double critMultiplierAgamemnon = 1.2;
            double critMultiplierScylla = 1.8;
            double critMultiplierCirce = 1.3;
            // สถานะการเป็นสมาชิกปาร์ตี้ของตัวละคร
            bool isPartyMemberOdysseus = true;
            bool isPartyMemberAgamemnon = true;
            bool isPartyMemberScylla = true;
            bool isPartyMemberCirce = false;


            Console.WriteLine("=====CHARACTER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {HumanName}");
            Console.WriteLine($"Rank: {HumanRank}");
            Console.WriteLine($"Race: {raceOdysseus}");
            Console.WriteLine($"Class: {classOdysseus}");
            Console.WriteLine($"Level: {levelOdysseus}");
            Console.WriteLine($"Max HP: {maxHpOdysseus}");
            Console.WriteLine($"Attack Power: {attackPowerOdysseus}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierOdysseus}");
            Console.WriteLine($"Is Party Member: {isPartyMemberOdysseus}");
            Console.WriteLine();
            Console.WriteLine($"Name: {KnightName}");
            Console.WriteLine($"Rank: {KnightRank}");
            Console.WriteLine($"Race: {raceAgamemnon}");
            Console.WriteLine($"Class: {classAgamemnon}");
            Console.WriteLine($"Level: {levelAgamemnon}");
            Console.WriteLine($"Max HP: {maxHpAgamemnon}");
            Console.WriteLine($"Attack Power: {attackPowerAgamemnon }");
            Console.WriteLine($"Critical Multiplier: {critMultiplierAgamemnon}");
            Console.WriteLine($"Is Party Member: {isPartyMemberAgamemnon}");
            Console.WriteLine();
            Console.WriteLine($"Name: {CreatureName}");
            Console.WriteLine($"Rank: {CreatureRank}");
            Console.WriteLine($"Race: {raceScylla}");
            Console.WriteLine($"Class: {classScylla}");
            Console.WriteLine($"Level: {levelScylla}");
            Console.WriteLine($"Max HP: {maxHpScylla}");
            Console.WriteLine($"Attack Power: {attackPowerScylla}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierScylla}");
            Console.WriteLine($"Is Party Member: {isPartyMemberScylla}");
            Console.WriteLine();
            Console.WriteLine($"Name: {WitchName}");
            Console.WriteLine($"Rank: {WitchRank}");
            Console.WriteLine($"Race: {raceCirce}");
            Console.WriteLine($"Class: {classCirce}");
            Console.WriteLine($"Level: {levelCirce}");
            Console.WriteLine($"Max HP: {maxHpCirce}");
            Console.WriteLine($"Attack Power: {attackPowerCirce}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierCirce}");
            Console.WriteLine($"Is Party Member: {isPartyMemberCirce}");
            Console.WriteLine();


        }
    }
}
