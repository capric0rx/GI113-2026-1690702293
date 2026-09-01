/*
 * Student ID : 1690702293
 * Name       : พรหมพิริยะ เล็กสุวรรณ
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("==== KIRIN SAVE CONVERTER ====");
            Console.WriteLine($"Name: {bossName}" +
                $"\nRank: {rank}" +
                $"\nLevel: {level}/{MaxLevel}" +
                $"\nHP: {currentHp}/{maxHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");
            //1.Implicit Coversion int (HP) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP Percent (exact): {currentHpDouble}");

            //2. Calculate Percentage
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            //3.Explicit float (attackPower) -->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackPowerInt}");

            //4. Cast vs. Convert double (critMultiplier) -->> int
            Console.WriteLine("\n----- Cast vs. Convert: Crit Multiplier -----");
            int critMultiplierCast = (int)critMultiplier;
            int critMultiplierConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critMultiplierCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critMultiplierConvert}");
        }   

    }
}
