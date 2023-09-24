using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebRequest.ToolBox
{
    public partial class requestToolBox : UserControl
    {
        public requestToolBox()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
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
            webRequest.Send();

            this.respTextBox.Text = webRequest.Response.ResponseText;
            this.webStatusLbl.Text = $"{webRequest.Response.StatusCode}-{webRequest.Response.StatusDescription}";
            this.webWaitTimelbl.Text = webRequest.Response.TimeSpan.ToString();
            setRespHeader(webRequest.Response.Headers);

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
