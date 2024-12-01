namespace Musical
{
    internal class Bass : Music
    {
        private Dictionary<int, int> frequencies;
        public Bass(char note, Dictionary<int, int> frequencies) :Music(note)
        {

        }
    }
}