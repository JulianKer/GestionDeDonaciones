using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeDonaciones.Entidades
{
    public class Donacion
    {

        public string _nombreDelDonante { get; set; }

        public string _motivoDeLaDonacion { get; set; }
        public double _montoDeDonacion { get; set; }



        public Donacion(string nombreDelDonante, string motivoDeLaDonacion, double montoDeDonacion)
        {
            _nombreDelDonante = nombreDelDonante;
            _motivoDeLaDonacion = motivoDeLaDonacion;
            _montoDeDonacion = montoDeDonacion;
        }
    }
}
