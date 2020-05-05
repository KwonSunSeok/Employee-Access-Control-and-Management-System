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
            avr_SerialPort_Re.PortName = mainform.combo_Port.Text;                      // PortName 선택
            avr_SerialPort_Re.BaudRate = Convert.ToInt32(mainform.combo_Bps.Text);      // Bps 선택
            avr_SerialPort_Re.Open();
        }

        /// <summary>
        /// 연결 된 PORT에서 DATA를 받아오는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avr_SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
        private void DataIdentification(object sender, EventArgs e)
        {
            if(dataIn.Contains("\n") == true)
            {

            }
        }




        private void RFID_Tag_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            avr_SerialPort_Re.Close();
        }
    }
}
