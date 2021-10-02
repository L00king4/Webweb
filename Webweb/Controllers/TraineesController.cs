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
using Webweb.Filters;
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

        [HttpPost("[controller]/add")]
        [ValidModelFilter]
        public override async Task<int> Add([FromBody] Trainee model)
        {
            if (!await _unit.Trainees.AlreadyExistsAsync(model))
            {
                var entity = await _unit.Trainees.AddAsync(model);
                if (await _allunit.SaveAsync() > 0)
                {
                    return entity.ID;
                }
            }

            return -1;
        }

        [HttpGet("[controller]")]
        [HttpGet("[controller]/all")]
        public async Task<IEnumerable<Trainee>> GetAll() {
            return await _unit.Trainees.GetAllAsync();
        }
    }
}
