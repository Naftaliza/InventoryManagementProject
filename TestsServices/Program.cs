using System;
using TestsServices.ServiceReference1;

namespace TestsServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new InventoryServiceClient();

            // Test adding a new item
            var newItem = new InventoryItem
            {
                Name = "New Item",
                Description = "Description of new item",
                Quantity = 10,
                UnitPrice = 20.99m
            };
            var itemId = client.AddInventoryItem(newItem);

            // Test retrieving the added item
            var retrievedItem = client.GetInventoryItem(itemId);
            Console.WriteLine($"Retrieved Item: {retrievedItem.Name}");

            // Test updating the item
            Console.WriteLine($"Previous Item Quantity: {retrievedItem.Quantity}");
            retrievedItem.Quantity = 20;
            client.UpdateInventoryItem(retrievedItem);
            Console.WriteLine($"Modified Item Quantity: {retrievedItem.Quantity}");

            // Test deleting the item
            client.DeleteInventoryItem(retrievedItem.Id);

            // Test error handling  (trying to retrieve a deleted item)
            try
            {
                retrievedItem = client.GetInventoryItem(1);
                Console.WriteLine($"Retrieved Item: {retrievedItem.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
