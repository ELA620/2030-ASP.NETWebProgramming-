namespace PriceQuotation.Models
{
 public class PriceQuotationModel
 {
 [Required("Please enter a quotation price.")]
 [Range(1, 500 =
 "Quotation Price amount must be between 1 and 500.")]
 public decimal? Subtotal { get; set; }
 [Required("Please enter a subtotal number between 1 and 500.")]
 [Range(0.2, 20.0 =
 "Please enter a discount percent between 0.2 and 20.0.")]
 public decimal? DiscountPercent{ get; set; }
 [Required("Please enter a discount amount.")]
 [Range(1, 100 =
 "Discount Amount must be between 1 and 100.")]
 public int? Years { get; set; }
 public decimal? PriceQuotation()
 {
 int? Subtotal = 500;
 decimal? DiscountPercent = (500 / 20)-100;
 decimal? priceQuuotation = 0;
 for (int i = 0; i < price; i++)
 {
 priceQuotaion = (Subtotal/discountPercent)-discountAmount
 
 }
 return futureValue;
 }
 }
