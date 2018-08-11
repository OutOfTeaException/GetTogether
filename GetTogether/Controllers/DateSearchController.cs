using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetTogether.Data;
using GetTogether.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateSearchController : Controller
    {
        private readonly GetTogetherContext dbContext;

        public DateSearchController(GetTogetherContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("")]
        public string Get()
        {
            return "Hallo";
        }

        [HttpGet("groups/{userId}")]
        public ActionResult<IEnumerable<Group>> GetGroups(int userId)
        {
            var groups = dbContext.Users.SingleOrDefault(u => u.Id == userId)?.Groups.Select(g => g.Group)
            .Select(g => new ViewModels.Group
            {
                Id = g.Id,
                Name = g.Name
            })
            .ToList();
            
            if (groups == null)
            {
                return Ok(Enumerable.Empty<Group>());
            }
            
            return Ok(groups);
        }

        // public void GetOpenDateSearches(int groupId)
        // {

        // }
    }
}