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
            for(int i = 1; i <= 50; i++)
            {
                Keys.Add(new Key(currentoctave, currentnote, 'A'));
                currentnote++;
                if(currentnote == Notes.Dflat)
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