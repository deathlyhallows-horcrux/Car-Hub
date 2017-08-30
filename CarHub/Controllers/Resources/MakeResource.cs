using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.ComponentModel.DataAnnotations;

namespace CarHub.Models
{
    public class MakeResource
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
        
        //instantiating inside the constructor so that we don't have to do it everytime we use it
        public MakeResource()
        {
            Models = new Collection<ModelResource>(); 
        }
    }
}