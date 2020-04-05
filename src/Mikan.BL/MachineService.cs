using System;
using System.Collections.Generic;
using System.Linq;
using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;

namespace Mikan.BL
{
  public class MachineService : IMachineService
  {
    private readonly IRepository<Machine> _machineRepository;
    public MachineService(IRepository<Machine> machineRepository)
    {
      _machineRepository = machineRepository;
    }

    public void AddMachine(Machine machine)
    {
      _machineRepository.Insert(machine);
      _machineRepository.Save();
    }

    public List<Machine> GetTopThreeMachines()
    {
      return  _machineRepository.GetWithRawSql("SELECT TOP(3) * FROM dbo.Machine order by Id desc").ToList();
    }

  }
}
