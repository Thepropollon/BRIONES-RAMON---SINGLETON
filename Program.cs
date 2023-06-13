using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        InventoryManager inventoryManager = InventoryManager.Instance;

        inventoryManager.AddProduct("Manzanas", 10);
        inventoryManager.AddProduct("Plátanos", 5);

        Console.WriteLine($"Cantidad de manzanas en el inventario: {inventoryManager.GetProductQuantity("Manzanas")}");
        Console.WriteLine($"Cantidad de plátanos en el inventario: {inventoryManager.GetProductQuantity("Plátanos")}");

        inventoryManager.RemoveProduct("Manzanas", 3);

        Console.WriteLine($"Cantidad de manzanas en el inventario después de la venta: {inventoryManager.GetProductQuantity("Manzanas")}");
    }
}