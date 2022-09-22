using Microsoft.AspNetCore.Components;
using InventoryManagementSystem.UseCases.Inventories.Interfaces;
using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.ClientApp.Utils;
using System.ComponentModel;

namespace InventoryManagementSystem.ClientApp.Pages
{
    public partial class Index: ComponentBase, IDisposable
    {
        private SearchObject SearchObject;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            SearchObject = new SearchObject();
            SearchObject.PropertyChanged += HandleSearchObjectPropertyChanged;

        }

        private void HandleSearchObjectPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            StateHasChanged();
        }

        public void Dispose()
        {
            SearchObject.PropertyChanged -= HandleSearchObjectPropertyChanged;
        }
    }
}