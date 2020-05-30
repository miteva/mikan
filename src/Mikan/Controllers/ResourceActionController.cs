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
    [Route("api/resource-action")]
    [ApiController]
    public class ResourceActionController : ControllerBase
  {
    private readonly IResourceActionService _resourceActionService;
    public ResourceActionController (IResourceActionService resourceActionService)
    {
      _resourceActionService = resourceActionService;
    }
    // GET: api/Action
    [HttpGet]
    public List<ResourceAction> Get()
    {
      return _resourceActionService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public ResourceAction Get(int id)
    {
      return _resourceActionService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] ResourceAction value)
    {
      _resourceActionService.AddOrUpdateAction(value);
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
      _resourceActionService.Delete(id);
    }
  }
}
