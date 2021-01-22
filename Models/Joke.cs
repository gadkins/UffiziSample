using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public class joke
    {
        public int id { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
