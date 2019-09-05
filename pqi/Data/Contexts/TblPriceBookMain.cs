using System;
using System.Collections.Generic;

namespace pqi.Data.Contexts
{
    public partial class TblPriceBookMain
    {
        public int PartId { get; set; }
        public int? SectionId { get; set; }
        public int? OrderId { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string CostRule { get; set; }
        public string PriceRule { get; set; }
        public string ItemDiscountRule { get; set; }
        public double? Cost { get; set; }
        public double? Price { get; set; }
        public double? ItemDiscount { get; set; }
        public string Lbcode { get; set; }
        public double? Lbquantity { get; set; }
        public double? Lbcost { get; set; }
        public double? Lbprice { get; set; }
        public double? Lbdiscount { get; set; }
        public string Units { get; set; }
        public string GroupName { get; set; }
        public string SupplierName { get; set; }
        public string DocName { get; set; }
        public string Image { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsKit { get; set; }
        public bool? ViewInWeb { get; set; }
        public bool IsAssociated { get; set; }
        public bool? ShowInQuote { get; set; }
        public byte[] Ts { get; set; }
        public bool IsBaseModel { get; set; }
        public string Features { get; set; }
        public double? MaterialCost { get; set; }
        public double? StartingMargin { get; set; }
        public string SupplierCurrency { get; set; }
        public string LandedCost { get; set; }
        public string SellPrice { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public bool? Expense { get; set; }
        public short? Warehouse { get; set; }
        public bool? ShowInBom { get; set; }
        public string XlabourHrs { get; set; }
    }
}
