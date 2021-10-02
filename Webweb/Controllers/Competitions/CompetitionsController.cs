using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Competitions;
using Webweb.Controllers.BaseControllers;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.Competitions
{
    //[Route("competitions")]
    public class CompetitionsController : BaseEventController<IUnitOfCompetition, Competition>
    {
        public CompetitionsController(IMapper mapper, IUnitOfCompetition unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }


        //[HttpGet("")]
        //[HttpGet("all")]
        //public async Task<IEnumerable<Competition>> GetAllEvents()
        //{
        //    return await _unit.Events.GetAllAsync();
        //}

        [HttpGet("[controller]/remove/{eventID}")]
        public override async Task<int> Remove(int eventID) {
            await _unit.Events.RemoveByIDAsync(eventID);
            _unit.Attendances.ClearAttendancesFromEvent(eventID);
            return await _unit.SaveAsync();
        }

        [HttpGet("[controller]/{eventID}/trainees")]
        public async Task<SortedTrainees> GetSortedTrainees(int eventID)
        {
            return await _unit.Events.GetSortedTraineesAsync(eventID);
        }

        // 2000-10-10T11:12:12
    }
}
