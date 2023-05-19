using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    public class NoteEntry
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public NoteEntry(string Name,DateTime Date,string Text)
        {
            this.Name = Name;
            this.Date = Date;
            this.Text=Text;
        }
    }
}
