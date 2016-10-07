using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Planner.DAL.Models;
using Planner.Model.Common;


namespace Planner.Model.Mapping
{
    public static class AutoMapping
    {
        public static void Initialize()
        {
            //source to destination
            Mapper.CreateMap<CategoryPOCO, Category>().ReverseMap();
            Mapper.CreateMap<ICategory, Category>().ReverseMap();

            Mapper.CreateMap<NotePOCO, Note>().ReverseMap();
            Mapper.CreateMap<INote, Note>().ReverseMap();

            Mapper.CreateMap<PriorityPOCO, Priority>().ReverseMap();
            Mapper.CreateMap<IPriority, Priority>().ReverseMap();

            Mapper.CreateMap<ReminderPOCO, Reminder>().ReverseMap();
            Mapper.CreateMap<IReminder, Reminder>().ReverseMap();

            Mapper.CreateMap<TaskPOCO, DAL.Models.Task>().ReverseMap();
            Mapper.CreateMap<ITask, DAL.Models.Task>().ReverseMap();
        }
    }
}
