namespace ServerDeclara.Datos
{
    public class ParametrosIRPF
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int RangoDesde { get; set; }
        public int RangoHasta { get; set; }
        public int Tasa { get; set; }
        public int Anio { get; set; }
    }
}
