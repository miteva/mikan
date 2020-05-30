using Mikan.BL.Interfaces;
using Mikan.DAL;
using Mikan.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikan.BL
{
  public class ActionService : IActionService
  {
    private readonly IRepository<AgricultureAction> _actionRepository;
    public ActionService(IRepository<AgricultureAction> actionRepository)
    {
      _actionRepository = actionRepository;
    }

    public void AddOrUpdateAction(AgricultureAction action)
    {
      var entity = _actionRepository.GetByID(action.Id);
      if (entity != null)
      {
        _actionRepository.Detach(entity);
        _actionRepository.Update(action);
      }
      else
      {
        _actionRepository.Insert(action);
      }

      _actionRepository.Save();
    }

    public AgricultureAction GetById(int id)
    {
      return _actionRepository.GetByID(id);
    }

    public List<AgricultureAction> GetAll()
    {
      return _actionRepository.GetAll();
    }

    public void Delete(int id)
    {
      _actionRepository.Delete(id);
    }
  }
}
