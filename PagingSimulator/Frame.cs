using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingSimulator
{
    public class Frame
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
        public void put(ref Page aPage)
        {
            if (!isFree)
            {
                page.isLoaded = false;
            }
            page = aPage;
            aPage.isLoaded = true;
            isFree = false;
        }
    }
}
