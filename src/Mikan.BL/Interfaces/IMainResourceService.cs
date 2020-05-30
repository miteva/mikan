using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IMainResourceService
  {
    void AddOrUpdateAction(MainResource action);
    List<MainResource> GetAll();
    MainResource GetById(int id);
    void Delete(int id);
  }
}
