using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using Webweb.Controllers.Interfaces;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Controllers.BaseControllers
{
    [Route("api")]
    public class BaseController<
        TISpecificUnitOfWork,
        TModel,
        TIBaseModel> : Controller where TModel : class
    {
        protected IMapper _mapper { get; }
        protected TISpecificUnitOfWork _unit { get; }
        protected IUnitOfWork _allunit { get; }

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

        //private IBaseModelRepo<TModel, IBaseModel> GetRepo() {
        //    _allunit.GetRepo<IBaseModelRepo<TModel, IBaseModel>>();
        //}

        [HttpGet("[controller]")]
        [HttpGet("[controller]/all")]
        public virtual async Task<IEnumerable<TModel>> GetAll()
        {
            return await _allunit.GetRepo<IBaseModelRepo<TModel, TIBaseModel>>().GetAllAsync();
        }

        [HttpGet("[controller]/add")]
        public virtual async Task<int> AddAsync(TModel model) {
            await _allunit.GetRepo<IBaseModelRepo<TModel, TIBaseModel>>().AddAsync(model);
            return await _allunit.SaveAsync();
        }

        [HttpGet("[controller]/{id}")]
        public virtual async Task<TModel> GetByID(int id) {
            return await _allunit.GetRepo<IBaseModelRepo<TModel, TIBaseModel>>().GetByIDAsync(id);
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
