using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;

namespace Coding_Test.Controllers
{
    [Route("backend/question/[controller]")]
    [ApiController]
    public class ThreeController : ControllerBase
    {
        public List<Three> threes = new List<Three>()
        {
            new Three()
            {
                id = 800728,
                category = 4,
                items = new List<Item>()
                {
                    new Item()
                    {
                        id = 800728,
                        category = 4,
                        title = "Incredible Steel Salad",
                        description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                        footer = "Incredible",
                        createdAt = "2021-06-28T10:59:47.2135292+00:00"
                    },
                    new Item()
                    {
                        id = 800728,
                        category = 4,
                        title = "Practical Frozen Ball",
                        description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                        footer = "Ergonomic",
                        createdAt = "2021-06-28T10:59:47.2135292+00:00"
                    },
                    new Item()
                    {
                        id = 800728,
                        category = 4,
                        title = "Sleek Cotton Pants",
                        description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                        footer = "Handmade",
                        createdAt = "2021-06-28T10:59:47.2135292+00:00"
                    }
                },
                createdAt = "2021-06-28T10:59:47.2135292+00:00"
            },
        };
               

        [HttpGet]
        public IEnumerable<Item> Get()
        {
           
            var flattened = threes.SelectMany(p => p.items, (post, comment) => new
            Item{
                id = post.id,
                category = comment.category,
                title = comment.title,
                description = comment.description,
                footer = comment.footer,
                createdAt = comment.createdAt
            }).ToList();

            return flattened;
        }
    }
}
