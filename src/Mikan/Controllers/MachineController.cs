using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mikan.BL.Interfaces;
using Mikan.DAL.Models;

namespace Mikan.Controllers
{
  [ApiController]
  [Route("[controller]/[action]")]
  public class MachineController : ControllerBase
  {
    private readonly IMachineService _machineService;
    public MachineController(IMachineService machineService)
    {
      _machineService = machineService;
    }

    [HttpGet]
    public IEnumerable<Machine> Index()
    {
      return _machineService.GetTopThreeMachines();
    }

    [HttpPost]
    public void Add(Machine machine)
    {
       _machineService.AddMachine(machine);
    }

  }
}
