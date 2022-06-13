﻿using System.ComponentModel.DataAnnotations;
namespace Drug_Shop
{
    class ReceiptProduct
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}