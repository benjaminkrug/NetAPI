namespace Webapp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Npgsql;
    using Services;

    public class UserController : Controller
    {
        private readonly IDapper _dp;

        public UserController(IDapper dp)
        {
            _dp = dp;
        }

        [HttpGet("User")]
        public async Task<List<object>> Test()
        {
            var g = _dp.GetAll<object>("test.sql", null, CommandType.Text);

            Console.WriteLine(g);

            return g;
        }
        [HttpGet("Test")]
        public async Task<string> Test1()
        {
            return "hallo";
        }
    }
}
