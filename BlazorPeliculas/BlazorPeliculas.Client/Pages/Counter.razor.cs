using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServicioSingleton Singleton { get; set; } = null!;
        [Inject] ServicioTrasient Transient { get; set; } = null!;

        [Inject] IJSRuntime JS { get; set; } = null!;

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        private async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount() {
            return Task.FromResult(currentCountStatic);
        }

    }
}
