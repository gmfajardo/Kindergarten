﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KindergartenAppService.Models
{
    public class InvoiceDetail:UniqueEntity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}