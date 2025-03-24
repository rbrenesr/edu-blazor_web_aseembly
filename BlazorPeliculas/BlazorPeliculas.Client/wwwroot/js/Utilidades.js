function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync('BlazorPeliculas.Client', 'ObtenerCurrentCount')
        .then(resultado => {
            console.log('Contador desde javascript: ' + resultado);
        });
}