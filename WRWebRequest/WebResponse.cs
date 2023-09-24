using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace WRWebRequest
{
    public class WebResponse<TResponse,TError> where TResponse : class,new() where TError : class,new()
    {
        public TResponse Response { get; set; }
        public TError Error { get; set; }
        public string ContentType { get; set; }
        public Dictionary<string, string> Headers { get; internal set; }
        public string ResponseText { get; set; }
    }
}
