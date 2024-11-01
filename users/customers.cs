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
    public enum _Gender { Male,Female }
    [Table("customers")]
    public class customers
    {
        [Key]
        public int customer_id { get; set; }

        [Required]
        public string customer_name { get; set; }

        public string customer_img { get; set; }
        [Required]
        public string customer_username { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string customer_email { get; set; }
        [Required]
        [DataType(DataType.Password)]   
        public string customer_password { get; set; }
        [Required]
        public _Gender customer_gender { get; set; }                             
        public DateTime? customer_birth { get; set; }

        public ICollection<orders> orders { get; set; }
    }
}
