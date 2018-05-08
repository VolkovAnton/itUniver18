using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication1.Models
{
    public class Document
    {
        // ID документа
        public int Id { get; set; }
        // название 
        public string Name { get; set; }
        // автор 
        public string Author { get; set; }
        // дата
        public DateTime Date { get; set; }
        


    }
}