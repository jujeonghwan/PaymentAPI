/*
 * PaymentDetail.cs
 * PaymentAPI
 * ASP.NET Core Web API CRUD with Angular 11 (https://www.youtube.com/watch?v=S5dzfuh3t8U)
 * 
 *  Revision History
 *      Jeonghwan Ju, 2022.01.15: Created
 */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }
                
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }
    }
}
