using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class Requests
    {
        private List<Request> reqs;
        public Requests()
        {
            this.reqs = new List<Request>();
        }
        public Requests(List<Request> reqs)
        {
            this.reqs = reqs;
        }

        public void AddRequest(Request request)
        {
            this.reqs.Add(request);
        }
        public void PrintRequests()
        {
            foreach (var req in this.reqs)
            {
                Console.WriteLine(req.DisplayRequest());
            }
        }
    }
}
