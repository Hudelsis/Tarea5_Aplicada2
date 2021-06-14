﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tarea5_Aplicada2.Validations
{
    public class MontoValidacion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal cantidad = 0;
                try
                {
                    cantidad = Convert.ToDecimal(value);
                }
                catch
                {
                    return new ValidationResult("El monto debe ser un numero");
                }

                if (cantidad >= 0.1m)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("El monto debe mayor o igual a 0.1");
            }
            return new ValidationResult("Debes poner un Monto");
        }
    }
}
