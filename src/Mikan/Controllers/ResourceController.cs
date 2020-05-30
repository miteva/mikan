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
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
  {
    private readonly IResourceService _resourceService;
    public ResourceController(IResourceService resourceService)
    {
      _resourceService = resourceService;
    }
    // GET: api/Action
    [HttpGet]
    public List<Resource> Get()
    {
      return _resourceService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public Resource Get(int id)
    {
      return _resourceService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] Resource value)
    {
      _resourceService.AddOrUpdateAction(value);
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
      _resourceService.Delete(id);
    }
  }
}
