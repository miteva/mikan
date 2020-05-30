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
    [Route("api/mechanical-resource-per-year")]
    [ApiController]
    public class MechanicalResourceYearController : ControllerBase
  {
    private readonly IMechanicalResourceYearService _mechanicalResourceYearService;
    public MechanicalResourceYearController(IMechanicalResourceYearService mechanicalResourceYearService)
    {
      _mechanicalResourceYearService = mechanicalResourceYearService;
    }
    // GET: api/Action
    [HttpGet]
    public List<MechanicalResourceByYear> Get()
    {
      return _mechanicalResourceYearService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public MechanicalResourceByYear Get(int id)
    {
      return _mechanicalResourceYearService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] MechanicalResourceByYear value)
    {
      _mechanicalResourceYearService.AddOrUpdateAction(value);
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
      _mechanicalResourceYearService.Delete(id);
    }
  }
}
