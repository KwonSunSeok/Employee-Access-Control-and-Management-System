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
    public partial class Access_Control_System : Form
    {
        //-----MySql Setup---------------------------------------------------------------------
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=access_control;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataSet ds = new DataSet();
        MySqlDataAdapter adt = new MySqlDataAdapter();
        string sql = "";                                    // MySql Command 문자열 저장 변수

        //------ATmega128A 데이터 통신 Variables-----------------------------------------------
        public string dataIn;                               // Add RS232C from ATMEGA128A
        public string temp = "";                            // dataIn변수가 잠시 머무는 곳

        //------Variables----------------------------------------------------------------------
        public string rfid = "";
        public bool manage_state = default;




        /// <summary>
        /// 폼 초기 설정
        /// </summary>
        public Access_Control_System()
        {
            InitializeComponent();
            getAvailablePorts();        // 사용 가능한 Port를 콤보박스 리스트에 ADD시키는 함수

            tabPage_Join.Enabled = false;
            gb_EmployeeJoin.Enabled = false;
            gb_EmployeeDel.Enabled = false;
        }

        /// <summary>
        /// 사용 가능한 Port를 콤보박스 리스트에 ADD시키는 함수
        /// </summary>
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            combo_Port.Items.AddRange(ports);
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
            dataIn = avr_SerialPort.ReadExisting();
            richTb_receiveData.Text += dataIn;
            richTb_receiveData.SelectionStart = richTb_receiveData.Text.Length;
            richTb_receiveData.ScrollToCaret();
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

        }

        /// <summary>
        /// Mysql에 데이터 저장
        /// </summary>
        private void EnterDataInMysql(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// 설정 페이지
        /// </summary>

        /// <summary>
        /// Port Open 버튼 클릭 시 SetUp
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (combo_Port.Text == "" || combo_Bps.Text == "")
                    richTb_receiveData.Text = "Please Select Port Setting!!";
                else
                {
                    avr_SerialPort.PortName = combo_Port.Text;                     // PortName 선택
                    avr_SerialPort.BaudRate = Convert.ToInt32(combo_Bps.Text);     // Bps 선택
                    avr_SerialPort.Open();
                    progBar_PortStatus.Value = 100;
                    label_ComPort.Text = "ON";

                    // Button & TextBox Enable, Disable Setup
                    btn_Send.Enabled = true;
                    btn_Clear.Enabled = true;
                    tb_SendData.Enabled = true;
                    btn_OpenPort.Enabled = false;
                    btn_ClosePort.Enabled = true;

                    tabPage_Join.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                richTb_receiveData.Text = "UnauthorizedAccessException Occurs!!";
            }
        }

        /// <summary>
        /// Port Close 버튼 클릭 시 SetUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClosePort_Click(object sender, EventArgs e)
        {
            avr_SerialPort.Close();
            progBar_PortStatus.Value = 0;
            label_ComPort.Text = "OFF";
            btn_Send.Enabled = false;
            btn_Clear.Enabled = true;
            tb_SendData.Enabled = false;
            btn_OpenPort.Enabled = true;
            btn_ClosePort.Enabled = false;
        }

        /// <summary>
        /// Send Button 클릭 시 텍스트 박스에 있는 명령을 ATMEGA128A로 통신
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Send_Click(object sender, EventArgs e)
        {
            string command = tb_SendData.Text;

            if (command.Length > 0)
            {
                avr_SerialPort.WriteLine(command);
                tb_SendData.Text = "";
            }
        }

        /// <summary>
        /// Clear 버튼 클릭 시 텍스트 박스 내용 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            richTb_receiveData.Text = "";
        }

        /// <summary>
        /// Send 텍스트 박스에서 엔터 입력 시 send 버튼 클릭 함수 동작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_SendData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_Send.PerformClick();
        }




        /// <summary>
        /// 사원 관리 페이지
        /// </summary>

        /// <summary>
        /// 등록 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Join_Click(object sender, EventArgs e)
        {
            gb_EmployeeJoin.Enabled = true;
            gb_EmployeeDel.Enabled = false;
        }
        /// <summary>
        /// 삭제 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            gb_EmployeeDel.Enabled = true;
            gb_EmployeeJoin.Enabled = false;
        }
        /// <summary>
        /// 사원 정보 입력란에서 확인 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OkJoin_Click(object sender, EventArgs e)
        {
            if (tb_EmployeeName.Text != "" && tb_EmployeeNum.Text != "" && tb_Birth.Text != "" && tb_Gender.Text != "")
            {
                avr_SerialPort.Close();
                manage_state = true;
                RFID_Tag_Page dlgRFID = new RFID_Tag_Page(this);
                dlgRFID.ShowDialog(this);
                avr_SerialPort.Open();

                if (dlgRFID.DialogResult == DialogResult.OK)
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);
                    string gender = "";
                    
                    if(tb_Gender.Text == "1" || tb_Gender.Text == "3")
                    {
                        gender = "M";
                    }
                    else if(tb_Gender.Text == "2" || tb_Gender.Text == "4")
                    {
                        gender = "W";
                    }

                    sql = "INSERT INTO employee_info (rfid_num, emp_num, emp_name, emp_gender, emp_birth) VALUES ('";
                    sql += rfid + "', '" + tb_EmployeeNum.Text + "', '" + tb_EmployeeName.Text + "', '" + gender + "', '" + tb_Birth.Text + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    tb_EmployeeNum.Text = ""; tb_EmployeeName.Text = ""; tb_Gender.Text = ""; tb_Birth.Text = "";
                    rb_State.Text = "사원 정보가 정상적으로 등록되었습니다.";
                }
            }
            else
            {
                MessageBox.Show("사원 정보를 모두 입력해주세요.");
            }
            
        }
        /// <summary>
        /// 사원 정보 삭제란에서 확인 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OkDel_Click(object sender, EventArgs e)
        {
            if (tb_EmployeeNameDel.Text != "" && tb_EmployeeNumDel.Text != "" && tb_BirthDel.Text != "" && tb_GenderDel.Text != "")
            {
                avr_SerialPort.Close();
                manage_state = false;
                RFID_Tag_Page dlgRFID = new RFID_Tag_Page(this);
                dlgRFID.ShowDialog(this);
                avr_SerialPort.Open();

                if (dlgRFID.DialogResult == DialogResult.OK)
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);
                    string gender = "";
                    bool info_match = false;

                    if (tb_GenderDel.Text == "1" || tb_GenderDel.Text == "3")
                    {
                        gender = "M";
                    }
                    else if (tb_GenderDel.Text == "2" || tb_GenderDel.Text == "4")
                    {
                        gender = "W";
                    }

                    sql = "SELECT * FROM employee_info WHERE rfid_num='";
                    sql += rfid + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        if (tb_EmployeeNumDel.Text == reader["emp_num"].ToString() &&
                            tb_EmployeeNameDel.Text == reader["emp_name"].ToString() &&
                            gender == reader["emp_gender"].ToString() &&
                            tb_BirthDel.Text == reader["emp_birth"].ToString())
                        {
                            info_match = true;
                        }
                    }
                    reader.Close();

                    if(info_match == true)
                    {
                        sql = "DELETE FROM employee_info WHERE rfid_num='";
                        sql += rfid + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();

                        tb_EmployeeNumDel.Text = ""; tb_EmployeeNameDel.Text = ""; tb_GenderDel.Text = ""; tb_BirthDel.Text = "";
                        rb_State.Text = "사원 정보가 정상적으로 삭제되었습니다.";
                        info_match = false;
                    }
                    else
                    {
                        MessageBox.Show("입력하신 사원 정보와 rfid카드의 정보가 서로 다릅니다. \n 다시 입력해주세요.");
                    }
                }
            }
            else
            {
                MessageBox.Show("사원 정보를 모두 입력해주세요.");
            }
        }
    }
}