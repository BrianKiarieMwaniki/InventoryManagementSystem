using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.Inventories.Interfaces;
using InventoryManagementSystem.UseCases.PluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.UseCases.Inventories
{
    public class ViewInventoriesUseCase : IViewInventoriesUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ViewInventoriesUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> Execute()
        {
            return await _inventoryRepository.GetAllInventoriesAsync();
        }
    }
}
