namespace Acuicultura
{
    public class ParametroAgua
    {
        public int IdParametro; 
        public double Temperatura; 
        public double PH; 
        public double OxigenoDisuelto; 

        public void RegistrarLectura() { }
        public bool ValidarRango() { return true; }

    }
}