using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using burgershackApi.Models;
using burgershackApi.Services;

namespace burgershackApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SidesController : ControllerBase
  {
    private readonly SidesService _ss;
    public SidesController(SidesService ss)
    {
      //dependency injection
      _ss = ss;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Side>> GetAll()
    {
      try
      {
        return Ok(_ss.Get());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Side> Get(int id)
    {
      try
      {
        return Ok(_ss.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Side> Create([FromBody] Side newData)
    {
      try
      {
        return Ok(_ss.Create(newData));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Side> Edit(int id, [FromBody] Side update)
    {
      try
      {
        update.Id = id;
        return Ok(_ss.Edit(update));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        return Ok(_ss.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}