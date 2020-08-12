using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlickrApp.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlickrApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        [HttpGet("FlickrCall")]
        public List<string> FlickrCall()
        {
            FlickrAPI flickr = new FlickrAPI();
            return flickr.GetFeed();
        }
    }
}