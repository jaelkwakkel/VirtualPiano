using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Key
    {
        public char KeyBind { get; set; }

        public Key(char keyBind)
        {
            KeyBind = keyBind;
        }
    }
}
