using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Key
    {
        private Octaves _octave;
        public Notes _note;
        public Boolean PressedDown = false;
        public double Frequency;
        public char KeyBind { get; set; }

        public Key(Octaves octave, Notes note)
        {
            _octave = octave;
            _note = note;
            KeyBind = keyBind;
        }
    }
}
