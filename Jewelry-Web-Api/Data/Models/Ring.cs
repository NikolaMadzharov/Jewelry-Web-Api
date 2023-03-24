using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Jewelry_Web_Api.Data.Models
{
    public class Ring
    {
        [Key]
        public int Id { get; set; }

    

        public string? Name { get; set; }

   

        public string? Url { get; set; }

     

        public decimal? Price { get; set; }

      

        public string? Description { get; set; }

     

        public double? Size { get; set; }

       

        public string? Type { get; set; }

   


    }
}
