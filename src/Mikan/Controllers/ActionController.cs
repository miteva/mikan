using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration;
using Mikan.BL;
using Mikan.BL.Interfaces;
using Mikan.DAL.Models;

namespace Mikan.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ActionController : ControllerBase
  {
    private readonly IActionService _actionService;
    public ActionController(IActionService actionService)
    {
      _actionService = actionService;
    }
    // GET: api/Action
    [HttpGet]
    public List<AgricultureAction> Get()
    {
      return _actionService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public AgricultureAction Get(int id)
    {
      return _actionService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] AgricultureAction value)
    {
      _actionService.AddOrUpdateAction(value);
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
      _actionService.Delete(id);
    }
  }
}
