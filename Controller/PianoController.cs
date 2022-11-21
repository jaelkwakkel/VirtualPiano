using Model;

namespace Controller
{
    public class PianoController
    {
        public Piano Piano { get; set; }
        public static Piano CreatePiano()
        {
            Piano piano = new Piano();

            return piano;
        }
    }
}