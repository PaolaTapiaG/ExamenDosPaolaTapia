namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new PrincipalVistasC.MenuPrincipalVistas());
            // Application.Run(new PersonaVistas.PersonaInsertarVista());  
            // Application.Run(new RegistroVistasC.RegistroVistas());  
            //Application.Run(new UsuarioVistas.UsuarioDatosVista());
            //Application.Run(new ProductoVistas.ProductosDatosVistas());
            //Application.Run(new ClienteVistas.ClienteDatosVistas());
            //Application.Run(new ProveedorVistas.ProveedorDatosVistas());
            //Application.Run(new DetalleVentaVistas.DetalleVentaDatosVistas());
            Application.Run(new ExamenDosClientesVista.ClientesVistas());
            Application.Run(new ExamenDosClientesVista.MarcasVistas());
            Application.Run(new ExamenDosClientesVista.ProductoVistas());
            Application.Run(new ExamenDosClientesVista.ProveedorVistas());
            Application.Run(new ExamenDosClientesVista.ProductoCincoVistas());
            Application.Run(new ExamenDosClientesVista.ProductosSeisVistas());
            Application.Run(new ExamenDosClientesVista.ClientesSieteVistas());
        }
    }
}