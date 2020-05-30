using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class MechanicalResourceService : IMechanicalResourceService
  {
    private readonly IRepository<MechanicalResource> _mechanicalResourceRepository;
    public MechanicalResourceService(IRepository<MechanicalResource> mechanicalResourceRepository)
    {
      _mechanicalResourceRepository = mechanicalResourceRepository;
    }

    public void AddOrUpdateAction(MechanicalResource action)
    {
      var entity = _mechanicalResourceRepository.GetByID(action.Id);
      if (entity != null)
      {
        _mechanicalResourceRepository.Detach(entity);
        _mechanicalResourceRepository.Update(action);
      }
      else
      {
        _mechanicalResourceRepository.Insert(action);
      }

      _mechanicalResourceRepository.Save();
    }

    public MechanicalResource GetById(int id)
    {
      return _mechanicalResourceRepository.GetByID(id);
    }

    public List<MechanicalResource> GetAll()
    {
      return _mechanicalResourceRepository.GetAll();
    }

    public void Delete(int id)
    {
      _mechanicalResourceRepository.Delete(id);
    }
  }
}
