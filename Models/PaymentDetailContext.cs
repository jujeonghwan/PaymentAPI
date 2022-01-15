/*
 * PaymentDetailContext.cs
 * PaymentAPI
 * ASP.NET Core Web API CRUD with Angular 11 (https://www.youtube.com/watch?v=S5dzfuh3t8U)
 * 
 *  Revision History
 *      Jeonghwan Ju, 2022.01.15: Created
 */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
