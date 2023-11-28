namespace EncuestaLenguajesProgramacion.Models
{
    public class LenguajeProgramacion
    {
        public int Id { get; set; }
        public String? Nombre { get; set; }
        public int ClasificacionPorcentual { get; set; }
        public int DiferenciaPorcentual { get; set; }
        public int Posicion { get; set; }
        public double Entradas { get; set; }
    }
}
