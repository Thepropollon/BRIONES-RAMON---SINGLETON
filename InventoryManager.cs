using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InventoryManager
{
    private static InventoryManager instance; // Instancia única de InventoryManager
    private Dictionary<string, int> inventory;  // Diccionario para almacenar el inventario

    private InventoryManager()
    {
        // Constructor privado para evitar la creación externa de instancias
        inventory = new Dictionary<string, int>();  // Inicialización del inventario
    }

    public static InventoryManager Instance
    {
        get
        {
            if (instance == null)
            {                                       // Si no se ha creado una instancia previamente
                instance = new InventoryManager();  // Crear una nueva instancia
            }
            return instance;  // Devolver la instancia existente o recién creada
        }
    }

    public void AddProduct(string product, int quantity)  // Método para agregar productos al inventario
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

    public void RemoveProduct(string product, int quantity)  // Método para eliminar productos del inventario
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

    public int GetProductQuantity(string product) // Método para obtener la cantidad de un producto en el inventario
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
