//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using WebEntities;
//using WebEntities.Db.Models;
//using Webweb.Models;
//using System.Linq;
//using System.Threading.Tasks;
//using System;
//using Webweb.Models.Main;
//using Webweb.DB;
//using Webweb.Controllers.Main.Services;
//using Webweb.Services.UnitsOfWork;
//using Webweb.Services.Interfaces;

//namespace Webweb.Controllers
//{
//    public class MainController : Controller
//    {
//        private readonly IMapper _mapper;
//        private readonly IUnitOfWork _uow;

//        public MainController(
//            IMapper mapper,
//            IUnitOfWork uow
//            )
//        {
//            _mapper = mapper;
//            _uow = uow;
//        }

//        [HttpGet("list/trainees")]
//        public IActionResult ListTrainees()
//        {
//            //ICollection<Trainee> trainees = _main.ListTrainees();
//            ICollection<TraineeViewModel> traineesModel = _mapper.Map<List<TraineeViewModel>>(trainees);
//            //IEnumerable<TraineeViewModel> traineesModel = _db.GetTrainees();
//            return View(traineesModel);
//        }

//        [HttpGet("list/events")]
//        public ICollection<Event> ListEvents(EventType? eventType)
//        {
//            ICollection<Event> events;
//            if (eventType == null || !Enum.IsDefined(typeof(EventType), eventType))
//            {
//                events = _main.ListEvents();
//            }
//            else
//            {
//                events = _main.ListEvents(eventType);
//            }


//            return events;
//        }

//        [HttpGet("add/eventtrainee")]
//        public async Task<bool> AddEventTrainee(AddEventTraineeModel model)
//        {
//            return await _main.AddEventTrainee(model);
//        }

//        [HttpGet("add/event")]
//        public async Task<bool> AddEvent(Event model)
//        {
//            return await _main.AddAndSaveEventAsync(model);
//        }

//        [HttpGet("add/payment")]
//        public bool Pay(PayModel model)
//        {
//            return _main.Pay(model);
//        }

//        private IActionResult Success()
//        {
//            return Ok("Success");
//        }
//        private IActionResult Failure()
//        {
//            return BadRequest("Failure");
//        }
//    }
//}
