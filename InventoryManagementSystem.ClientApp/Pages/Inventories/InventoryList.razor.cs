using InventoryManagementSystem.ClientApp.Utils;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InventoryManagementSystem.ClientApp.Pages.Inventories
{
    public partial class InventoryList : ComponentBase, IDisposable
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