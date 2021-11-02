using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1MidSample {
    public partial class Sample2 : System.Web.UI.Page {
        public string[] sa_Type = new string[2] {"手機", "市話"};
        public string[,] sa_ZoneCode = new string[2,3] { {"0911", "0921", "0960"}, {"02", "04", "07"} };
        public string[] sa_City = new string[6] {"台北市","新北市","台中市","台中縣","高雄市","高雄縣"};

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack == false) {
                string s_Id = mt_GenVeriStr();
                lb_Id.Text = s_Id;
                hf_Id.Value = s_Id;


                // Add Type
                for (int i_Ct=0; i_Ct< sa_Type.Length; i_Ct++) {
                    ListItem o_It = new ListItem(sa_Type[i_Ct], sa_Type[i_Ct]);
                    ddl_Type.Items.Add(o_It);
                }

                mt_UpdateLayer();

                mt_ShowDes();
            }
        }

        // To generate a 4 digital number
        public string mt_GenVeriStr() {
            string s_Res = "";
            Random o_Ran = new Random();
            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                int i_Tmp = o_Ran.Next(0, 10);
                s_Res = s_Res + i_Tmp.ToString();
            }
            return s_Res;
        }


        public void mt_UpdateLayer(int i_Layer = 2) {
            if (i_Layer == 2) {
                // Add ZoneCode
                ddl_ZoneCode.Items.Clear();
                if (ddl_Type.SelectedValue == "手機") {
                    for (int i_Ct = 0; i_Ct < sa_ZoneCode.GetLength(1); i_Ct++) {
                        ListItem o_It = new ListItem(sa_ZoneCode[0, i_Ct], sa_ZoneCode[0, i_Ct]);
                        ddl_ZoneCode.Items.Add(o_It);
                    }
                }
                else {
                    for (int i_Ct = 0; i_Ct < sa_ZoneCode.GetLength(1); i_Ct++) {
                        ListItem o_It = new ListItem(sa_ZoneCode[1, i_Ct], sa_ZoneCode[1, i_Ct]);
                        ddl_ZoneCode.Items.Add(o_It);
                    }
                }
            }

            // Add City
            ddl_City.Items.Clear();
            //ddl_ZoneCode.SelectedValue
            bool b_IsFRow = false;
            int i_Row = -1;
            for (int i_Ct = 0; i_Ct < sa_ZoneCode.GetLength(1); i_Ct++) {
                if (sa_ZoneCode[0, i_Ct] == ddl_ZoneCode.SelectedValue) {
                    b_IsFRow = true;
                    break;
                }
            }

            for (int i_Ct = 0; i_Ct < sa_ZoneCode.GetLength(1); i_Ct++) {
                if (sa_ZoneCode[1, i_Ct] == ddl_ZoneCode.SelectedValue) {
                    i_Row = i_Ct;
                    break;
                }
            }


            if (b_IsFRow == true) {
                for (int i_Ct = 0; i_Ct < sa_ZoneCode.Length; i_Ct++) {
                    ListItem o_It = new ListItem(sa_City[i_Ct], sa_City[i_Ct]);
                    ddl_City.Items.Add(o_It);
                }
            }
            else {
                for (int i_Ct = i_Row * 2; i_Ct < (i_Row * 2) + 2; i_Ct++) {
                    ListItem o_It = new ListItem(sa_City[i_Ct], sa_City[i_Ct]);
                    ddl_City.Items.Add(o_It);
                }
            }
        }

        protected void ddl_Type_SelectedIndexChanged(object sender, EventArgs e) {
            mt_UpdateLayer();
        }

        protected void ddl_ZoneCode_SelectedIndexChanged(object sender, EventArgs e) {
            mt_UpdateLayer(1);
        }

        public void mt_ShowDes() {
            if (rb_Des.SelectedValue == "否") {
                tb_Des.Visible = false;
            }
            else {
                tb_Des.Visible = true;
            }
        }

        protected void rb_Des_SelectedIndexChanged(object sender, EventArgs e) {
            mt_ShowDes();
        }

        protected void btn_Submit_Click(object sender, EventArgs e) {
            lb_Msg.Text = hf_Id.Value + "<br />" +
                    ddl_Type.SelectedValue + "<br />" +
                    ddl_ZoneCode.SelectedValue + tb_Number.Text + "<br />" +
                    ddl_City.SelectedValue + tb_Add.Text + "<br />";
            if (rb_Des.SelectedValue =="是") {
                lb_Msg.Text += tb_Des.Text;
            }
        }
    }
}