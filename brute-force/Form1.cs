using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;


namespace brute_force
{
    public partial class Form1 : Form
    {
        private delegate void SetTextDeleg(string text);
        string portName, baudRate, parity, dataBits, handshake, stopBits;
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
        }

        static bool _continue = true;
        static SerialPort _serialPort;
        int timeOut=0;
        DateTime dOld = DateTime.Now;
        DateTime dNew = DateTime.Now;
        Thread readThread;
        public void SerialPortInit()
        {

            // Создание нового объекта SerialPort с установками по умолчанию.
            _serialPort = new SerialPort();

            // Позволяем пользователю установить подходящие свойства.
            _serialPort.PortName = SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            // Установка таймаутов чтения/записи (read/write timeouts)
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            byte[] buffer = new byte[256];
            int count;
            //int readCount;
            timeOut = int.Parse(tbTimeOut.Text);
            Console(string.Format("Поток запущен.timeOut = {0}", timeOut), " ", 0);
            int countNew;

            List<byte> bytesForSend = new List<byte>();

            _continue = true;

            while (_continue)
            {
                try
                {
                    count = _serialPort.BytesToRead;
                    if (count > 0)
                    {
                        Thread.Sleep(timeOut);
                        countNew = _serialPort.BytesToRead;
                        while (countNew > count)
                        {
                            Thread.Sleep(timeOut);
                            count = countNew;
                            countNew = _serialPort.BytesToRead;
                        }

                        _serialPort.Read(buffer, 0, count);
                        Console(BitConverter.ToString(buffer, 0, count), "<", 0);
                        byte[] adddCrc = Crc16(buffer, count - 2);
                        if ((buffer[count - 2] == adddCrc[0]) || (buffer[count - 1] == adddCrc[1]))
                        {
                            parseBuffer(buffer);
                        }
                        else 
                        {
                            string str = System.Text.Encoding.Default.GetString(buffer, 0, count);
                            Debug(str, "", 0);


                               
                        } 
                        
                    }
                }
                catch (Exception ex)
                {
                    Console(ex.Message,"!",0);
                }
                Thread.Sleep(100);
            }
            _serialPort.Close();
        }

        private void parseBuffer(byte[] buffer) 
        {
            float[] u = new float[3];
            float[] i_ch1 = new float[3];
            float[] i_ch2 = new float[3];
            float[] i_ch3 = new float[3];
            float[] i_ch4 = new float[3];
            byte NA = 0;
            float multi=1.0F;
            float multiU = 1.0F;

            if (buffer[0] == byte.Parse(tbNA1.Text)) { NA = byte.Parse(tbNA1.Text); multi = 1.0F; multiU = 1.0F; }
            if (buffer[0] == byte.Parse(tbNA2.Text)) { NA = byte.Parse(tbNA2.Text); multi = 2.0F; multiU = 1.1F; }
 
            if (NA > 0)
            {
                UInt16 register = (UInt16)(buffer[2] * 256 + buffer[3]);
                switch (register)
                {
                    case 0x1410:
                        
                        u[0] = multiU * float.Parse(tbU1.Text.Replace('.', ','));
                        u[1] = multiU * float.Parse(tbU2.Text.Replace('.', ','));
                        u[2] = multiU * float.Parse(tbU3.Text.Replace('.', ','));

                        sendToCom(NA, 0x04, 12, u, 1.52588 * 0.0000001, 1);
                      
                        break;
                    case 0x1416:

                        i_ch1[0] = multi * float.Parse(tbCh11.Text.Replace('.', ','));
                        i_ch1[1] = multi * float.Parse(tbCh12.Text.Replace('.', ','));
                        i_ch1[2] = multi * float.Parse(tbCh13.Text.Replace('.', ','));

                        sendToCom(NA, 0x04, 12, i_ch1, 2.44141 * 0.0000001, 0);
                        break;

                    case 0x2416:
                        i_ch2[0] = multi * float.Parse(tbCh21.Text.Replace('.', ','));
                        i_ch2[1] = multi * float.Parse(tbCh22.Text.Replace('.', ','));
                        i_ch2[2] = multi * float.Parse(tbCh23.Text.Replace('.', ','));

                        sendToCom(NA, 0x04, 12, i_ch2, 2.44141 * 0.0000001, 0);
                        break;

                    case 0x3416:
                        i_ch3[0] = multi * float.Parse(tbCh31.Text.Replace('.', ','));
                        i_ch3[1] = multi * float.Parse(tbCh32.Text.Replace('.', ','));
                        i_ch3[2] = multi * float.Parse(tbCh33.Text.Replace('.', ','));

                        sendToCom(NA, 0x04, 12, i_ch3, 2.44141 * 0.0000001, 0);
                        break;

                    case 0x4416:
                        i_ch4[0] = multi * float.Parse(tbCh41.Text.Replace('.', ','));
                        i_ch4[1] = multi * float.Parse(tbCh42.Text.Replace('.', ','));
                        i_ch4[2] = multi * float.Parse(tbCh43.Text.Replace('.', ','));

                        sendToCom(NA, 0x04, 12, i_ch4, 2.44141 * 0.0000001, 0);
                        Console("", "", 0);
                        dNew = DateTime.Now;
                        var delta = dNew - dOld;
                        Console(string.Format("{0}", delta), ".", 0);
                        dOld = dNew;

                        break;
                    default:
                        break;
                }

            }
        }

        private void sendToCom(byte NA, byte fun, byte countbytes, float[] values, double coef, int iColor)
        {
            int count = 2;
            byte[] sendBuffer = new byte[256];
            sendBuffer[0] = NA;
            sendBuffer[1] = fun;
            sendBuffer[2] = countbytes;
            byte[] ret = new byte[4];
            for (int iPhase = 0; iPhase < 3; iPhase++)
            {
                double val = (values[iPhase] / coef);

                UInt32 value = (UInt32)Math.Round(val);
                ret = BitConverter.GetBytes(value);
                for (int i = 0; i < 4; i++)
                {
                    count++;
                    sendBuffer[count] = ret[3 - i];
                }
            }

            byte[] adddCrc = Crc16(sendBuffer, count + 1);
            sendBuffer[count + 1] = adddCrc[0];
            sendBuffer[count + 2] = adddCrc[1];

            _serialPort.Write(sendBuffer, 0, count + 3);
            Console(BitConverter.ToString(sendBuffer, 0, count + 3),">", iColor);

        }

        public void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console(message,">>",0);
                   
                }
                catch (TimeoutException) { }
            }
        }
        public string SetPortName(string defaultPortName)
        {
            foreach (string s in SerialPort.GetPortNames())
            {

            }

            if (portName == "")
            {
                portName = defaultPortName;
            }
            return portName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine($"{String.Format(txtName.Text)}:");
            _serialPort.WriteLine(String.Format(txtMessage.Text));
        }

        public int SetPortBaudRate(int defaultPortBaudRate)
        {
            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }
        public Parity SetPortParity(Parity defaultPortParity)
        {
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {

            }

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbConsole.InvokeRequired)
                lbConsole.Invoke(new Action(() => lbConsole.Items.Clear()));
            else lbConsole.Items.Clear();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((readThread == null) || (readThread.IsAlive == false))
            {
                txtName.Text = "";
                txtMessage.Text = "";
                portName = cbPort.Text;
                baudRate = cbBaudRate.Text;
                parity = cbParity.Text;
                dataBits = cbDataBits.Text;
                stopBits = cbStopBits.Text;
                handshake = cbHandshake.Text;

                readThread = new Thread(SerialPortInit); // Создаем новый объект потока (Thread)
                readThread.IsBackground = true;
                readThread.Start();  // запускаем поток
                btnStart.Text = "Stop";
            }
            else
            {
                _continue = false;
                Console("Поток остановлен", "=", 0);
                btnStart.Text = "Start";
            }
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            _continue = false;
            Console("Поток остановлен", "=", 0);
        }

        public int SetPortDataBits(int defaultPortDataBits)
        {

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits);
        }

        private void btnClearDebug_Click(object sender, EventArgs e)
        {
            if (lbDebug.InvokeRequired)
                lbDebug.Invoke(new Action(() => lbDebug.Items.Clear()));
            else lbDebug.Items.Clear();

        }

        private void tbCh11_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.AddRange(ports);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        public StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {

            }

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits);
        }
        public Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {

            }

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake);
        }
        public void Console(string str, string forw, int iColor)
        {
            str = string.Format("{0}{1:ss-ffff}:     {2}",  forw, DateTime.Now, str);
            if (iColor == 1) lbConsole.ForeColor = Color.Red; else lbConsole.ForeColor = Color.Black;
            if (lbConsole.InvokeRequired)
            {
                lbConsole.Invoke(new Action(() => lbConsole.Items.Add(str)));
                lbConsole.Invoke(new Action(() => lbConsole.SelectedIndex = lbConsole.Items.Count-1));

            }
            else
            {
                lbConsole.Items.Add(str);
                lbConsole.SelectedIndex = lbConsole.Items.Count - 1;
            }


            }

        public void Debug(string str, string forw, int iColor)
        {
            str = string.Format("{0}{1:ss-ffff}:     {2}", forw, DateTime.Now, str);
            if (iColor == 1) lbDebug.ForeColor = Color.Red; else lbDebug.ForeColor = Color.Black;
            if (lbDebug.InvokeRequired) 
            { 
                lbDebug.Invoke(new Action(() => lbDebug.Items.Add(str)));
                lbDebug.Invoke(new Action(() => lbDebug.SelectedIndex = lbDebug.Items.Count - 1));
            }
            else lbDebug.Items.Add(str);
            lbDebug.SelectedIndex = lbDebug.Items.Count - 1;
        }

        public byte[] Crc16(byte[] bytes, int count)
        {
            ushort polynomial = 0xA001;
            ushort[] table = new ushort[256];
            ushort value;
            ushort temp;

            for (ushort i = 0; i < table.Length; i++)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; j++)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }

            ushort crc = 0xFFFF;

            for (int i = 0; i < count; i++)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return new byte[] { (byte)(crc & 0x00ff), (byte)(crc >> 8) };
        }
    }
}

