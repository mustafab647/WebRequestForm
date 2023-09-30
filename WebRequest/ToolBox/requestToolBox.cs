using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.Core;
using Windows.Security.Authentication.Web.Provider;
using WRWebRequest;

namespace WebRequest.ToolBox
{
    public partial class requestToolBox : UserControl
    {
        public requestToolBox()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            stripProgress.Value = 0;
            WRWebRequest.WebRequest<object, object> webRequest = new WRWebRequest.WebRequest<object, object>();
            webRequest.Url = this.reqTextBoxUrl.Text ?? "";
            webRequest.QueryParams = reqParams();
            webRequest.Headers = reqHeader();
            string webMethod = cmbReqMethod.Text;

            if (webMethod.Equals("Get", StringComparison.OrdinalIgnoreCase))
                webRequest.HttpMethod = System.Net.Http.HttpMethod.Get;
            else if (webMethod.Equals("Post", StringComparison.OrdinalIgnoreCase))
                webRequest.HttpMethod = HttpMethod.Post;
            else if (webMethod.Equals("Put", StringComparison.OrdinalIgnoreCase))
                webRequest.HttpMethod = HttpMethod.Put;
            else if (webMethod.Equals("Delete", StringComparison.OrdinalIgnoreCase))
                webRequest.HttpMethod = HttpMethod.Delete;
            else if (webMethod.Equals("Head", StringComparison.OrdinalIgnoreCase))
                webRequest.HttpMethod = HttpMethod.Head;
            stripProgress.Value = 25;
            webRequest.Send();
            stripProgress.Value = 50;
            setResponse(webRequest.Response);
            stripProgress.Value = 75;
            if (webRequest.Response.StatusCode == System.Net.HttpStatusCode.OK)
                statusStrip1.BackColor = Color.AliceBlue;
            else if ((int)webRequest.Response.StatusCode >= 400 && (int)webRequest.Response.StatusCode <= 599)
                statusStrip1.BackColor = Color.Red;
            else
                statusStrip1.BackColor = Color.Yellow;
            stripProgress.Value = 100;
        }

        private async void setResponse<TResponse, TError>(WRWebRequest.WebResponse<TResponse, TError> webResponse) where TResponse : class, new() where TError: class, new()
        {
            this.respTextBox.Text = webResponse.ResponseText;
            try
            {
                Microsoft.Web.WebView2.Core.CoreWebView2Environment coreWebView2Environment = Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync().Result;
                //Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView2 = new();
                await this.responseWebView.EnsureCoreWebView2Async(coreWebView2Environment);

                this.responseWebView.CoreWebView2.NavigateToString(webResponse.ResponseText);
            }
            catch(Exception) { }
            this.webStatusLbl.Text = $"{webResponse.StatusCode}-{webResponse.StatusDescription}";
            this.webWaitTimelbl.Text = webResponse.TimeSpan.ToString();
            setRespHeader(webResponse.Headers);
        }
        private void setRespHeader(Dictionary<string, string> headers)
        {
            if (headers == null)
                return;
            foreach (KeyValuePair<string, string> kvp in headers)
            {
                this.respHeaderDataTable.Rows.Add(kvp.Key, kvp.Value);
            }
        }
        private Dictionary<string, string> reqParams()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            DataGridViewRowCollection rows = this.reqParamsDataTable.Rows;
            if (rows.Count == 1)
                return result;
            foreach (DataRow row in rows)
            {
                bool enable = Convert.ToBoolean(row["Enable"]);
                if (enable)
                {
                    string key = row["Key"].ToString();
                    string value = row["Value"].ToString();
                    result.Add(key, value);
                }
            }
            return result;
        }
        private Dictionary<string, string> reqHeader()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            DataGridViewRowCollection rows = this.headGridDataTable.Rows;

            if (rows.Count == 1)
                return result;
            foreach (DataRow row in rows)
            {
                bool enable = Convert.ToBoolean(row["Enable"]);
                if (enable)
                {
                    string key = row["Key"].ToString();
                    string value = row["Value"].ToString();
                    result.Add(key, value);
                }
            }
            return result;
        }
    }
}
