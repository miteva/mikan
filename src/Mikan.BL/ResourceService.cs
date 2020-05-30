using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class ResourceService : IResourceService
  {
    private readonly IRepository<Resource> _resourceRepository;
    public ResourceService(IRepository<Resource> resourceRepository)
    {
      _resourceRepository = resourceRepository;
    }

    public void AddOrUpdateAction(Resource resource)
    {
      var entity = _resourceRepository.GetByID(resource.Id);
      if (entity != null)
      {
        _resourceRepository.Detach(entity);
        _resourceRepository.Update(resource);
      }
      else
      {
        _resourceRepository.Insert(resource);
      }

      _resourceRepository.Save();
    }

    public Resource GetById(int id)
    {
      return _resourceRepository.GetByID(id);
    }

    public List<Resource> GetAll()
    {
      return _resourceRepository.GetAll();
    }

    public void Delete(int id)
    {
      _resourceRepository.Delete(id);
    }
  }
}
