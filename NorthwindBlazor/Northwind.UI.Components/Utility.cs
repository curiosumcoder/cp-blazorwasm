using Microsoft.JSInterop;

namespace Northwind.UI.Components
{
    public class Utility
    {
        readonly IJSRuntime _jsr;

        public Utility(IJSRuntime jsr) {
            _jsr = jsr;
        }
        public async Task Alert(string message)
        {
            await _jsr.InvokeVoidAsync("alert", message);
        }

        public async Task<bool> Confirm()
        {
            return await _jsr.InvokeAsync<bool>("confirm", "¿Confirme que desea proceder con la acción?");
        }
    }
}
