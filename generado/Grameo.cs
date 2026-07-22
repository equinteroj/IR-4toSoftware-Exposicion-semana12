namespace Acuicultura
{
    public class Grameo
    {
        public int IdGrameo;
        public DateTime Fecha;
        public double PesoPromedio;

        public void RegistrarPeso() { }
        public double CalcularBiomasa() { return 0; }

        public Siembra Siembra { get; set; }
    }
}