using System;
using System.Collections.Generic;
using System.Text;
using Mikan.DAL.Models;

namespace Mikan.BL.Interfaces
{
    public interface IMachineService
    {
        void AddMachine(Machine machine);
        List<Machine> GetTopThreeMachines();
    }
}
