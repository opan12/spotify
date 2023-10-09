using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Entities
{
    public class Note
    {
        public Note( string text)
        {
            Id = Guid.NewGuid();
            Text = text;

        }

        public Guid Id { get; set; }
        public string Text { get; set; }
       
    
    }
}
