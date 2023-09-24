using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WRWebRequest
{
    public class WebRequest<TResponse, TError> where TResponse : class, new() where TError : class, new()
    {
        #region Properties
        #region Public Properties
        [NotNull]
        public string Url { get; set; }
        public System.Net.Http.HttpMethod HttpMethod { get; set; }
        public Dictionary<string, string> QueryParams { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public WRWebRequest.WebResponse<TResponse, TError> Response { get; private set; }
        #endregion
        #endregion
        #region Contructors
        public WebRequest()
        {
            this.Headers = new Dictionary<string, string>();
            this.Response = new WebResponse<TResponse, TError>();
        }
        #endregion
        #region Methods
        #region Public Methods
        public void Send()
        {
            Send(null);
        }
        public void Send(object body)
        {
            string url = Url;
            System.Net.WebRequest webRequest = System.Net.HttpWebRequest.Create(url);
            webRequest.Method = this.HttpMethod.Method;
            webRequest.Headers = getHeaders(this.Headers);
            webRequest.ContentType = getContentType(this.Headers);

            if (body != null)
            {
                using (Stream stream = webRequest.GetRequestStream())
                {
                    string bodyStr = getBodyStr(body, webRequest.ContentType);
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(bodyStr);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            try
            {
                stopwatch.Start();
                using (System.Net.WebResponse response = webRequest.GetResponse())
                {
                    stopwatch.Stop();
                    try
                    {

                        this.Response.Response = getResponse(response);
                        if (this.Response == null)
                        {
                            this.Response.Error = getError(response);
                        }
                    }
                    catch (WebException webException)
                    {
                        WebResponse webResponse = webException.Response;
                        this.Response.Error = getError(webResponse);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (stopwatch.IsRunning)
                    stopwatch.Stop();
            }
            this.Response.TimeSpan = new TimeSpan(stopwatch.ElapsedMilliseconds);
        }
        #endregion

        #region Private Methods
        private System.Net.WebHeaderCollection getHeaders(Dictionary<string, string> headers)
        {
            System.Net.WebHeaderCollection result = new System.Net.WebHeaderCollection();
            if (headers?.Count == 0)
                return result;
            foreach (KeyValuePair<string, string> keyValuePairs in headers)
            {
                if (keyValuePairs.Key != "Content-Type")
                    result.Add(keyValuePairs.Key, keyValuePairs.Value);
            }
            return result;
        }
        private string getContentType(Dictionary<string, string> headers)
        {
            if (headers?.Count == 0)
                return null;
            if (!headers.Keys.Any(x => x.Equals("Content-Type", StringComparison.OrdinalIgnoreCase)))
                return null;
            return headers["Content-Type"];
        }
        private string getBodyStr(object body, string contentType)
        {
            if (contentType.Contains("json", StringComparison.OrdinalIgnoreCase))
            { return objectToJson(body); }
            else if (contentType.Contains("text", StringComparison.OrdinalIgnoreCase) && body is string)
            { return (string)body; }
            else if (contentType.Contains("xml", StringComparison.OrdinalIgnoreCase))
            { return objectToXml(body); }
            else
            { }
            return null;
        }
        private T getBodyObject<T>(string body, string contentType) where T : class, new()
        {
            if (contentType.Contains("json", StringComparison.OrdinalIgnoreCase))
            { return jsonToObject<T>(body.ToString()); }
            else if (contentType.Contains("xml", StringComparison.OrdinalIgnoreCase))
            {
                WRWebRequest.Helper.XmlSerializer<T> xmlSerializer = new Helper.XmlSerializer<T>();
                return xmlSerializer.DeSerialize(body);
            }
            else { }
            return null;
        }
        private string objectToXml(object obj)
        {
            if (typeof(object) == typeof(string))
                return (string)obj;
            string result = null;
            using (MemoryStream ms = new MemoryStream())
            {
                Helper.XmlSerializer<object> xmlSerializer = new Helper.XmlSerializer<object>();
                result = xmlSerializer.Serialize(obj);
            }
            return result;
        }
        private string objectToJson(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        private T jsonToObject<T>(string obj) where T : class, new()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(obj) ?? new T();
        }
        private TResponse getResponse(System.Net.WebResponse response)
        {
            TResponse result = null;
            HttpWebResponse webResponse = ((System.Net.HttpWebResponse)response);
            Stream stream = response.GetResponseStream();
            this.Response.Headers = getHeaders(response);
            StreamReader streamReader = new StreamReader(stream);
            string responseText = streamReader.ReadToEnd();
            this.Response.ResponseText = responseText;
            this.Response.StatusCode = webResponse.StatusCode;
            this.Response.StatusDescription = webResponse.StatusDescription;
            if (responseText != null)
            {
                try
                {
                    result = getBodyObject<TResponse>(responseText, response.ContentType);
                }
                catch { }
            }
            return result;
        }
        private TError getError(WebResponse webResponse)
        {
            TError result = null;
            Stream stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string responseText = streamReader.ReadToEnd();
            this.Response.ResponseText = responseText;
            if (responseText != null)
            {
                try
                {
                    result = getBodyObject<TError>(responseText, webResponse.ContentType);
                }
                catch { }
            }
            return result;
        }
        private Dictionary<string, string> getHeaders(WebResponse webResponse)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (webResponse.Headers?.Count == 0)
                return result;
            WebHeaderCollection headerCollection = webResponse.Headers;
            foreach (var keyValue in headerCollection.Keys)
            {
                string value = headerCollection.Get(keyValue.ToString());
                result.Add(keyValue.ToString(), value);
            }
            return result;
        }
        #endregion
        #endregion
    }
}
