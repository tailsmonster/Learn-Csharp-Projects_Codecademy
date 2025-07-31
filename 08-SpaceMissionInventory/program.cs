using System;

namespace SpaceMission
{
  class Program
  {
    static void Main(string[] args)
    {
      // Your code goes here
      string[] spaceInventory;

      spaceInventory = new string[] {"Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools"};

      int[] items = {10, 8, 15, 5, 6, 9, 4, 7};

      if (spaceInventory.Length == 8) {
        Console.WriteLine("Space Inventory is ready to go!");
      } else if (spaceInventory.Length < 8) {
        Console.WriteLine("Add more items");
      } else {
        Console.WriteLine("Too Many items!");
      }
      Console.WriteLine($"{spaceInventory[1]}, {items[1]}");

      spaceInventory[spaceInventory.Length-1] = "Scientific Instruments";
      items[items.Length-1] = 5;

      Console.WriteLine($"The first items with the quantity 5 is at position {Array.IndexOf(items, 5)}");

      Array.Reverse(spaceInventory);

      Console.WriteLine($"{spaceInventory[0]}, {spaceInventory[spaceInventory.Length-1]}");

      Array.Sort(spaceInventory);

      Console.WriteLine($"{spaceInventory[0]}, {spaceInventory[spaceInventory.Length-1]}");

    }
  }
}
