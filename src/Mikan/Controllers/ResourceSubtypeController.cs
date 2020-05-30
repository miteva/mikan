using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mikan.BL.Interfaces;
using Mikan.DAL.Models;

namespace Mikan.Controllers
{
    [Route("api/resource-sub-type")]
    [ApiController]
    public class ResourceSubtypeController : ControllerBase
  {
    private readonly IResourceSubTypeService _resourceSubtypeService;
    public ResourceSubtypeController(IResourceSubTypeService resourceSubtypeService)
    {
      _resourceSubtypeService = resourceSubtypeService;
    }
    // GET: api/Action
    [HttpGet]
    public List<ResourceSubType> Get()
    {
      return _resourceSubtypeService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public ResourceSubType Get(int id)
    {
      return _resourceSubtypeService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] ResourceSubType value)
    {
      _resourceSubtypeService.AddOrUpdateAction(value);
    }

    // PUT: api/Action/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      _resourceSubtypeService.Delete(id);
    }
  }
}
