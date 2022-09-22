namespace InventoryManagementSystem.ClientApp.Utils
{
    public class SearchObject : NotifyingObject
    {
        public string _searchString;

        public string SearchString
        {
            get { return _searchString; }
            set
            {
                if (_searchString == value) return;
                _searchString = value;
                NotifyPropertyChanged();
            }
        }
    }
}
