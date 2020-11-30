
namespace wbEmulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbU1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbU3 = new System.Windows.Forms.TextBox();
            this.tbU2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCh12 = new System.Windows.Forms.TextBox();
            this.tbCh13 = new System.Windows.Forms.TextBox();
            this.tbCh11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCh22 = new System.Windows.Forms.TextBox();
            this.tbCh23 = new System.Windows.Forms.TextBox();
            this.tbCh21 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCh32 = new System.Windows.Forms.TextBox();
            this.tbCh33 = new System.Windows.Forms.TextBox();
            this.tbCh31 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCh42 = new System.Windows.Forms.TextBox();
            this.tbCh43 = new System.Windows.Forms.TextBox();
            this.tbCh41 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbTimeOut = new System.Windows.Forms.TextBox();
            this.tbNA1 = new System.Windows.Forms.TextBox();
            this.tbNA2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbDebug = new System.Windows.Forms.ListBox();
            this.btnClearDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(331, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(1097, 88);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 2;
            this.cbPort.Text = "COM7";
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(1097, 249);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cbStopBits.TabIndex = 4;
            this.cbStopBits.Text = "One";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(1097, 195);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 5;
            this.cbParity.Text = "None";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(1097, 142);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(1123, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1094, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1094, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baud Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1094, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1094, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stop Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1094, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Bits";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(1097, 304);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbDataBits.TabIndex = 13;
            this.cbDataBits.Text = "8";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(1097, 431);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(1097, 454);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Text";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(1123, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mode";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 716);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(306, 31);
            this.txtMessage.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(458, 716);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "CLOSE PORT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(29, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Serial Port Communication";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(609, 716);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "OPEN PORT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(33, 62);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(363, 550);
            this.lbConsole.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(341, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(277, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Name:";
            // 
            // cbHandshake
            // 
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Location = new System.Drawing.Point(1097, 364);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(121, 21);
            this.cbHandshake.TabIndex = 25;
            this.cbHandshake.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1094, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Handshake";
            // 
            // tbU1
            // 
            this.tbU1.Location = new System.Drawing.Point(101, 639);
            this.tbU1.Name = "tbU1";
            this.tbU1.Size = new System.Drawing.Size(100, 20);
            this.tbU1.TabIndex = 27;
            this.tbU1.Text = "221";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(22, 617);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Фаза";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(22, 677);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(22, 657);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "B";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(22, 637);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "A";
            // 
            // tbU3
            // 
            this.tbU3.Location = new System.Drawing.Point(101, 679);
            this.tbU3.Name = "tbU3";
            this.tbU3.Size = new System.Drawing.Size(100, 20);
            this.tbU3.TabIndex = 32;
            this.tbU3.Text = "223";
            // 
            // tbU2
            // 
            this.tbU2.Location = new System.Drawing.Point(101, 659);
            this.tbU2.Name = "tbU2";
            this.tbU2.Size = new System.Drawing.Size(100, 20);
            this.tbU2.TabIndex = 33;
            this.tbU2.Text = "222";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(123, 616);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "U";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(240, 616);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Ch1";
            // 
            // tbCh12
            // 
            this.tbCh12.Location = new System.Drawing.Point(218, 659);
            this.tbCh12.Name = "tbCh12";
            this.tbCh12.Size = new System.Drawing.Size(100, 20);
            this.tbCh12.TabIndex = 37;
            this.tbCh12.Text = "0.012";
            // 
            // tbCh13
            // 
            this.tbCh13.Location = new System.Drawing.Point(218, 679);
            this.tbCh13.Name = "tbCh13";
            this.tbCh13.Size = new System.Drawing.Size(100, 20);
            this.tbCh13.TabIndex = 36;
            this.tbCh13.Text = "0.013";
            // 
            // tbCh11
            // 
            this.tbCh11.Location = new System.Drawing.Point(218, 639);
            this.tbCh11.Name = "tbCh11";
            this.tbCh11.Size = new System.Drawing.Size(100, 20);
            this.tbCh11.TabIndex = 35;
            this.tbCh11.Text = "0.011";
            this.tbCh11.TextChanged += new System.EventHandler(this.tbCh11_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(357, 617);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Ch2";
            // 
            // tbCh22
            // 
            this.tbCh22.Location = new System.Drawing.Point(335, 660);
            this.tbCh22.Name = "tbCh22";
            this.tbCh22.Size = new System.Drawing.Size(100, 20);
            this.tbCh22.TabIndex = 41;
            this.tbCh22.Text = "0.22";
            // 
            // tbCh23
            // 
            this.tbCh23.Location = new System.Drawing.Point(335, 680);
            this.tbCh23.Name = "tbCh23";
            this.tbCh23.Size = new System.Drawing.Size(100, 20);
            this.tbCh23.TabIndex = 40;
            this.tbCh23.Text = "0.23";
            // 
            // tbCh21
            // 
            this.tbCh21.Location = new System.Drawing.Point(335, 640);
            this.tbCh21.Name = "tbCh21";
            this.tbCh21.Size = new System.Drawing.Size(100, 20);
            this.tbCh21.TabIndex = 39;
            this.tbCh21.Text = "0.21";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(486, 616);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "Ch3";
            // 
            // tbCh32
            // 
            this.tbCh32.Location = new System.Drawing.Point(453, 660);
            this.tbCh32.Name = "tbCh32";
            this.tbCh32.Size = new System.Drawing.Size(100, 20);
            this.tbCh32.TabIndex = 45;
            this.tbCh32.Text = "3.2";
            // 
            // tbCh33
            // 
            this.tbCh33.Location = new System.Drawing.Point(453, 680);
            this.tbCh33.Name = "tbCh33";
            this.tbCh33.Size = new System.Drawing.Size(100, 20);
            this.tbCh33.TabIndex = 44;
            this.tbCh33.Text = "3.3";
            // 
            // tbCh31
            // 
            this.tbCh31.Location = new System.Drawing.Point(453, 640);
            this.tbCh31.Name = "tbCh31";
            this.tbCh31.Size = new System.Drawing.Size(100, 20);
            this.tbCh31.TabIndex = 43;
            this.tbCh31.Text = "3.1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(589, 617);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 20);
            this.label19.TabIndex = 50;
            this.label19.Text = "Ch4";
            // 
            // tbCh42
            // 
            this.tbCh42.Location = new System.Drawing.Point(567, 660);
            this.tbCh42.Name = "tbCh42";
            this.tbCh42.Size = new System.Drawing.Size(100, 20);
            this.tbCh42.TabIndex = 49;
            this.tbCh42.Text = "4.2";
            // 
            // tbCh43
            // 
            this.tbCh43.Location = new System.Drawing.Point(567, 680);
            this.tbCh43.Name = "tbCh43";
            this.tbCh43.Size = new System.Drawing.Size(100, 20);
            this.tbCh43.TabIndex = 48;
            this.tbCh43.Text = "4.3";
            // 
            // tbCh41
            // 
            this.tbCh41.Location = new System.Drawing.Point(567, 640);
            this.tbCh41.Name = "tbCh41";
            this.tbCh41.Size = new System.Drawing.Size(100, 20);
            this.tbCh41.TabIndex = 47;
            this.tbCh41.Text = "4.1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(33, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1094, 491);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 28);
            this.btnStart.TabIndex = 52;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbTimeOut
            // 
            this.tbTimeOut.Location = new System.Drawing.Point(1097, 540);
            this.tbTimeOut.Name = "tbTimeOut";
            this.tbTimeOut.Size = new System.Drawing.Size(121, 20);
            this.tbTimeOut.TabIndex = 54;
            this.tbTimeOut.Text = "10";
            // 
            // tbNA1
            // 
            this.tbNA1.Location = new System.Drawing.Point(769, 640);
            this.tbNA1.Name = "tbNA1";
            this.tbNA1.Size = new System.Drawing.Size(100, 20);
            this.tbNA1.TabIndex = 55;
            this.tbNA1.Text = "94";
            this.tbNA1.TextChanged += new System.EventHandler(this.tbNA1_TextChanged);
            // 
            // tbNA2
            // 
            this.tbNA2.Location = new System.Drawing.Point(769, 680);
            this.tbNA2.Name = "tbNA2";
            this.tbNA2.Size = new System.Drawing.Size(100, 20);
            this.tbNA2.TabIndex = 56;
            this.tbNA2.Text = "203";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(689, 640);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 20);
            this.label20.TabIndex = 57;
            this.label20.Text = "WB1.NA";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(689, 677);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 20);
            this.label21.TabIndex = 58;
            this.label21.Text = "WB2.NA";
            // 
            // lbDebug
            // 
            this.lbDebug.FormattingEnabled = true;
            this.lbDebug.Location = new System.Drawing.Point(402, 62);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(686, 550);
            this.lbDebug.TabIndex = 59;
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Location = new System.Drawing.Point(402, 37);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(75, 23);
            this.btnClearDebug.TabIndex = 60;
            this.btnClearDebug.Text = "Clear";
            this.btnClearDebug.UseVisualStyleBackColor = true;
            this.btnClearDebug.Click += new System.EventHandler(this.btnClearDebug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 779);
            this.Controls.Add(this.btnClearDebug);
            this.Controls.Add(this.lbDebug);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbNA2);
            this.Controls.Add(this.tbNA1);
            this.Controls.Add(this.tbTimeOut);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbCh42);
            this.Controls.Add(this.tbCh43);
            this.Controls.Add(this.tbCh41);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbCh32);
            this.Controls.Add(this.tbCh33);
            this.Controls.Add(this.tbCh31);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbCh22);
            this.Controls.Add(this.tbCh23);
            this.Controls.Add(this.tbCh21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbCh12);
            this.Controls.Add(this.tbCh13);
            this.Controls.Add(this.tbCh11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbU2);
            this.Controls.Add(this.tbU3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbU1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbHandshake);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Brute-Force";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbU1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbU3;
        private System.Windows.Forms.TextBox tbU2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCh12;
        private System.Windows.Forms.TextBox tbCh13;
        private System.Windows.Forms.TextBox tbCh11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCh22;
        private System.Windows.Forms.TextBox tbCh23;
        private System.Windows.Forms.TextBox tbCh21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCh32;
        private System.Windows.Forms.TextBox tbCh33;
        private System.Windows.Forms.TextBox tbCh31;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCh42;
        private System.Windows.Forms.TextBox tbCh43;
        private System.Windows.Forms.TextBox tbCh41;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbTimeOut;
        private System.Windows.Forms.TextBox tbNA1;
        private System.Windows.Forms.TextBox tbNA2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lbDebug;
        private System.Windows.Forms.Button btnClearDebug;
    }
}

