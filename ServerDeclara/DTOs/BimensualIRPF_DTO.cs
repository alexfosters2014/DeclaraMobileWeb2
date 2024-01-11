using ServerDeclara.Datos;

namespace ServerDeclara.DTOs
{
    public class BimensualIRPF_DTO
    {
        public int Id { get; set; }
        public Usuario_DTO Usuario { get; set; } = new Usuario_DTO();
        public virtual DeclaracionMensualIRPF_DTO DeclaracionMes1 { get; set; } = new DeclaracionMensualIRPF_DTO();
        public virtual DeclaracionMensualIRPF_DTO DeclaracionMes2 { get; set; } = new DeclaracionMensualIRPF_DTO();

        public double AnticipoExcedente { get; set; } = 0;
        public double AnticipoBimestre { get; set; } = 0;

        public bool AnticipoNF_SI_NO { get; set; } // NO-1 SI-0.95

    }
}
