using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IResourceSubTypeService
  {
    void AddOrUpdateAction(ResourceSubType resource);
    List<ResourceSubType> GetAll();
    ResourceSubType GetById(int id);
    void Delete(int id);
  }
}
