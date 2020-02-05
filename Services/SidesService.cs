using System;
using System.Collections.Generic;
using burgershackApi.Models;
using burgershackApi.Repositories;

namespace burgershackApi.Services
{
  public class SidesService
  {
    private readonly SidesRepository _repo;
    public SidesService(SidesRepository sr)
    {
      _repo = sr;
    }


    public IEnumerable<Side> Get()
    {
      return _repo.Get();
    }

    public Side GetById(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null)
      {
        throw new Exception
        ("Invalid Id");
      }
      return exists;
    }

    internal Side Create(Side newData)
    {
      _repo.Create(newData);
      return newData;
    }

    internal Side Edit(Side update)
    {
      var exists = _repo.GetById(update.Id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Edit(update);
      return update;
    }

    internal String Delete(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}