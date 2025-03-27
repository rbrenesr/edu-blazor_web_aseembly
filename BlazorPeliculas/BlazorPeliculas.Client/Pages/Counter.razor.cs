﻿using BlazorPeliculas.Client.Helpers;
using MathNet.Numerics.Statistics;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Xml.Xsl;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        [Inject] public IJSRuntime js { get; set; } = null!;


        private async Task IncrementCount()
        {     
            

            var arreglo = new double[] { 1, 2, 3, 4, 5 };
            var max = arreglo.Maximum();
            var min = arreglo.Minimum();

            js.InvokeVoidAsync("alert", $"El max es {max}, el min es {min}");

            currentCount++;
        }
    }
}
