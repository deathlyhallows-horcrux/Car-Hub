using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHub.Models
{
     [Table("Models")] //not a good practice to use data annotations
    public class ModelResource
    {       
        public int Id { get; set; }

        public string Name { get; set; }


    }
}