using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PortlandTripper.Models;
using Microsoft.EntityFrameworkCore;

namespace PortlandTripper.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TripAdvisorController : ControllerBase
  {
    private PortlandTripperContext _db;

    public TripAdvisorController(PortlandTripperContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<TripAdvisor>> Get(string name, string address, string hours, int cost, string description)
    {
      var query = _db.TripAdvisor.AsQueryable(); 
      if(name !=null)
      {
        query = query.Where(entry=>entry.Name == name);
      }

      if(address !=null)
      {
        query = query.Where(entry=>entry.Address == address);
      }
        
        if(hours !=null)
      {
        query = query.Where(entry=>entry.Hours == hours);
      }
        if(cost !=0)
      {
        query = query.Where(entry=>entry.Cost == cost);
      }
      if(description !=null)
      {
        query = query.Where(entry=>entry.Description == description);
      }
      return query.ToList();
    }
    

    [HttpPost]
    public void Post([FromBody] TripAdvisor tripAdvisor)
    {
      _db.TripAdvisor.Add(tripAdvisor);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<TripAdvisor> Get(int id)
    {
        return _db.TripAdvisor.FirstOrDefault(entry => entry.TripAdvisorId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] TripAdvisor tripAdvisor)
    {
        tripAdvisor.TripAdvisorId = id;
        _db.Entry(tripAdvisor).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var tripToDelete = _db.TripAdvisor.FirstOrDefault(entry => entry.TripAdvisorId == id);
      _db.TripAdvisor.Remove(tripToDelete);
      _db.SaveChanges();
    }

  }
}
