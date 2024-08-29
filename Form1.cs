using System.IO.Ports;
namespace pd_recepcion_ufs_2007
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        int nbyte = 0;
        string textoR = "";
        int byteValue = 0;
        byte[] ack = { 0x06 }; //Caracter ACK
        public Form1()
        {
            InitializeComponent();
            InitializePorts();
        }

        private void InitializePorts()
        {
            serialPort = new SerialPort("COM4");
            serialPort.BaudRate = 19200;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            if (serialPort.IsOpen)
            {
                STX.Text = "Abierto";
            }
            else
            {
                STX.Text = "Cerrado";
            }
            serialPort.Write(ack, 0, ack.Length); // ACK 
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType == SerialData.Chars)
            {
                // Lee un byte
                byteValue = serialPort.ReadByte();
            }
            BeginInvoke(new Action(() =>
            {
                if (byteValue == 0x05)
                {
                    nbyte = -1;
                    serialPort.Write(ack, 0, ack.Length); // ACK
                    //textBox8.Text = nENQ.ToString();
                }
            }));
        }
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }
    }
}
