using System.ComponentModel.DataAnnotations;
using GestionDeDonaciones.Entidades;

namespace GestionDeDonaciones.Models
{
    public class DonacionViewModel
    {

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string _nombreDelDonante { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 100 caracteres.")]
        public string _motivoDeLaDonacion { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(1, 1000000, ErrorMessage = "El monto debe ser mayor a 0 y menor o igual a 1.000.000")]
        public double _montoDeDonacion { get; set; }


        public DonacionViewModel() {}

        public DonacionViewModel(string nombreDelDonante, string motivoDeLaDonacion, int montoDeDonacion)
        {
            this._nombreDelDonante = nombreDelDonante;
            this._motivoDeLaDonacion = motivoDeLaDonacion;
            this._montoDeDonacion = montoDeDonacion;
        }

        internal Donacion convertiteAEntidad()
        {
            return new Donacion(this._nombreDelDonante, this._motivoDeLaDonacion, this._montoDeDonacion);
        }
    }
}
