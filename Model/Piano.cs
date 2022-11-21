namespace Model
{
    public class Piano
    {
        public List<Key> Keys { get; set; }

        public Piano()
        {
            Keys = new();
            Keys.Add(new Key('A'));
            Keys.Add(new Key('B'));
        }

        public void KeyDownEventHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}