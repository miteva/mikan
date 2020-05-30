using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IActionService
  {
    void AddOrUpdateAction(AgricultureAction action);
    List<AgricultureAction> GetAll();
    AgricultureAction GetById(int id);
    void Delete(int id);
  }
}
