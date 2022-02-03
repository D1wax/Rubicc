using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rubic.DbContext;
using Rubic.Models;
using Rubic.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        private MoneyBotContext _context;

        public MoneyController(MoneyBotContext context)
        {
            _context = context;
        }
        [HttpPost("add/{userId}")]
        public async Task<ActionResult> AddMoneyOperation( [FromQuery]int userId,[FromBody] MoneyOperation moneyOperation)
        {
            User user =_context.Users.FirstOrDefault(x => x.Id == userId);

            if (user == null) return NotFound();
            Money money = new Money()
            {
                Summ = moneyOperation.Summ,
                Operation = moneyOperation.Operation,
                Date = moneyOperation.Date,
            };

            _context.Add(money);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
