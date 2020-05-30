using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.BL.Interfaces
{
  public interface IResourceService
  {
    void AddOrUpdateAction(Resource resource);
    List<Resource> GetAll();
    Resource GetById(int id);
    void Delete(int id);
  }
}
