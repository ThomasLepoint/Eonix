using ApiEonix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEonix.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("GetById/{Id}")]
        public IActionResult Get(Guid Id)
        {
            Users user;
            using(DataContext context = new DataContext())
            {
                user = context.Users.Where(u => u.Id == Id).FirstOrDefault();
            }
            if (user == null) return BadRequest();
            else return Ok(user);
        }
        [HttpGet]
        public IActionResult Get(string name = null, string lastName = null)
        {
            List <Users> user;
            using (DataContext context = new DataContext())
            {
                IQueryable<Users> query = context.Users;
                user = GetQuery(query, name, lastName).ToList();
            }
            if (user.Count == 0) return BadRequest("User not Found");
            else return Ok(user);
        }
        private IQueryable<Users> GetQuery (IQueryable<Users> query,string name = null, string lastName = null)
        {
            if (name != null)
            {
                query = query.Where(u => u.Name.ToUpper().Contains(name.ToUpper()));
            }
            if(lastName != null)
            {
                query = query.Where(u => u.LastName.ToUpper().Contains(lastName.ToUpper()));
            }
            return query;
        }
        [HttpPost]
        public IActionResult Create(Users user)
        {
            using(DataContext context = new DataContext())
            {
                if(ModelState.IsValid)
                {
                    context.Users.Add(user);
                    try
                    {
                        context.SaveChanges();
                        return Ok(user.Id);
                    }
                    catch (DbUpdateException e)
                    {
                        return BadRequest(e.Message);
                    }
                }
                else
                {
                    return BadRequest("Model non valide");
                }
            }
        }
        [HttpPut]
        public IActionResult Update(Users _user)
        {
            using (DataContext context = new DataContext())
            {
                if(ModelState.IsValid)
                {
                    Users user = context.Users.Where(u => u.Id == _user.Id).FirstOrDefault();
                    user.LastName = _user.LastName;
                    user.Name = _user.Name;
                    try
                    {
                        context.SaveChanges();
                        return Ok(user);
                    }
                    catch(DbUpdateException e)
                    {
                        return BadRequest(e.Message);
                    }
                }
                else
                {
                    return BadRequest("Model non valide");
                }
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(Guid Id)
        {
            using (DataContext context = new DataContext())
            {
                Users user = context.Users.Where(u => u.Id == Id).FirstOrDefault();
                try
                {
                    Guid removedId = user.Id;
                    context.Remove(user);
                    context.SaveChanges();
                    return Ok(removedId);
                }
                catch(DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
    }
}
