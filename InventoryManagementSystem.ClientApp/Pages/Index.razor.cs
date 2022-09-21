using Microsoft.AspNetCore.Components;
using InventoryManagementSystem.UseCases.Inventories.Interfaces;
using InventoryManagementSystem.CoreBusiness;

namespace InventoryManagementSystem.ClientApp.Pages
{
    public partial class Index
    {
        [Inject]
        public IViewInventoriesByNameUseCase ViewInventoriesByNameUseCase { get; set; }

        private List<Inventory> _inventories = new List<Inventory>();

        protected override async Task OnInitializedAsync()
        {
            _inventories = (await ViewInventoriesByNameUseCase.ExecuteAsync()).ToList();
        }
    }
}