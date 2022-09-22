using Microsoft.AspNetCore.Components;
using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.Inventories.Interfaces;

namespace InventoryManagementSystem.ClientApp.Controls
{
    public partial class InventoryListComponent
    {
        [Inject]
        private IViewInventoriesUseCase _viewInventories { get; set; }

        private IEnumerable<Inventory> inventories;

        [Parameter]
        public string SearchString { get; set; }

        //protected override async Task OnParametersSetAsync()
        //{
        //    inventories = (await ViewInventoriesByNameUseCase.ExecuteAsync(SearchString)).ToList();
        //}

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            inventories = await _viewInventories.Execute();
        }

        private IQueryable<Inventory> GetInventories()
        {
            if (inventories == null) return null;

            var result = inventories.AsQueryable();

            if(!string.IsNullOrWhiteSpace(SearchString))
            {
                result = result.Where(i => i.InventoryName.Contains(SearchString, StringComparison.OrdinalIgnoreCase));
            }

            return result;
        }
    }
}