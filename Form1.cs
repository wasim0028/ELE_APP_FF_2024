using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELE_APP_FF_2024
{
    public partial class Form1 : Form
    {
        int a=0, b=0;
        public Form1()
        {
            InitializeComponent();
        }

        private readonly VizCon vc = new VizCon();

        public void getVizHost()
        {
            string[] dbName = ConfigurationManager.AppSettings.AllKeys.Where(key => key.StartsWith("VIZ")).Select(key => ConfigurationManager.AppSettings[key]).ToArray();
            cmbVizHost.Items.AddRange(dbName);
            cmbVizHost.SelectedIndex = 0;
        }

        public void getStates()
        {
            string con = ConfigurationManager.AppSettings["DB"];
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT CONST_ID, CONST_NAME, PARTY_NO, TOTAL_CONST_SEATS, CONST_NAME_BANGLA FROM ELE_APP_FF_2024 ORDER BY CONST_ID;", mycon);
            SqlDataReader myReader = cmd.ExecuteReader();
            StateList.Items.Clear();
            while (myReader.Read())
            {
                string scode = myReader.GetInt32(0).ToString(); 
                string sname = myReader.GetString(1);
                string spartyno = myReader.GetString(2);
                string stotal = myReader.GetString(3).ToString();
                string sname_b = myReader.GetString(4);
                string cmdval = scode + " | " + sname + " | " + spartyno + " | " + stotal + " | " + sname_b;
                StateList.Items.Add(cmdval);
            }
            mycon.Close();
        }

        public void getStateTally()
        {
            string con = ConfigurationManager.AppSettings["DB"];
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("SELECT PARTY, SEATS, SORT_ID FROM ELE_APP_FF_2024 WHERE CONST_ID ='" + slNo.Text + "' order by SORT_ID", mycon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStateTally.DataSource = dt;
            mycon.Close();
        }

        public void FillBoxes()
        {
            if (PartyNo.Text == "5") 
            { 
                tbParty1.Text = dgvStateTally.Rows[0].Cells[0].Value.ToString();
                tbParty2.Text = dgvStateTally.Rows[1].Cells[0].Value.ToString();
                tbParty3.Text = dgvStateTally.Rows[2].Cells[0].Value.ToString();
                tbParty4.Text = dgvStateTally.Rows[3].Cells[0].Value.ToString();
                tbParty5.Text = dgvStateTally.Rows[4].Cells[0].Value.ToString();
                tbParty5.Enabled = true;
                tbParty4.Enabled = true;
                tbSeats1.Text = dgvStateTally.Rows[0].Cells[1].Value.ToString();
                tbSeats2.Text = dgvStateTally.Rows[1].Cells[1].Value.ToString();
                tbSeats3.Text = dgvStateTally.Rows[2].Cells[1].Value.ToString();
                tbSeats4.Text = dgvStateTally.Rows[3].Cells[1].Value.ToString();
                tbSeats5.Text = dgvStateTally.Rows[4].Cells[1].Value.ToString();
                tbSeats5.Enabled = true;
                tbSeats4.Enabled = true;

            }
            if (PartyNo.Text == "4")
            {
                tbParty1.Text = dgvStateTally.Rows[0].Cells[0].Value.ToString();
                tbParty2.Text = dgvStateTally.Rows[1].Cells[0].Value.ToString();
                tbParty3.Text = dgvStateTally.Rows[2].Cells[0].Value.ToString();
                tbParty4.Text = dgvStateTally.Rows[3].Cells[0].Value.ToString();
                tbParty5.Enabled = false;
                tbParty4.Enabled = true;
                tbSeats1.Text = dgvStateTally.Rows[0].Cells[1].Value.ToString();
                tbSeats2.Text = dgvStateTally.Rows[1].Cells[1].Value.ToString();
                tbSeats3.Text = dgvStateTally.Rows[2].Cells[1].Value.ToString();
                tbSeats4.Text = dgvStateTally.Rows[3].Cells[1].Value.ToString();
                tbSeats5.Enabled = false;
                tbSeats4.Enabled = true;
            }
            if (PartyNo.Text == "3")
            {
                tbParty1.Text = dgvStateTally.Rows[0].Cells[0].Value.ToString();
                tbParty2.Text = dgvStateTally.Rows[1].Cells[0].Value.ToString();
                tbParty3.Text = dgvStateTally.Rows[2].Cells[0].Value.ToString();
                tbParty5.Enabled = false;
                tbParty4.Enabled = false;
                tbParty3.Enabled = true;
                tbSeats1.Text = dgvStateTally.Rows[0].Cells[1].Value.ToString();
                tbSeats2.Text = dgvStateTally.Rows[1].Cells[1].Value.ToString();
                tbSeats3.Text = dgvStateTally.Rows[2].Cells[1].Value.ToString();
                tbSeats5.Enabled = false;
                tbSeats4.Enabled = false;
                tbSeats3.Enabled = true;
            }
        }

        public void getSTotal()
        {
            if (PartyNo.Text == "5")
            {
                int tot5 = Convert.ToInt32(tbSeats1.Text) + Convert.ToInt32(tbSeats2.Text) + Convert.ToInt32(tbSeats3.Text) + Convert.ToInt32(tbSeats4.Text) + Convert.ToInt32(tbSeats5.Text);  
                tbSlot.Text = tot5.ToString();
            }
            if (PartyNo.Text == "4")
            {
                int tot4 = Convert.ToInt32(tbSeats1.Text) + Convert.ToInt32(tbSeats2.Text) + Convert.ToInt32(tbSeats3.Text) + Convert.ToInt32(tbSeats4.Text);
                tbSlot.Text = tot4.ToString();
            }
            if (PartyNo.Text == "3")
            {
                int tot3 = Convert.ToInt32(tbSeats1.Text) + Convert.ToInt32(tbSeats2.Text) + Convert.ToInt32(tbSeats3.Text);
                tbSlot.Text = tot3.ToString();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] host = cmbVizHost.Text.Split('|');
            tbIP.Text = host[1].Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getVizHost();
            getStates();
            FillBoxes();
            getSTotal();
            getStateTally();
            listGfxType.SelectedIndex = 0;
            StateList.SelectedIndex = 0;
            rdAllianceN.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SceneLoad();
        }

        private void StateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sinfo = StateList.Text.Split('|');
            slNo.Text = sinfo[0].Trim();
            StateEname.Text = sinfo[1].Trim();
            PartyNo.Text = sinfo[2].Trim();
            TotalStateSeats.Text = sinfo[3].Trim();
            StateNameBangla.Text = sinfo[4].Trim();
            getStateTally();
            FillBoxes();
            getSTotal();
            selectScence();
        }

        public void selectScence()
        {
            if (listGfxType.Text == "DVE" && slNo.Text == "1")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveNagAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve4AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "1")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "2")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "2")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "3")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "3")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "4")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "4")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "5")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "5")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "6")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "6")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "7")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "7")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "8")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "8")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "9")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "9")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "10")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "10")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "11")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "11")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "12")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "12")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "13")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "13")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "14")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "14")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "15")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "15")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "16")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "16")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "17")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "17")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "18")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "18")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "19")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "19")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "20")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "20")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "21")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "21")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "22")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "22")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "23")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "23")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "24")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "24")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "25")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "25")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "26")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveNagAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve4AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "26")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "27")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveNagAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve4AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "27")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "28")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveNagAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve4AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "28")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "29")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveMegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve5AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "29")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "30")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveMegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve5AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "30")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "31")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveMegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve5AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "31")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "32")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "32")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "33")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveMegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve5AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "33")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall5AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "34")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "34")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "35")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["DveNagAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve4AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "35")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall4AllianceNumbers"];
                }
            }
            if (listGfxType.Text == "DVE" && slNo.Text == "36")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3MegAlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Dve3AllianceNumbers"];
                }
            }
            else if (listGfxType.Text == "WALL" && slNo.Text == "36")
            {
                if (raAllianceP.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AlliancePie"];
                }
                if (rdAllianceN.Checked == true)
                {
                    lblScene.Text = ConfigurationManager.AppSettings["Wall3AllianceNumbers"];
                }
            }
        }

        public void Tally5_DataToViz()
        {
            string Ipath = ConfigurationManager.AppSettings["IMAGE_PATH"];
            string myip = tbIP.Text;
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";
            string stateselector = dpcmd + "lsbottomtallyselector = " + PartyNo.Text;
            string statename = dpcmd + "SName = " + StateNameBangla.Text;
            string sall1 = dpcmd + "Alliance1 = " + tbParty1.Text;
            string sall2 = dpcmd + "Alliance2 = " + tbParty2.Text;
            string sall3 = dpcmd + "Alliance3 = " + tbParty3.Text;
            string sall4 = dpcmd + "Alliance4 = " + tbParty4.Text;
            string sall5 = dpcmd + "Alliance5 = " + tbParty5.Text;
            string Img1 = dpcmd + "Image1 = " + Ipath + tbParty1.Text;
            string Img2 = dpcmd + "Image2 = " + Ipath + tbParty2.Text;
            string Img3 = dpcmd + "Image3 = " + Ipath + tbParty3.Text;
            string Img4 = dpcmd + "Image4 = " + Ipath + tbParty4.Text;
            string Img5 = dpcmd + "Image5 = " + Ipath + tbParty5.Text;
            string ImgVal = Img1 + ";" + Img2 + ";" + Img3 + ";" + Img4 + ";" + Img5;
            string sseats1 = dpcmd + "Total1 = " + tbSeats1.Text;
            string sseats2 = dpcmd + "Total2 = " + tbSeats2.Text;
            string sseats3 = dpcmd + "Total3 = " + tbSeats3.Text;
            string sseats4 = dpcmd + "Total4 = " + tbSeats4.Text;
            string sseats5 = dpcmd + "Total5 = " + tbSeats5.Text;
            string piedata5 = tbSeats1.Text + "," + tbSeats2.Text + "," + tbSeats3.Text + "," + tbSeats4.Text + "," + tbSeats5.Text + ";";
            string piedata = "0 RENDERER*TREE*$DS_PIE*FUNCTION*DataStorage*Data1 SET " + piedata5;
            string sResultVal = dpcmd + " ResultTotal = " + tbSlot.Text + "/" + TotalStateSeats.Text;
            string keyval = stateselector + ";" + statename + ";" + sall1 + ";" + sall2 + ";" + sall3 + ";" + sall4 + ";" + sall5 + ";" + sseats1 + ";" + sseats2 + ";" + sseats3 + ";" + sseats4 + ";" + sseats5 + ";" + sResultVal + ";" + ImgVal + ";" + piedata;
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*TALLY_DATA*ACTION*TRIGGER*KEY*$tally_key*VALUE SET " + keyval);
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE START");
        }

        public void Tally4_DataToViz()
        {
            string Ipath = ConfigurationManager.AppSettings["IMAGE_PATH"];
            string myip = tbIP.Text;
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";
            string stateselector = dpcmd + "lsbottomtallyselector = " + PartyNo.Text;
            string statename = dpcmd + "SName = " + StateNameBangla.Text;
            string sall1 = dpcmd + "Alliance1 = " + tbParty1.Text;
            string sall2 = dpcmd + "Alliance2 = " + tbParty2.Text;
            string sall3 = dpcmd + "Alliance3 = " + tbParty3.Text;
            string sall4 = dpcmd + "Alliance4 = " + tbParty4.Text;
            string Img1 = dpcmd + "Image1 = " + Ipath + tbParty1.Text;
            string Img2 = dpcmd + "Image2 = " + Ipath + tbParty2.Text;
            string Img3 = dpcmd + "Image3 = " + Ipath + tbParty3.Text;
            string Img4 = dpcmd + "Image4 = " + Ipath + tbParty4.Text;
            string ImgVal = Img1 + ";" + Img2 + ";" + Img3 + ";" + Img4 ;
            string sseats1 = dpcmd + "Total1 = " + tbSeats1.Text;
            string sseats2 = dpcmd + "Total2 = " + tbSeats2.Text;
            string sseats3 = dpcmd + "Total3 = " + tbSeats3.Text;
            string sseats4 = dpcmd + "Total4 = " + tbSeats4.Text;
            string piedata4 = tbSeats1.Text + "," + tbSeats2.Text + "," + tbSeats3.Text + "," + tbSeats4.Text + ";";
            string piedata = "0 RENDERER*TREE*$DS_PIE*FUNCTION*DataStorage*Data1 SET " + piedata4;
            string sResultVal = dpcmd + " ResultTotal = " + tbSlot.Text + "/" + TotalStateSeats.Text;
            string keyval = stateselector + ";" + statename + ";" + sall1 + ";" + sall2 + ";" + sall3 + ";" + sall4 + ";" + sseats1 + ";" + sseats2 + ";" + sseats3 + ";" + sseats4 + ";" + sResultVal + ";" + ImgVal + ";" + piedata;
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*TALLY_DATA*ACTION*TRIGGER*KEY*$tally_key*VALUE SET " + keyval);
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE START");
        }

        public void Tally3_DataToViz()
        {
            string Ipath = ConfigurationManager.AppSettings["IMAGE_PATH"];
            string myip = tbIP.Text;
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";
            string stateselector = dpcmd + "lsbottomtallyselector = " + PartyNo.Text;
            string statename = dpcmd + "SName = " + StateNameBangla.Text;
            string sall1 = dpcmd + "Alliance1 = " + tbParty1.Text;
            string sall2 = dpcmd + "Alliance2 = " + tbParty2.Text;
            string sall3 = dpcmd + "Alliance3 = " + tbParty3.Text;
            string Img1 = dpcmd + "Image1 = " + Ipath + tbParty1.Text;
            string Img2 = dpcmd + "Image2 = " + Ipath + tbParty2.Text;
            string Img3 = dpcmd + "Image3 = " + Ipath + tbParty3.Text;
            string ImgVal = Img1 + ";" + Img2 + ";" + Img3;
            string sseats1 = dpcmd + "Total1 = " + tbSeats1.Text;
            string sseats2 = dpcmd + "Total2 = " + tbSeats2.Text;
            string sseats3 = dpcmd + "Total3 = " + tbSeats3.Text;
            string piedata3 = tbSeats1.Text + "," + tbSeats2.Text + "," + tbSeats3.Text + ";";
            string piedata = "0 RENDERER*TREE*$DS_PIE*FUNCTION*DataStorage*Data1 SET " + piedata3;
            string sResultVal = dpcmd + " ResultTotal = " + tbSlot.Text + "/" + TotalStateSeats.Text;
            string keyval = stateselector + ";" + statename + ";" + sall1 + ";" + sall2 + ";" + sall3 + ";" + sseats1 + ";" + sseats2 + ";" + sseats3 + ";" + sResultVal + ";" + ImgVal + ";" + piedata;
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*TALLY_DATA*ACTION*TRIGGER*KEY*$tally_key*VALUE SET " + keyval);
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE START");
        }

        private void raAllianceP_CheckedChanged(object sender, EventArgs e)
        {
            selectScence();
        }

        public void SceneLoad()
        {
            string myip = tbIP.Text;
            string myscene = lblScene.Text.Trim();
            _ = vc.getVizdata(myip, "0 RENDERER SET_OBJECT SCENE*" + myscene);
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE SHOW 0.0");
            _ = vc.getVizdata(myip, "0 RENDERER*STAGE START");
            if(PartyNo.Text == "5")
            {
                Tally5_DataToViz();
            }
            if (PartyNo.Text == "4")
            {
                Tally4_DataToViz();
            }
            if (PartyNo.Text == "3")
            {
                Tally3_DataToViz();
            }
        }

        private void listGfxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectScence();
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked == true)
            {
                timer1.Enabled = true;
            }
           if (checkbox1.Checked == false)
           {
                timer1.Enabled = false;
           }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            b = StateList.Items.Count;
            StateList.SelectedIndex = a - 1;
            if (a == b)
            {
                a = 0;
            }
            SceneLoad();
        }
    }
}
