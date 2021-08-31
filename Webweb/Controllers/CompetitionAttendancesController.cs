using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{

    public class CompetitionAttendancesController : BaseController<IUnitOfCompetition, CompetitionAttendance>
    {
        public CompetitionAttendancesController(IMapper mapper, IUnitOfCompetition unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        [HttpGet("[controller]/{eventID}")]
        public async Task<IEnumerable<CompetitionAttendance>> GetByEventID(int eventID)
        {
            return await _unit.Attendances.WhereAsync(x => x.EventID == eventID);
        }

        [HttpPost("[controller]/add")]
        public async Task<bool> AddIfUnique([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid && !await _unit.Attendances.AlreadyExistsAsync(model))
            {
                await Task.Run(() => _unit.Attendances.AddAsync(model));
                return await _unit.SaveAsync() > 0;

            }

            return false;
        }

        [HttpGet("[controller]/test")]
        public async Task<bool> testt()
        {
            return await _unit.Attendances.AlreadyExistsAsync(new CompetitionAttendance { EventID = 2, TraineeID = 1 });
        }

        [HttpPost("[controller]/remove")]
        public async Task<bool> Remove([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid)
            {
                await Task.Run(() => _unit.Attendances.RemoveAsync(model));
                return await _unit.SaveAsync() > 0;

            }

            return false;
        }
    }
}
