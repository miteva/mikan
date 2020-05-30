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
    [Route("api/main-resource")]
    [ApiController]
    public class MainResourceController : ControllerBase
  {
    private readonly IMainResourceService _mainResourceService;
    public MainResourceController(IMainResourceService mainResourceService)
    {
      _mainResourceService = mainResourceService;
    }
    // GET: api/Action
    [HttpGet]
    public List<MainResource> Get()
    {
      return _mainResourceService.GetAll();
    }

    // GET: api/Action/5
    [HttpGet("{id}")]
    public MainResource Get(int id)
    {
      return _mainResourceService.GetById(id);
    }

    // POST: api/Action
    [HttpPost]
    public void Post([FromBody] MainResource value)
    {
      _mainResourceService.AddOrUpdateAction(value);
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
      _mainResourceService.Delete(id);
    }
  }
}
