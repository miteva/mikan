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
    [Route("api/mechanical-resource")]
    [ApiController]
    public class MechanicalResourceController : ControllerBase
  {
    private readonly IMechanicalResourceService _mechanicalResourceService;
    public MechanicalResourceController(IMechanicalResourceService mechanicalResourceService)
    {
      _mechanicalResourceService = mechanicalResourceService;
    }
    // GET: api/Action
    [HttpGet]
    public List<MechanicalResource> Get()
    {
      return _mechanicalResourceService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public MechanicalResource Get(int id)
    {
      return _mechanicalResourceService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] MechanicalResource value)
    {
      _mechanicalResourceService.AddOrUpdateAction(value);
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
      _mechanicalResourceService.Delete(id);
    }
  }
}
