using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1MidSample {
    public partial class Sample1Com : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write(Request.Form.Get("tb_CellPhone")+"<br />");
            Response.Write(Request.Form.Get("tb_Ps") + "<br />");
            Response.Write(Request.Form.Get("rb_Gender") + "<br />");
            Response.Write(Request.Form.Get("tb_Num") + "<br />");
            Response.Write(Request.Form.Get("hd_Num") + "<br />");
            Response.Write(mt_2MD5(Request.Form.Get("tb_Num")) + "<br />");            
        }

        // To convert a plain-text string into a md5 string
        public string mt_2MD5(string s_Str) {
            System.Security.Cryptography.MD5 cryptoMD5 = System.Security.Cryptography.MD5.Create();
            byte[] ba_Bytes = System.Text.Encoding.UTF8.GetBytes(s_Str);
            byte[] ba_Hash = cryptoMD5.ComputeHash(ba_Bytes);

            string s_Md5 = BitConverter.ToString(ba_Hash)
                .Replace("-", String.Empty)
                .ToUpper();
            return s_Md5;
        }
    }
}