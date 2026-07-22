namespace Acuicultura
{
    public class AlertaAgua
    {
        public int IdAlerta;
        public string Tipo;
        public string Mensaje;
        public DateTime FechaGeneracion;

        public void GenerarAlerta() { }
        public void Notificar() { }

        public ParametroAgua ParametroAgua { get; set; }
    }
}