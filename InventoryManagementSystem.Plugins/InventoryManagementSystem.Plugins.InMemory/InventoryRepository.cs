using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.PluginInterface;

namespace InventoryManagementSystem.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        public List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            { 
                new Inventory {InventoryId =1, InventoryName = "Bike Seat", Quantity = 10, Price =2},
                new Inventory {InventoryId =1, InventoryName = "Bike Body", Quantity = 10, Price =15},
                new Inventory {InventoryId =1, InventoryName = "Bike Wheels", Quantity = 20, Price =8},
                new Inventory {InventoryId =1, InventoryName = "Bike Pedal", Quantity = 20, Price =1}
            };
        }

        public async Task<IEnumerable<Inventory>> GetAllInventoriesAsync()
        {
            return await Task.FromResult(_inventories);
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(i => i.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }


    }
}