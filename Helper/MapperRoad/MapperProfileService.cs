using AutoMapper;
using Business.Config;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.MapperRoad
{
    public class MapperProfileService
    {
        public MapperProfileService(WebApplication) 
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            
        }

        
    }
}
