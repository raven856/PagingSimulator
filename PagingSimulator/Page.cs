using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingSimulator
{
    public class Page
    {
        public string name;

        public string id;

        public bool isLoaded = false;

        public int frequency = 0;

        public Page(string identifier)
        {
            id = identifier;
            name = "page " + id;
        }
        public Page(string identifier, bool inMemory)
        {
            id = identifier;
            isLoaded = inMemory;
        }

    }
}
