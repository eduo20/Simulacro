using Simulacro.Models;
using System.Runtime.CompilerServices;
using System.Text.Json;


namespace Simulacro.Services
{
    public class RegistroAnimales
    {
        private readonly string _almacenAnimales = "animales.json";

        public ListaAnimales Leerlistas()
        {
            if (!File.Exists(_almacenAnimales))

                return new ListaAnimales();
            try
            {
                var json = File.ReadAllText(_almacenAnimales);
                return JsonSerializer.Deserialize<ListaAnimales>(json) ?? new ListaAnimales();
            }
            catch
            {
                return new ListaAnimales();
            }
        }

        public void GuardarPerros(Perro nuevoPerro)
        {
            var lista = Leerlistas();
            lista.perros.Add(nuevoPerro);
            EscribirArchivo(lista);

        }

        public void GuardarGatos(Gato nuevoGato)
        {
            var lista = Leerlistas();
            lista.gatos.Add(nuevoGato);
            EscribirArchivo(lista);
        }

        public void GuardarAves(Ave nuevaAve)
        {
            var lista = Leerlistas();
            lista.aves.Add(nuevaAve);
            EscribirArchivo(lista);
        }


        private void EscribirArchivo(ListaAnimales datos)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(datos, opciones);
            File.WriteAllText(_almacenAnimales, jsonData);
        }
    }
}
