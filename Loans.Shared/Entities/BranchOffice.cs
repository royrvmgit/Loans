﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Loans.Shared.Entities
{
    public class BranchOffice
    {
        public int Id { get; set; }

        [Display(Name = "Sucursal")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Name { get; set; } = null!;

        public City? City { get; set; }

    }
}
