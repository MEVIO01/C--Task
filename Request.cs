using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class Request
    {
        private int[] req;

        public Request(int[] req)
        {
            this.req = req;
            SortRequest();
        }
        public Request()
        {
            this.req = new int[] { };
        }

        private void SortRequest()
        {
            Array.Sort(this.req);
        }
        public Request GetRequest()
        {
            return this;
        }
        public string DisplayRequest()
        {
            return string.Join(",", this.req);
        }
    }
}
