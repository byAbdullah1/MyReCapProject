
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
    }

    
}
