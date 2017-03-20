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
        public Frame[] frames;
        Queue<string> queue; //queue of page ids 

        public Memory(int frameCount, string pagingScheme)
        {
            frames = new Frame[frameCount];
            scheme = pagingScheme;
            queue = new Queue<string>();

            if (scheme == "FIFO")
            {
                queue = new Queue<string>();
            }
            for(int i = 0; i < frames.Length; i++)
            {
                frames[i] = new Frame();
            }

        }

        public bool offer(Page aPage)  //true if there was swap , false it went in or was in already
        {
            if (scheme == "FIFO")
            {
               // if (!this.contains(aPage))
               if(!aPage.isLoaded) //page is not already loaded
                {               
                    foreach (Frame frame in frames)
                    {//free space
                        if (frame.isFree)
                        {
                            frame.put(ref aPage);
                            queue.Enqueue(aPage.id);
                            return false;
                        }                       
                    }
                    foreach (Frame frame in frames)
                    {//swap it with first up on queue
                        if (frame.getPage().id == queue.First())
                        {
                            queue.Dequeue();
                            frame.put(ref aPage);
                            queue.Enqueue(aPage.id);
                            return true;
                        }
                    }
                }                         
            }
            else // LRU
            {
                // if (!this.contains(aPage))
                if (!aPage.isLoaded) //page is not already loaded
                {
                    foreach (Frame frame in frames)
                    {//free space
                        if (frame.isFree)
                        {
                            frame.put(ref aPage);
                            queue.Enqueue(aPage.id);
                            return false;
                        }
                    }
                    int min = 9999999;
                    foreach (Frame frame in frames)
                    {
                        //get min frequency
                        if (frame.getPage().frequency < min)
                        {
                            min = frame.getPage().frequency;
                        }
                        //swap it with frame having page with lowest frequency
                    }
                    foreach (Frame frame in frames)
                    {
                        //swap it with frame having page with lowest frequency
                        if (frame.getPage().frequency == min)
                        {
                            frame.put(ref aPage);
                            return true;
                        }
                    }
                }
            }

            return false; //already loaded
        }
        /*
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
        }*/
    }
}
