using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingSimulator
{
    class Memory
    {
        string scheme; //FIFO(Queue) or LRU(Frequency)
        Frame[] frames;
        Queue<string> queue; //queue of page ids 

        public Memory(int frameCount, string pagingScheme)
        {
            frames = new Frame[frameCount];
            scheme = pagingScheme;

            if (scheme == "FIFO")
            {
                queue = new Queue<string>();
            }

        }

        public bool offer(Page aPage)
        {
            if (scheme == "FIFO")
            {
                if (!this.contains(aPage))
                {
                    queue.Enqueue(aPage.id);

                    foreach (Frame frame in frames)
                    {
                        if (frame.isFree)
                        {
                            frame.put(aPage);
                        }
                        else if (frame.getPage().id == queue.Dequeue())
                        {
                            frame.put(aPage);
                        }
                    }
                    return true;
                }                         
            }
            else // LRU
            {

            }

            return false;
        }

        private bool contains(Page aPage)
        {
            foreach (Frame frame in frames)
            {
                if (!frame.isFree) { 
                    if (frame.getPage() == aPage)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
