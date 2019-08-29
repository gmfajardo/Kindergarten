﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Models
{
    public class Invoice:UniqueEntity
    {
        [Display(Name = "Fecha de creación", Prompt = "")]
        public DateTime GeneratedDate { get; set; }
        [Display(Name = "Fecha de vencimiento", Prompt = "")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Niño", Prompt = "")]
        public Guid KidId { get; set; }
        [Display(Name = "Niño", Prompt = "")]
        public Kid Kid { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        [Display(Name = "Monto", Prompt = "3,000.00")]
        public decimal Price { get; set; }
        [Display(Name = "Estado", Prompt = "")]
        public InvoiceStatus Status { get; set; }
        [NotMapped]
        private string _month;
        [NotMapped]
        public string Month
        {
            get
            {
                int month = GeneratedDate.Month;
                switch (month)
                {
                    case 1: return "Enero";
                    case 2: return "Febrero";
                    case 3: return "Marzo";
                    case 4: return "Abril";
                    case 5: return "Mayo";
                    case 6: return "Junio";
                    case 7: return "Julio";
                    case 8: return "Agosto";
                    case 9: return "Septiembre";
                    case 10: return "Octubre";
                    case 11: return "Noviembre";
                    case 12: return "Diciembre";
                    default: return "";
                }
            }
            set { _month = value; }
        }

    }
}
