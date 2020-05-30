using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class MainResourceService : IMainResourceService
  {
    private readonly IRepository<MainResource> _mainResourceRepository;
    public MainResourceService(IRepository<MainResource> mainResourceRepository)
    {
      _mainResourceRepository = mainResourceRepository;
    }

    public void AddOrUpdateAction(MainResource action)
    {
      var entity = _mainResourceRepository.GetByID(action.Id);
      if (entity != null)
      {
        _mainResourceRepository.Detach(entity);
        _mainResourceRepository.Update(action);
      }
      else
      {
        _mainResourceRepository.Insert(action);
      }

      _mainResourceRepository.Save();
    }

    public MainResource GetById(int id)
    {
      return _mainResourceRepository.GetByID(id);
    }

    public List<MainResource> GetAll()
    {
      return _mainResourceRepository.GetAll();
    }

    public void Delete(int id)
    {
      _mainResourceRepository.Delete(id);
    }
  }
}
