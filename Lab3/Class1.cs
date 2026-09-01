/*
 * Student ID : 1690702293
 * Name       : พรหมพิริยะ เล็กสุวรรณ
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab3
{
    public class Class1
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
            $"\nLevel: {level} / {MaxLevel}" +
            $"\nHP: {currentHp} / {maxHp}" +
            $"\nAttack Power: {attackPower}" +
            $"\nCritical Multiplier: {critMultiplier}" +
            $"\nIs Boss: {isBoss}");
      // 1. Implicit Conversion int (Hp) --->> double
      Console.WriteLine("n---- Implicit Conversion int: Hp as double");
      double currentHpDouble = currentHp;
      Console.WriteLine($"Current HP (double): {currentHpDouble}");
    }
}
