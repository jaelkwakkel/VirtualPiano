using System.Diagnostics;

namespace Model
{
    public class Piano
    {
        public List<Key> Keys { get; set; }

        /// <summary>
        /// Constructor for piano that creates 50 keys for itself.
        /// </summary>
        public Piano()
        {
            Keys = new();

            //Add the 50 keys to the piano
            Octaves currentoctave = 0;
            Notes currentnote = Notes.C;
            char currentchar = (char)97;
            Boolean lastWasSharp = false;

            for (int i = 1; i <= 48; i++)
            {
                //Make it use the +shift variant
                if (currentnote.ToString().Contains("sharp"))
                {
                    currentchar -= (char)32;
                }

                Keys.Add(new Key(currentoctave, currentnote, currentchar));

                currentnote++;
                currentchar++;

                //If the next note is sharp, stay on the same letter (a-A)
                if (currentnote.ToString().Contains("sharp"))
                {
                    currentchar--;
                    lastWasSharp = true;

                    //Make sure last one was sharp before going back to the small letter variant (A-a)
                    //Prevents making white keys the uppercase variant when a note has no sharp
                }
                else if (lastWasSharp == true)
                {
                    currentchar += (char)32;
                    lastWasSharp = false;
                }

                if (currentnote == Notes.Unknown)
                {
                    currentoctave++;
                    currentnote = Notes.A;
                }
            }
        }

        public void KeyDownHandler(char Key)
        {
            foreach (Key key in Keys)
            {
                if (key.KeyBind == Key)
                {
                    Debug.WriteLine($"Key with {key.KeyBind} got pressed by key {Key}");
                    key.PressedDown = true;
                }
            }
        }

        public void KeyUpHandler(char Key)
        {
            foreach (Key key in Keys)
            {
                if (key.KeyBind == Key)
                {
                    Debug.WriteLine($"Key with {key.KeyBind} got let go by key {Key}");
                    key.PressedDown = false;
                }
            }
        }
    }
}