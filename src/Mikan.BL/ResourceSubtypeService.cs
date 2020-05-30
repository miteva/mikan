using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class ResourceSubtypeService : IResourceSubTypeService
  {
    private readonly IRepository<ResourceSubType> _resourceSubTypeRepository;
    public ResourceSubtypeService(IRepository<ResourceSubType> resourceSubTypeRepository)
    {
      _resourceSubTypeRepository = resourceSubTypeRepository;
    }

    public void AddOrUpdateAction(ResourceSubType resource)
    {
      var entity = _resourceSubTypeRepository.GetByID(resource.Id);
      if (entity != null)
      {
        _resourceSubTypeRepository.Detach(entity);
        _resourceSubTypeRepository.Update(resource);
      }
      else
      {
        _resourceSubTypeRepository.Insert(resource);
      }

      _resourceSubTypeRepository.Save();
    }

    public ResourceSubType GetById(int id)
    {
      return _resourceSubTypeRepository.GetByID(id);
    }

    public List<ResourceSubType> GetAll()
    {
      return _resourceSubTypeRepository.GetAll();
    }

    public void Delete(int id)
    {
      _resourceSubTypeRepository.Delete(id);
    }
  }
}
