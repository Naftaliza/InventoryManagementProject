using System;
using System.Data.Entity;

namespace WCFProject
{
    public class InventoryService : IInventoryService
    {
        public int AddInventoryItem(InventoryItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Inventory item cannot be null.");

            if (string.IsNullOrEmpty(item.Name))
                throw new ArgumentException("Item name is required.", nameof(item.Name));

            if (item.Quantity < 0)
                throw new ArgumentException("Quantity must be non-negative.", nameof(item.Quantity));

            if (item.UnitPrice < 0)
                throw new ArgumentException("Unit price must be non-negative.", nameof(item.UnitPrice));

            using (var context = new InventoryDbContext())
            {
                context.InventoryItems.Add(item);
                context.SaveChanges();
            }

            return item.Id;
        }

        public InventoryItem GetInventoryItem(int itemId)
        {
            using (var context = new InventoryDbContext())
            {
                return context.InventoryItems.Find(itemId);
            }
        }

        public void UpdateInventoryItem(InventoryItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Inventory item cannot be null.");

            var existingItem = GetInventoryItem(item.Id);
            if (existingItem == null)
                throw new InvalidOperationException($"Inventory item with ID {item.Id} does not exist.");

            if (string.IsNullOrEmpty(item.Name))
                throw new ArgumentException("Item name is required.", nameof(item.Name));

            if (item.Quantity < 0)
                throw new ArgumentException("Quantity must be non-negative.", nameof(item.Quantity));

            if (item.UnitPrice < 0)
                throw new ArgumentException("Unit price must be non-negative.", nameof(item.UnitPrice));

            using (var context = new InventoryDbContext())
            {
                context.Entry(item).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void DeleteInventoryItem(int itemId)
        {
            var existingItem = GetInventoryItem(itemId);
            if (existingItem == null)
                throw new InvalidOperationException($"Inventory item with ID {itemId} does not exist.");

            using (var context = new InventoryDbContext())
            {
                var itemToDelete = context.InventoryItems.Find(itemId);

                if (itemToDelete == null) return;

                context.InventoryItems.Remove(itemToDelete);
                context.SaveChanges();
            }
        }
    }
}
