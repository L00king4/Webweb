using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Units;

namespace Webweb.Controllers
{
    public class TraineesController : BaseController<IUnitOfTrainee, Trainee, >
    {
        public TraineesController(IMapper mapper, IUnitOfTrainee unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        //[HttpGet("")]
        //public async Task<IEnumerable<Trainee>> GetAllTrainees() {
        //    return await _unit.Trainees.GetAllAsync();
        //}

        [HttpPost("add")]
        public async void AddTrainee(Trainee model) {
            await Task.Run(() => _unit.Trainees.AddAsync(model)) ;
            await Task.Run(() => _unit.SaveAsync());
        }
    }
}
