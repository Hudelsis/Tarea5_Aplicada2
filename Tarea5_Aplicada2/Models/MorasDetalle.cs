using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Tarea5_Aplicada2.Validations;


namespace Tarea5_Aplicada2.Models
{
    public class MorasDetalle
    {
        [Key]
        public int MoraDetalleId { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public decimal Monto { get; set; }

        public MorasDetalle()
        {
            MoraDetalleId = 0;
            MoraId = 0;
            PrestamoId = 0;
            Monto = 0;
        }

        public MorasDetalle(int moraId, int prestamoId, decimal monto)
        {
            MoraDetalleId = 0;
            MoraId = moraId;
            PrestamoId = prestamoId;
            Monto = monto;
        }
    }
}
