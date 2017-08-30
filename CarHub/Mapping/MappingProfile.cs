using AutoMapper;
using CarHub.Models;

namespace CarHub.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //one directional map make -> makeresource
             CreateMap<Make, MakeResource>();
             CreateMap<Model, ModelResource>();
        }
    
    }
       
}