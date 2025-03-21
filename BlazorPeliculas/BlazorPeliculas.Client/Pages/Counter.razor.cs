using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServicioSingleton Singleton { get; set; } = null!;
        [Inject] ServicioTrasient Transient { get; set; } = null!;

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
        }

    }
}
