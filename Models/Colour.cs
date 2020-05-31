using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerAPI.Models
{
    public class Colour 
    {
        public int Id { get; set; }
        public string ColourName { get; set; }
    }
}