namespace Northwind.UI.Services.State
{
    public class StateContainer
    {
        private string? _filter;

        public string Filter
        {
            get => _filter ?? string.Empty;
            set
            {
                _filter = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
