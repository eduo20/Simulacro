namespace Simulacro.Models
{
    public enum TipoPelaje
    {
        Corto,
        Largo,
        SinPelo // Corregido el estilo de la mayúscula para mantener el código limpio
    }

    public class Gato : Animales
    {
        // Propiedad directa para enlazar con el select en Blazor y guardar en el JSON
        public TipoPelaje TipoPelajeSeleccionado { get; set; } = TipoPelaje.Corto;

        public bool esDomestico { get; set; }
    }
}