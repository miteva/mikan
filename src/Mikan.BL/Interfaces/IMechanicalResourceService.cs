using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IMechanicalResourceService
  {
    void AddOrUpdateAction(MechanicalResource action);
    List<MechanicalResource> GetAll();
    MechanicalResource GetById(int id);
    void Delete(int id);
  }
}
