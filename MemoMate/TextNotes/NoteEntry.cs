using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    public class NoteEntry
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Font Font { get; set; }
        public Color Color { get; set; }
        public int Size { get; set; }
        private static int idCounter = 0;
        public NoteEntry(string Name,DateTime Date, string Text, Font font, Color color,int size)
        {
            this.Name = Name;
            this.Date = Date;
            this.Text = Text;
            this.Id = idCounter++;
            Color = color;
            Font = font;
            Size = size;
        }
    }
}
