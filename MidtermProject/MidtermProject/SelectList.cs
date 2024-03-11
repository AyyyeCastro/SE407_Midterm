using System.Collections.Generic;

namespace MidtermProject
{
    public class SelectList
    {
        private Dictionary<int, string> dictionary;
        private string v1;
        private string v2;

        public SelectList(Dictionary<int, string> dictionary, string v1, string v2)
        {
            this.dictionary = dictionary;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}