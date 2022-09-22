using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesUseCase
    {
        Task<IEnumerable<Inventory>> Execute();
    }
}