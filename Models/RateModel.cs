using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KursyWalutNBP.Models
{
    public class RateModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Thb { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Usd { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Aud { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Hkd { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Cad { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Nzd { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Sgd { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Eur { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Huf { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Chf { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Gbp { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Uah { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Jpy { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Czk { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Dkk { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Isk { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Nok { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Sek { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Ron { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Bgn { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Try { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Ils { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Clp { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Php { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Mxn { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Brl { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Myr { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Idr { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Inr { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Krw { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Cny { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,8)")]
        public decimal Xdr { get; set; }
    }
}
