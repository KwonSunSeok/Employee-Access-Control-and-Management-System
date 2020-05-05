namespace Access_Control_System
{
    partial class Access_Control_System
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab_Page = new System.Windows.Forms.TabControl();
            this.tabPage_SetUp = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Port = new System.Windows.Forms.ComboBox();
            this.combo_Bps = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ComPort = new System.Windows.Forms.Label();
            this.progBar_PortStatus = new System.Windows.Forms.ProgressBar();
            this.btn_ClosePort = new System.Windows.Forms.Button();
            this.btn_OpenPort = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_SendData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTb_receiveData = new System.Windows.Forms.RichTextBox();
            this.tabPage_Join = new System.Windows.Forms.TabPage();
            this.rb_State = new System.Windows.Forms.RichTextBox();
            this.gb_EmployeeDel = new System.Windows.Forms.GroupBox();
            this.btn_OkDel = new System.Windows.Forms.Button();
            this.tb_GenderDel = new System.Windows.Forms.TextBox();
            this.tb_BirthDel = new System.Windows.Forms.TextBox();
            this.tb_EmployeeNameDel = new System.Windows.Forms.TextBox();
            this.tb_EmployeeNumDel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_EmployeeJoin = new System.Windows.Forms.GroupBox();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.tb_Birth = new System.Windows.Forms.TextBox();
            this.tb_EmployeeName = new System.Windows.Forms.TextBox();
            this.tb_EmployeeNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_OkJoin = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Join = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.avr_SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_Page.SuspendLayout();
            this.tabPage_SetUp.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_Join.SuspendLayout();
            this.gb_EmployeeDel.SuspendLayout();
            this.gb_EmployeeJoin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Page
            // 
            this.tab_Page.Controls.Add(this.tabPage_SetUp);
            this.tab_Page.Controls.Add(this.tabPage_Join);
            this.tab_Page.Controls.Add(this.tabPage1);
            this.tab_Page.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.tab_Page.Location = new System.Drawing.Point(14, 136);
            this.tab_Page.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Page.Name = "tab_Page";
            this.tab_Page.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_Page.SelectedIndex = 0;
            this.tab_Page.Size = new System.Drawing.Size(1051, 575);
            this.tab_Page.TabIndex = 2;
            // 
            // tabPage_SetUp
            // 
            this.tabPage_SetUp.Controls.Add(this.groupBox6);
            this.tabPage_SetUp.Controls.Add(this.btn_Send);
            this.tabPage_SetUp.Controls.Add(this.btn_Clear);
            this.tabPage_SetUp.Controls.Add(this.groupBox3);
            this.tabPage_SetUp.Controls.Add(this.groupBox2);
            this.tabPage_SetUp.Location = new System.Drawing.Point(4, 34);
            this.tabPage_SetUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_SetUp.Name = "tabPage_SetUp";
            this.tabPage_SetUp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_SetUp.Size = new System.Drawing.Size(1043, 537);
            this.tabPage_SetUp.TabIndex = 0;
            this.tabPage_SetUp.Text = "설정";
            this.tabPage_SetUp.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.combo_Port);
            this.groupBox6.Controls.Add(this.combo_Bps);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.progBar_PortStatus);
            this.groupBox6.Controls.Add(this.btn_ClosePort);
            this.groupBox6.Controls.Add(this.btn_OpenPort);
            this.groupBox6.Location = new System.Drawing.Point(24, 84);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(289, 309);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Port 설정";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.Location = new System.Drawing.Point(62, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Port";
            // 
            // combo_Port
            // 
            this.combo_Port.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.combo_Port.FormattingEnabled = true;
            this.combo_Port.Location = new System.Drawing.Point(115, 48);
            this.combo_Port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_Port.Name = "combo_Port";
            this.combo_Port.Size = new System.Drawing.Size(166, 36);
            this.combo_Port.TabIndex = 17;
            // 
            // combo_Bps
            // 
            this.combo_Bps.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.combo_Bps.FormattingEnabled = true;
            this.combo_Bps.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.combo_Bps.Location = new System.Drawing.Point(115, 91);
            this.combo_Bps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_Bps.Name = "combo_Bps";
            this.combo_Bps.Size = new System.Drawing.Size(166, 36);
            this.combo_Bps.TabIndex = 20;
            this.combo_Bps.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.Location = new System.Drawing.Point(3, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Port Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ComPort);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.groupBox1.Location = new System.Drawing.Point(115, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(167, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label_ComPort
            // 
            this.label_ComPort.AutoSize = true;
            this.label_ComPort.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Bold);
            this.label_ComPort.Location = new System.Drawing.Point(37, 26);
            this.label_ComPort.Name = "label_ComPort";
            this.label_ComPort.Size = new System.Drawing.Size(105, 60);
            this.label_ComPort.TabIndex = 2;
            this.label_ComPort.Text = "OFF";
            // 
            // progBar_PortStatus
            // 
            this.progBar_PortStatus.Location = new System.Drawing.Point(115, 135);
            this.progBar_PortStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progBar_PortStatus.Name = "progBar_PortStatus";
            this.progBar_PortStatus.Size = new System.Drawing.Size(167, 39);
            this.progBar_PortStatus.TabIndex = 23;
            // 
            // btn_ClosePort
            // 
            this.btn_ClosePort.Enabled = false;
            this.btn_ClosePort.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_ClosePort.Location = new System.Drawing.Point(8, 242);
            this.btn_ClosePort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ClosePort.Name = "btn_ClosePort";
            this.btn_ClosePort.Size = new System.Drawing.Size(101, 41);
            this.btn_ClosePort.TabIndex = 24;
            this.btn_ClosePort.Text = "닫기";
            this.btn_ClosePort.UseVisualStyleBackColor = true;
            this.btn_ClosePort.Click += new System.EventHandler(this.btn_ClosePort_Click);
            // 
            // btn_OpenPort
            // 
            this.btn_OpenPort.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_OpenPort.Location = new System.Drawing.Point(8, 194);
            this.btn_OpenPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OpenPort.Name = "btn_OpenPort";
            this.btn_OpenPort.Size = new System.Drawing.Size(101, 41);
            this.btn_OpenPort.TabIndex = 25;
            this.btn_OpenPort.Text = "열기";
            this.btn_OpenPort.UseVisualStyleBackColor = true;
            this.btn_OpenPort.Click += new System.EventHandler(this.btn_OpenPort_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Send.Location = new System.Drawing.Point(927, 430);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(96, 39);
            this.btn_Send.TabIndex = 28;
            this.btn_Send.Text = "송신";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Enabled = false;
            this.btn_Clear.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Clear.Location = new System.Drawing.Point(927, 101);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(96, 39);
            this.btn_Clear.TabIndex = 29;
            this.btn_Clear.Text = "정리";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_SendData);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.groupBox3.Location = new System.Drawing.Point(337, 398);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(583, 84);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "송신 데이터";
            // 
            // tb_SendData
            // 
            this.tb_SendData.Enabled = false;
            this.tb_SendData.Location = new System.Drawing.Point(7, 32);
            this.tb_SendData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_SendData.Name = "tb_SendData";
            this.tb_SendData.Size = new System.Drawing.Size(569, 34);
            this.tb_SendData.TabIndex = 0;
            this.tb_SendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SendData_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTb_receiveData);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.groupBox2.Location = new System.Drawing.Point(337, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(583, 299);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "수신 데이터";
            // 
            // richTb_receiveData
            // 
            this.richTb_receiveData.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.richTb_receiveData.Location = new System.Drawing.Point(7, 35);
            this.richTb_receiveData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTb_receiveData.Name = "richTb_receiveData";
            this.richTb_receiveData.ReadOnly = true;
            this.richTb_receiveData.Size = new System.Drawing.Size(569, 255);
            this.richTb_receiveData.TabIndex = 0;
            this.richTb_receiveData.Text = "";
            // 
            // tabPage_Join
            // 
            this.tabPage_Join.Controls.Add(this.rb_State);
            this.tabPage_Join.Controls.Add(this.gb_EmployeeDel);
            this.tabPage_Join.Controls.Add(this.gb_EmployeeJoin);
            this.tabPage_Join.Controls.Add(this.btn_Del);
            this.tabPage_Join.Controls.Add(this.btn_Join);
            this.tabPage_Join.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Join.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Join.Name = "tabPage_Join";
            this.tabPage_Join.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Join.Size = new System.Drawing.Size(1043, 537);
            this.tabPage_Join.TabIndex = 1;
            this.tabPage_Join.Text = "사원 관리";
            this.tabPage_Join.UseVisualStyleBackColor = true;
            // 
            // rb_State
            // 
            this.rb_State.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.rb_State.Location = new System.Drawing.Point(675, 50);
            this.rb_State.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_State.Name = "rb_State";
            this.rb_State.ReadOnly = true;
            this.rb_State.Size = new System.Drawing.Size(342, 124);
            this.rb_State.TabIndex = 5;
            this.rb_State.Text = "";
            // 
            // gb_EmployeeDel
            // 
            this.gb_EmployeeDel.Controls.Add(this.btn_OkDel);
            this.gb_EmployeeDel.Controls.Add(this.tb_GenderDel);
            this.gb_EmployeeDel.Controls.Add(this.tb_BirthDel);
            this.gb_EmployeeDel.Controls.Add(this.tb_EmployeeNameDel);
            this.gb_EmployeeDel.Controls.Add(this.tb_EmployeeNumDel);
            this.gb_EmployeeDel.Controls.Add(this.label13);
            this.gb_EmployeeDel.Controls.Add(this.label9);
            this.gb_EmployeeDel.Controls.Add(this.label10);
            this.gb_EmployeeDel.Controls.Add(this.label11);
            this.gb_EmployeeDel.Controls.Add(this.label12);
            this.gb_EmployeeDel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.gb_EmployeeDel.Location = new System.Drawing.Point(160, 265);
            this.gb_EmployeeDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_EmployeeDel.Name = "gb_EmployeeDel";
            this.gb_EmployeeDel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_EmployeeDel.Size = new System.Drawing.Size(491, 219);
            this.gb_EmployeeDel.TabIndex = 4;
            this.gb_EmployeeDel.TabStop = false;
            this.gb_EmployeeDel.Text = "사원 정보 삭제";
            // 
            // btn_OkDel
            // 
            this.btn_OkDel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_OkDel.Location = new System.Drawing.Point(371, 46);
            this.btn_OkDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OkDel.Name = "btn_OkDel";
            this.btn_OkDel.Size = new System.Drawing.Size(86, 36);
            this.btn_OkDel.TabIndex = 12;
            this.btn_OkDel.Text = "확인";
            this.btn_OkDel.UseVisualStyleBackColor = true;
            this.btn_OkDel.Click += new System.EventHandler(this.btn_OkDel_Click);
            // 
            // tb_GenderDel
            // 
            this.tb_GenderDel.Location = new System.Drawing.Point(304, 151);
            this.tb_GenderDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_GenderDel.Name = "tb_GenderDel";
            this.tb_GenderDel.PasswordChar = '*';
            this.tb_GenderDel.Size = new System.Drawing.Size(33, 34);
            this.tb_GenderDel.TabIndex = 11;
            // 
            // tb_BirthDel
            // 
            this.tb_BirthDel.Location = new System.Drawing.Point(133, 151);
            this.tb_BirthDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_BirthDel.Name = "tb_BirthDel";
            this.tb_BirthDel.Size = new System.Drawing.Size(138, 34);
            this.tb_BirthDel.TabIndex = 10;
            // 
            // tb_EmployeeNameDel
            // 
            this.tb_EmployeeNameDel.Location = new System.Drawing.Point(133, 99);
            this.tb_EmployeeNameDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmployeeNameDel.Name = "tb_EmployeeNameDel";
            this.tb_EmployeeNameDel.Size = new System.Drawing.Size(138, 34);
            this.tb_EmployeeNameDel.TabIndex = 9;
            // 
            // tb_EmployeeNumDel
            // 
            this.tb_EmployeeNumDel.Location = new System.Drawing.Point(133, 46);
            this.tb_EmployeeNumDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmployeeNumDel.Name = "tb_EmployeeNumDel";
            this.tb_EmployeeNumDel.Size = new System.Drawing.Size(138, 34);
            this.tb_EmployeeNumDel.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "******";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "주민등록번호";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "사원 이름";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "사원 번호";
            // 
            // gb_EmployeeJoin
            // 
            this.gb_EmployeeJoin.Controls.Add(this.tb_Gender);
            this.gb_EmployeeJoin.Controls.Add(this.tb_Birth);
            this.gb_EmployeeJoin.Controls.Add(this.tb_EmployeeName);
            this.gb_EmployeeJoin.Controls.Add(this.tb_EmployeeNum);
            this.gb_EmployeeJoin.Controls.Add(this.label1);
            this.gb_EmployeeJoin.Controls.Add(this.label6);
            this.gb_EmployeeJoin.Controls.Add(this.label7);
            this.gb_EmployeeJoin.Controls.Add(this.label8);
            this.gb_EmployeeJoin.Controls.Add(this.label14);
            this.gb_EmployeeJoin.Controls.Add(this.btn_OkJoin);
            this.gb_EmployeeJoin.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.gb_EmployeeJoin.Location = new System.Drawing.Point(160, 38);
            this.gb_EmployeeJoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_EmployeeJoin.Name = "gb_EmployeeJoin";
            this.gb_EmployeeJoin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_EmployeeJoin.Size = new System.Drawing.Size(491, 219);
            this.gb_EmployeeJoin.TabIndex = 4;
            this.gb_EmployeeJoin.TabStop = false;
            this.gb_EmployeeJoin.Text = "사원 정보 입력";
            // 
            // tb_Gender
            // 
            this.tb_Gender.Location = new System.Drawing.Point(304, 151);
            this.tb_Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.PasswordChar = '*';
            this.tb_Gender.Size = new System.Drawing.Size(33, 34);
            this.tb_Gender.TabIndex = 6;
            // 
            // tb_Birth
            // 
            this.tb_Birth.Location = new System.Drawing.Point(133, 151);
            this.tb_Birth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Birth.Name = "tb_Birth";
            this.tb_Birth.Size = new System.Drawing.Size(138, 34);
            this.tb_Birth.TabIndex = 5;
            // 
            // tb_EmployeeName
            // 
            this.tb_EmployeeName.Location = new System.Drawing.Point(133, 99);
            this.tb_EmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmployeeName.Name = "tb_EmployeeName";
            this.tb_EmployeeName.Size = new System.Drawing.Size(138, 34);
            this.tb_EmployeeName.TabIndex = 4;
            // 
            // tb_EmployeeNum
            // 
            this.tb_EmployeeNum.Location = new System.Drawing.Point(133, 46);
            this.tb_EmployeeNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmployeeNum.Name = "tb_EmployeeNum";
            this.tb_EmployeeNum.Size = new System.Drawing.Size(138, 34);
            this.tb_EmployeeNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "******";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "주민등록번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "사원 이름";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 28);
            this.label14.TabIndex = 9;
            this.label14.Text = "사원 번호";
            // 
            // btn_OkJoin
            // 
            this.btn_OkJoin.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_OkJoin.Location = new System.Drawing.Point(371, 46);
            this.btn_OkJoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OkJoin.Name = "btn_OkJoin";
            this.btn_OkJoin.Size = new System.Drawing.Size(86, 36);
            this.btn_OkJoin.TabIndex = 7;
            this.btn_OkJoin.Text = "확인";
            this.btn_OkJoin.UseVisualStyleBackColor = true;
            this.btn_OkJoin.Click += new System.EventHandler(this.btn_OkJoin_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.btn_Del.Location = new System.Drawing.Point(34, 265);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(104, 45);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.Text = "삭제";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Join
            // 
            this.btn_Join.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.btn_Join.Location = new System.Drawing.Point(34, 38);
            this.btn_Join.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(104, 45);
            this.btn_Join.TabIndex = 1;
            this.btn_Join.Text = "등록";
            this.btn_Join.UseVisualStyleBackColor = true;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(421, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "출입 통제 시스템";
            // 
            // avr_SerialPort
            // 
            this.avr_SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.avr_SerialPort_DataReceived);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 537);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Access_Control_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 726);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tab_Page);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Access_Control_System";
            this.Text = "Access Control System";
            this.tab_Page.ResumeLayout(false);
            this.tabPage_SetUp.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage_Join.ResumeLayout(false);
            this.gb_EmployeeDel.ResumeLayout(false);
            this.gb_EmployeeDel.PerformLayout();
            this.gb_EmployeeJoin.ResumeLayout(false);
            this.gb_EmployeeJoin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Page;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage_SetUp;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_SendData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTb_receiveData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ComPort;
        private System.Windows.Forms.Button btn_ClosePort;
        private System.Windows.Forms.Button btn_OpenPort;
        private System.Windows.Forms.ProgressBar progBar_PortStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage_Join;
        private System.Windows.Forms.Button btn_Join;
        private System.Windows.Forms.GroupBox gb_EmployeeJoin;
        private System.Windows.Forms.Button btn_OkJoin;
        private System.Windows.Forms.GroupBox gb_EmployeeDel;
        private System.Windows.Forms.Button btn_OkDel;
        private System.Windows.Forms.TextBox tb_BirthDel;
        private System.Windows.Forms.TextBox tb_EmployeeNameDel;
        private System.Windows.Forms.TextBox tb_EmployeeNumDel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox tb_GenderDel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rb_State;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.IO.Ports.SerialPort avr_SerialPort;
        public System.Windows.Forms.ComboBox combo_Port;
        public System.Windows.Forms.ComboBox combo_Bps;
        private System.Windows.Forms.TextBox tb_Gender;
        private System.Windows.Forms.TextBox tb_Birth;
        private System.Windows.Forms.TextBox tb_EmployeeName;
        private System.Windows.Forms.TextBox tb_EmployeeNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

