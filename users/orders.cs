using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Test1.users
{
    public class orders
    {
        [Key]
        public int order_Id { get; set; }
        public int order_price {  get; set; }

        public string order_details {  get; set; }

        
        public int customer_id { get; set; }
        public customers customers { get; set; }


    }
}
