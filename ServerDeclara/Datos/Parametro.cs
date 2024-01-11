using Microsoft.Identity.Client;

namespace ServerDeclara.Datos
{
    public class Parametro
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public double IngresosDesde { get; set; }
        public double IngresosHasta { get; set; }
        public double Tasa { get; set; }
        public DateTime ValidezParametrosDesde { get; set; }
        public DateTime ValidezParametrosHasta { get; set; }
        public string Atributo { get; set; }
        public string Formula { get; set; }
        public string Tipo { get; set; }
        public int Orden { get; set; }

        public Parametro()
        {
            
        }
        public Parametro(string descripcion, double ingresosDesde, double ingresosHasta, double tasa, DateTime validezParametrosDesde, DateTime validezParametrosHasta, string atributo, string formula, string tipo, int orden)
        {
            Descripcion = descripcion;
            IngresosDesde = ingresosDesde;
            IngresosHasta = ingresosHasta;
            Tasa = tasa;
            ValidezParametrosDesde = validezParametrosDesde;
            ValidezParametrosHasta = validezParametrosHasta;
            Atributo = atributo;
            Formula = formula;
            Tipo = tipo;
            Orden = orden;
        }
    }
}
