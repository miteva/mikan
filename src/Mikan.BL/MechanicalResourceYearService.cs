using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class MechanicalResourceYearService : IMechanicalResourceYearService
  {
    private readonly IRepository<MechanicalResourceByYear> _mechanicalResourceByYearRepository;
    private readonly IRepository<MechanicalResource> _mechanicalResourceRepository;
    public MechanicalResourceYearService(IRepository<MechanicalResourceByYear> mechanicalResourceByYearRepository, IRepository<MechanicalResource> mechanicalResourceRepository)
    {
      _mechanicalResourceByYearRepository = mechanicalResourceByYearRepository;
      _mechanicalResourceRepository = mechanicalResourceRepository;
    }

    public void AddOrUpdateAction(MechanicalResourceByYear action)
    {
      var entity = _mechanicalResourceByYearRepository.GetByID(action.Id);

      if (entity != null)
      {
        _mechanicalResourceByYearRepository.Detach(entity);

        _mechanicalResourceByYearRepository.Update(action);
      }
      else
      {
        _mechanicalResourceByYearRepository.Insert(action);
      }

      _mechanicalResourceByYearRepository.Save();
    }

    public MechanicalResourceByYear GetById(int id)
    {
      return _mechanicalResourceByYearRepository.GetByID(id);
    }

    public List<MechanicalResourceByYear> GetAll()
    {
      return _mechanicalResourceByYearRepository.GetAll();
    }

    public void Delete(int id)
    {
      _mechanicalResourceByYearRepository.Delete(id);
    }
  }
}
