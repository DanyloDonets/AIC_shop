using System;
using System.Collections.Generic;
namespace Drug_Shop
{
    class Receipt
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public List<ReceiptProduct> ReceiptProduct { get; set; }
    public List<Product> Products { get; set; }
}
}