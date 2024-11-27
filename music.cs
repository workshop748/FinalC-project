namespace Musical
{
   abstract class Music
    {
        private char note;


        public Music(char note)
        {
            this.note = note;
        }

        public char Note
        {
            get=> note;
        }

        //base clase called music



    }
}