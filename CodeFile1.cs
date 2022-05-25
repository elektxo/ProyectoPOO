namespace ProyectoPOO
{
    public class persona
    {
        public string nombre_completo { get; set; }
        public string nif { get; set; }
        public string fecha_nac { get; set; }
        public string telefono { get; set; }
    }

    public class empresa
    {
        public string nombre { get; set; }
        public string cif { get; set; }
        public string responsable { get; set; }
        public string nif_responsable { get; set; }
        public string telefono { get; set; }
    }

    public class poliza
    {
        public int Nro_poliza { get; set; }
        public string datos_tomador { get; set; }
        public string fecha_efecto { get; set; }
        public string estado_poliza { get; set; }
    }

    public class recibo
    {
        public int Nro_poliza_asociado { get; set; }
        public int Nro_recibo { get; set; }
        public string fecha_emision { get; set; }
        public int Importe_seguro { get; set; }
        public string estado_recibo { get; set; }
        public int comision { get; set; }
        public string fecha_liquidacion { get; set; }

    }

    public class Siniestros
    {
        public int Nro_siniestro { get; set; }
        public int nro_poliza { get; set; }
        public int cia_contraria { get; set; }
        public int Nro_poliza_contraria { get; set; }
        public string Matricula_contraria { get; set; }
        public int Importe_siniestro { get; set; }
        public string Fecha_pago { get; set; }
        public string fecha_liquidacion { get; set; }
    }
}