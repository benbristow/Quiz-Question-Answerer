using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Question_Answerer.BingResponse
{

    public class Rootobject
    {
        public D d { get; set; }
    }

    public class D
    {
        public Result[] results { get; set; }
        public string __next { get; set; }
    }

    public class Result
    {
        public __Metadata __metadata { get; set; }
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DisplayUrl { get; set; }
        public string Url { get; set; }
    }

    public class __Metadata
    {
        public string uri { get; set; }
        public string type { get; set; }
    }

}
