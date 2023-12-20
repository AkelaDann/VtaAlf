using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace VtaAlf.Mod
{
    // All the code in this file is included in all platforms.
    public class AlfajorMod 
    {
        [Key]
        public int ID { get; set; }
        public string Glosa { get; set; }
        public decimal Precio { get; set; }
        public string Tipo { get; set; }
        
    }
}
