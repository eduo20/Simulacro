namespace Simulacro.Models
{
    // Colocamos el enum afuera para libre acceso
    public enum TipoPico
    {
        Curvo,
        Recto,
        Aguja
    }

    public class Ave : Animales
    {
        // Esta propiedad guardará la opción elegida del select
        public TipoPico TipoPicoSeleccionado { get; set; } = TipoPico.Recto;

        public bool puedeVolar { get; set; }
    }
}