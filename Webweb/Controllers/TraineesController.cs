using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.BaseModels;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models;
using Webweb.Controllers.BaseControllers;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Units;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers
{
    public class TraineesController : BaseController<IUnitOfTrainee, Trainee>
    {
        public TraineesController(IMapper mapper, IUnitOfTrainee unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        //[HttpGet("")]
        //public async Task<IEnumerable<Trainee>> GetAllTrainees() {
        //    return await _unit.Trainees.GetAllAsync();
        //}
    }
}
