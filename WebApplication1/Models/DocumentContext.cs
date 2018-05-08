using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DocumentContext : DbContext
    {

        public DocumentContext()
            : base("DefaultConnection")
        { }

        public DbSet<Document> Documents { get; set; }
    }
}