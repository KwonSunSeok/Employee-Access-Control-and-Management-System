using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace Access_Control_System
{
    public partial class RFID_Tag_Page : Form
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=access_control;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataSet ds = new DataSet();
        MySqlDataAdapter adt = new MySqlDataAdapter();

        string dataIn = "", temp = "";

        public RFID_Tag_Page()
        {
            InitializeComponent();
        }

        private Access_Control_System mainform = null;
        public RFID_Tag_Page(Access_Control_System form)
        {
            InitializeComponent();
            this.mainform = form;
        }

        private void RFID_Tag_Page_Load(object sender, EventArgs e)
        {
            avr_SerialPort_Re.PortName = mainform.combo_Port.Text;                     // PortName 선택
            avr_SerialPort_Re.BaudRate = Convert.ToInt32(mainform.combo_Bps.Text);     // Bps 선택
            avr_SerialPort_Re.Open();
        }

        /// <summary>
        /// 연결 된 PORT에서 DATA를 받아오는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avr_SerialPort_Re_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e)
        {
            dataIn = avr_SerialPort_Re.ReadExisting();
            temp += dataIn;

            // 데이터 판별 함수 실행
            this.Invoke(new EventHandler(DataIdentification));
        }
        /// <summary>
        /// 데이터 판별 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataIdentification(object sender, EventArgs e)
        {
            if(dataIn.Contains("\n") == true && mainform.manage_state == true)
            {
                try
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);
                    string rfid_comp = "";

                    mainform.rfid = temp.Substring(0, 14);   // 84 7a 12 b3 d7 << RFID 카드 정보 temp 변수에 저장

                    cmd.CommandText = "SELECT rfid_num FROM employee_info WHERE rfid_num='" + mainform.rfid + "'";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        rfid_comp = reader["rfid_num"].ToString();
                    }
                    reader.Close();

                    if (rfid_comp != "")
                    {
                        MessageBox.Show("이미 등록되어있는 카드입니다. \n다시 확인해주세요.");
                        rfid_comp = "";
                    }
                    else
                    {
                        rfid_comp = "";
                        this.DialogResult = DialogResult.OK;
                    }
                    temp = "";
                }
                catch
                {
                    MessageBox.Show("RFID 정보를 다시 입력해주세요.");
                }
            }
            else if(dataIn.Contains("\n") == true && mainform.manage_state == false)
            {
                try
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);
                    string rfid_comp = "";

                    mainform.rfid = temp.Substring(0, 14);   // 84 7a 12 b3 d7 << RFID 카드 정보 temp 변수에 저장

                    cmd.CommandText = "SELECT rfid_num FROM employee_info WHERE rfid_num='" + mainform.rfid + "'";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        rfid_comp = reader["rfid_num"].ToString();
                    }
                    reader.Close();

                    if (rfid_comp == "")
                    {
                        MessageBox.Show("등록되어있지 않은 카드입니다. \n다시 확인해주세요.");
                    }
                    else
                    {
                        rfid_comp = "";
                        this.DialogResult = DialogResult.OK;
                    }
                    temp = "";
                }
                catch
                {
                    MessageBox.Show("RFID 정보를 다시 입력해주세요.");
                }
            }
        }

        private void RFID_Tag_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            avr_SerialPort_Re.Close();
            conn.Close();
        }
    }
}
