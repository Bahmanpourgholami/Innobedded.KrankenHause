using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
    public class Appointment
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Fullname")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Reserve Date")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime ReserveDate { get; set; }

        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Display(Name = "Message")]
        [MaxLength(350)]
        public string Description { get; set; }
    }
}
