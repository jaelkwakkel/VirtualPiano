namespace Model
{
    public class Piano
    {
        public List<Key> Keys { get; set; }

        public Piano()
        {
            Keys = new();

            Octaves currentoctave = 0;
            Notes currentnote = Notes.C;
            char currentchar = (char)97;
            Boolean lastWasSharp = false;

            for (int i = 1; i <= 50; i++)
            {
                if (currentnote.ToString().Contains("sharp"))
                {
                    currentchar -= (char)32;
                }

                Keys.Add(new Key(currentoctave, currentnote, currentchar));

                currentnote++;
                currentchar++;

                if (currentnote.ToString().Contains("sharp"))
                {
                    currentchar--;
                    lastWasSharp = true;
                } else if(lastWasSharp == true)
                {
                    currentchar += (char)32;
                    lastWasSharp = false;
                }
                
                if (currentnote == Notes.Dflat)
                {
                    currentoctave++;
                    currentnote = Notes.A;
                }
            }
        }

        public void KeyDownEventHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}