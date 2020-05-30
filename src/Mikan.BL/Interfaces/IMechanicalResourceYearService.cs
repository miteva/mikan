using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IMechanicalResourceYearService
  {
    void AddOrUpdateAction(MechanicalResourceByYear action);
    List<MechanicalResourceByYear> GetAll();
    MechanicalResourceByYear GetById(int id);
    void Delete(int id);
  }
}
