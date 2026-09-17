//ชื่อ - นามสกุล: พรหมพิริยะ เล็กสุวรรณ
//Section: 129C
//รหัสนักศึกษา: 1690702293
//เลขที่: N/A

namespace Lab04
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|        NEW ADVENTURER        |");
            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Name your hero: ");
            Console.Write(">>> ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {playerName}!");

            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|    DIFFICULTY SELECT     |");
            Console.WriteLine("+--------------------------+");

            Console.Write("Choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty {difficulty} selected.Good luck out there...");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");

            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");





        }
    }
}