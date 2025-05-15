using System.Reflection.Metadata.Ecma335;
using GestionDeDonaciones.Entidades;

namespace GestionDeDonaciones.Servicios
{

    public interface IDonacionServicio
    {
        List<Donacion> obtenerDonaciones();
        void registrarDonacion(Donacion nuevaDonacion);
    }

    public class DonacionServicio : IDonacionServicio
    {

        public static List<Donacion> misDonaciones = new List<Donacion>();
        public static double montoTotalDeLasDonaciones = 0.0;
        public static double calcularParticipacion(double monto)
        {
            if(DonacionServicio.montoTotalDeLasDonaciones == 0)
            {
                return 0.0;
            }

            return (monto / montoTotalDeLasDonaciones) * 100;
        }


        public List<Donacion> obtenerDonaciones()
        {
            return DonacionServicio.misDonaciones;
        }

        public void registrarDonacion(Donacion nuevaDonacion)
        {
            DonacionServicio.montoTotalDeLasDonaciones += nuevaDonacion._montoDeDonacion; 
            DonacionServicio.misDonaciones.Add(nuevaDonacion);
        }

    }
}
