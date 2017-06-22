using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{

    public class InstanceInfo1
    {
        [Required]
        [Range(1, 100)]
       
       [MaxLength(15, ErrorMessage = "Max length exceeded")]
        public int InstanceID { get; set; }
    }
    public class InstanceInfo
    {
    [Required]
        [Range(1,100)]
        [MaxLength(15,ErrorMessage="Max length exceeded")]
        public int InstanceID { get; set; }

         [Required]
        
        public string InstanceName { get; set; }

        public int VCPU { get; set; }
        public int DISK { get; set; }
        public string RAM { get; set; }
        public String TimeSinceCreated { get; set; }
    }
}
