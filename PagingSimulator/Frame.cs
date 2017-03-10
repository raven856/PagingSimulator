using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingSimulator
{
    class Frame
    {
        public bool isFree = true;
        private Page page;

        public Frame()
        {
            //empty
        }
        public Frame(Page aPage)
        {
            page = aPage;
            isFree = false;
        }
        public Page getPage()
        {
            return page;
        }
        public void put(Page aPage)
        {
            page = aPage;
            isFree = false;
        }
    }
}
