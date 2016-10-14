using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Planner.Model.Mapping;

namespace Planner.WebAPI.App_Start
{
    public static class AutoMappingConfig
    {
        public static void RegisterMap()
        {
            AutoMapping.Initialize();
        }
    }
}