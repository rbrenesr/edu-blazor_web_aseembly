using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServicioSingleton Singleton { get; set; } = null!;
        [Inject] ServicioTrasient Transient { get; set; } = null!;

        [Inject] IJSRuntime JS { get; set; } = null!;
        IJSObjectReference modulo;



        private int currentCount = 0;
        private static int currentCountStatic = 0;

        private async Task IncrementCount()
        {
            modulo = await JS.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("mostrarAlerta", "Hola mundo");

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
