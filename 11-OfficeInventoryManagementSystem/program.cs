using System;
using System.Collections.Generic;

public class InventoryManagement
{
    public static void Main(string[] args){
        // Your code goes here
        List<string>  inventoryList = new List<string>();
        inventoryList.AddRange(new List<string> {"Printer", "Laptop", "Desk Chair", "Montitor", "Keyboard"});
        Console.WriteLine(inventoryList.Count);

        bool hasDeskChair = inventoryList.Contains("Desk Chair");
        Console.WriteLine(hasDeskChair);
        bool removed = inventoryList.Remove("Printer");
        Console.WriteLine(removed);
        foreach (string el in inventoryList) 
        {
            Console.WriteLine(el);
        }
        List<string> newItems= new List<string>{"Mouse", "Desk Lamp"};
        inventoryList.AddRange(newItems);
        inventoryList.RemoveRange(inventoryList.Count-2, 2);
        List<string> topInventory = inventoryList.GetRange(0,2);
        foreach (string el in topInventory) 
        {
            Console.WriteLine(el);
        }
    }
}