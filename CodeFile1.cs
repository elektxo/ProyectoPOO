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
        public string estado_poliza { get; set; } // Vigor: De acuerdo, PteLlegada: En espera, baja: cancelada
    }

    public class recibo
    {
        public int Nro_poliza_asociado { get; set; }
        public int Nro_recibo { get; set; }
        public string fecha_emision { get; set; }
        public int Importe_seguro { get; set; }
        public string estado_recibo { get; set; } // Pendiente, Cobrado, Devuelto
        public int comision { get; set; }
        public string fecha_liquidacion { get; set; }

    }

    public class Siniestros 
    { 
        public int Nro_siniestro { get; set; } // Año-nroSecuencial 
        public int nro_poliza { get; set; }
        public string cia_contraria { get; set; }
        public string Nro_poliza_contraria { get; set; }
        public string Matricula_contraria { get; set; }
        public int Importe_siniestro { get; set; } // Dinero para el taller
        public string Fecha_pago { get; set; } // Fecha para el pago al taller
        public string fecha_liquidacion { get; set; } 
    }
    

    public class suma_importes_recibos_cobrados
    {

    }

    public class suma_importes_comisiones
    {


    }

    public class sum_pagos_por_siniestros
    {

    }
    public class Main
    {
        public static void menu()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("GESTOR DE SEGUROS");
                Console.WriteLine("1. Crear Poliza");
                Console.WriteLine("2. Recibos");
                Console.WriteLine("3. Siniestros");
                Console.WriteLine("4. Liquidaciones");
                Console.WriteLine("5. Listado de los recibos");
                Console.WriteLine("6. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        salir = true;
                        break;
                }

            }
            


        }
    }
    
}
