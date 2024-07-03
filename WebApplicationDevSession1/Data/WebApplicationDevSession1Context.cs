using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationDevSession1.Models;

namespace WebApplicationDevSession1.Data
{
    public class WebApplicationDevSession1Context : DbContext
    {
        public WebApplicationDevSession1Context (DbContextOptions<WebApplicationDevSession1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationDevSession1.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
