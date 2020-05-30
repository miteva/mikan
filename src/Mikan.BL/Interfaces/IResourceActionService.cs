using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IResourceActionService
  {
    void AddOrUpdateAction(ResourceAction action);
    List<ResourceAction> GetAll();
    ResourceAction GetById(int id);
    void Delete(int id);
  }
}
