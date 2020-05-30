using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class ResourceActionService : IResourceActionService
  {
    private readonly IRepository<ResourceAction> _resourceActionRepository;
    public ResourceActionService(IRepository<ResourceAction> resourceActionRepository)
    {
      _resourceActionRepository = resourceActionRepository;
    }

    public void AddOrUpdateAction(ResourceAction action)
    {
      var entity = _resourceActionRepository.GetByID(action.Id);
      if (entity != null)
      {
        _resourceActionRepository.Detach(entity);
        _resourceActionRepository.Update(action);
      }
      else
      {
        _resourceActionRepository.Insert(action);
      }

      _resourceActionRepository.Save();
    }

    public ResourceAction GetById(int id)
    {
      return _resourceActionRepository.GetByID(id);
    }

    public List<ResourceAction> GetAll()
    {
      return _resourceActionRepository.GetAll();
    }

    public void Delete(int id)
    {
      _resourceActionRepository.Delete(id);
    }
  }
}
