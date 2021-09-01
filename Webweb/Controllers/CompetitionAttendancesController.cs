using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{

    public class CompetitionAttendancesController : BaseController<IUnitOfCompetition, CompetitionAttendance, IBaseAttendance>
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
        public async Task<int> AddIfUnique([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid && !await _unit.Attendances.AlreadyExistsAsync(model))
            {
                await Task.Run(() => _unit.Attendances.AddAsync(model));
                return await _unit.SaveAsync();

            }

            return -1;
        }

        [HttpPost("[controller]/remove")]
        public async Task<int> Remove([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid)
            {
                await _unit.Attendances.RemoveAsync(model);
                return await _unit.SaveAsync();
            }

            return -1;
        }
    }
}
