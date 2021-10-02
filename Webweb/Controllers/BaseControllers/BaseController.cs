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
using Webweb.Filters;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.BaseControllers
{
    [Route("api")]
    public class BaseController<
        TISpecificUnitOfWork,
        TModel> : Controller
        where TModel : class, IBaseModel
    {
        protected IMapper _mapper { get; }
        protected TISpecificUnitOfWork _unit { get; }
        protected AllUnitOfWork _allunit { get; }

        public BaseController(
            IMapper mapper
            , TISpecificUnitOfWork unit
            , AllUnitOfWork allunit
        )
        {
            _mapper = mapper;
            _unit = unit;
            _allunit = allunit;
        }

        //[HttpGet("[controller]")]
        //[HttpGet("[controller]/all")]
        //public virtual async Task<IEnumerable<TModel>> GetAll()
        //{
        //    return await _allunit.GetRepo<IBaseRepo<TModel>>().GetAllAsync();
        //}

        [HttpPost("[controller]/add")]
        [ValidModelFilter]
        public virtual async Task<int> Add([FromBody] TModel model)
        {
            var entity = await _allunit.GetRepo<IBaseRepo<TModel>>().AddAsync(model);
            await _allunit.SaveAsync();
            return entity.ID;
        }

        [HttpPost("[controller]/addrange")]
        [ValidModelFilter]
        public virtual async Task<int> AddRange([FromBody] IEnumerable<TModel> models)
        {

            await _allunit.GetRepo<IBaseRepo<TModel>>().AddRangeAsync(models);
            var asd = await _allunit.SaveAsync();
            return asd;
        }

        [HttpGet("[controller]/get/{id}")]
        public virtual async Task<TModel> GetByID(int id)
        {
            return await _allunit.GetRepo<IBaseRepo<TModel>>().GetByIDAsync(id);
        }

        [HttpPost("[controller]/update")]
        [ValidModelFilter]
        public virtual async Task<int> Update([FromBody] TModel model)
        {

            await _allunit.GetRepo<IBaseRepo<TModel>>().Update(model);
            return await _allunit.SaveAsync();
        }

        [HttpPost("[controller]/updaterange")]
        [ValidModelFilter]
        public virtual async Task<int> UpdateRange([FromBody] IEnumerable<TModel> models)
        {
            await _allunit.GetRepo<IBaseRepo<TModel>>().UpdateRange(models);
            return await _allunit.SaveAsync();
        }

        [HttpGet("[controller]/remove/{ID}")]
        public virtual async Task<int> Remove(int ID)
        {
            await _allunit.GetRepo<IBaseRepo<TModel>>().RemoveByIDAsync(ID);
            return await _allunit.SaveAsync();
        }
    }
}
