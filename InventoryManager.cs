using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InventoryManager
{
    private static InventoryManager instance;
    private Dictionary<string, int> inventory;

    private InventoryManager()
    {
        // Constructor privado
        inventory = new Dictionary<string, int>();
    }

    public static InventoryManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new InventoryManager();
            }
            return instance;
        }
    }

    public void AddProduct(string product, int quantity)
    {
        if (inventory.ContainsKey(product))
        {
            inventory[product] += quantity;
        }
        else
        {
            inventory.Add(product, quantity);
        }
        Console.WriteLine($"{quantity} {product}(s) añadido(s) al inventario.");
    }

    public void RemoveProduct(string product, int quantity)
    {
        if (inventory.ContainsKey(product))
        {
            if (inventory[product] >= quantity)
            {
                inventory[product] -= quantity;
                Console.WriteLine($"{quantity} {product}(s) eliminado(s) del inventario.");
            }
            else
            {
                Console.WriteLine($"No hay suficiente cantidad de {product} en el inventario.");
            }
        }
        else
        {
            Console.WriteLine($"El producto {product} no está en el inventario.");
        }
    }

    public int GetProductQuantity(string product)
    {
        if (inventory.ContainsKey(product))
        {
            return inventory[product];
        }
        else
        {
            return 0;
        }
    }
}