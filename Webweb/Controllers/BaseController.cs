using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Controllers.Interfaces;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Controllers
{
    [Route("api")]
    public class BaseController<
        TISpecificUnitOfWork,
        TModel> : Controller where TModel : class
    {
        protected IMapper _mapper { get; }
        protected TISpecificUnitOfWork _unit { get; }

        private IUnitOfWork _allunit { get; }

        public BaseController(
            IMapper mapper
            , TISpecificUnitOfWork unit
            , IUnitOfWork allunit
        )
        {
            _mapper = mapper;
            _unit = unit;
            _allunit = allunit;
        }

        [HttpGet("[controller]")]
        [HttpGet("[controller]/all")]
        public virtual async Task<IEnumerable<TModel>> GetAll()
        {
            return await _allunit.GetRepo<IBaseRepo<TModel>>().GetAllAsync();
        }



        //[HttpPost("[controller]/add")]
        //public virtual async Task<bool> AddIfUnique([FromBody] TModel model)
        //{
        //    if (ModelState.IsValid && _allunit.GetRepo<IGenericRepo<TModel>>().GetByModelAsync(model) == null)
        //    {

        //        await Task.Run(() => _allunit.GetRepo<IGenericRepo<TModel>>().AddAsync(model));
        //        return await _allunit.SaveAsync() > 0;

        //    }

        //    return false;
        //}
    }
}
