﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KindergartenAppService.Models
{
    public abstract class Item:UniqueEntity
    {
        [Required]
        [Display(Name ="Referencia",Prompt ="SRV-001")]
        public string Reference { get; set; }
        [Required]
        [Display(Name = "Descripción", Prompt = "Servicio de cuidade")]
        public string Description { get; set; }
        [Required]
        [Display(Name ="Precio",Prompt ="3,000.00")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}