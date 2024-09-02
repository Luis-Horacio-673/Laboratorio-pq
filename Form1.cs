using System.IO.Ports;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace pd_recepcion_ufs_2007
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        int nbyte = 0;
        string textoR = "";
        int byteValue = 0;
        byte[] ack = { 0x06 }; //Caracter ACK
        byte[] nack = { 0x15 }; //Caracter NACK
        byte nToNack = 0;
        int Millos = 0;
        int value_Millos = 0;
        int value_Miles = 0;
        int Millos_old = 0;
        string sMillosold = "";
        string sMillosnew = "";
        int Piezas = 0;
        int Piezas_old = 0;
        string sPiezasold = "";
        string sPiezasnew = "";
        bool cienMillos = false;
        bool contando = false;

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
                if (nbyte == 0)                // STX
                {

                    if (byteValue == 0x05)
                    {
                        nbyte = -1;
                        serialPort.Write(ack, 0, ack.Length); // ACK
                                                              //textBox8.Text = nENQ.ToString();
                    }


                    if (byteValue == 2)
                    {
                        STX.Text = "Stx";
                    }
                    else { nbyte = -1; }
                }


                if (nbyte == 1)                 // TRIAL 1
                {
                    byteValue = byteValue - 48;
                    TRIAL.Text = byteValue.ToString();
                }
                if (nbyte == 2)                 //TRIAL 2
                {
                    byteValue = byteValue - 48;
                    TRIAL.Text += ", " + byteValue.ToString();
                }
                if (nbyte == 3)               //STATUS 1  
                {
                    byteValue = byteValue - 48;
                    STATUS.Text = byteValue.ToString();
                    if (byteValue == 0x01) { contando = true; }
                    if (byteValue == 0x00) { contando = false; }
                }
                if (nbyte == 4)                 //STATUS 2
                {
                    byteValue = byteValue - 48;
                    STATUS.Text += ", " + byteValue.ToString();
                }
                if (nbyte == 5)                 //STATUS 3
                {
                    byteValue = byteValue - 48;
                    STATUS.Text += ", " + byteValue.ToString();
                }
                if (nbyte == 6)                 //STATUS 4
                {
                    byteValue = byteValue - 48;
                    STATUS.Text += ", " + byteValue.ToString();
                }
                if (nbyte == 7)                 //AMOUNT 01
                {
                    byteValue = byteValue - 48;
                    textoR = byteValue.ToString();
                    DB.Text = byteValue.ToString();
                }
                if (nbyte == 8)                  //AMOUNT 02
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    UB.Text = byteValue.ToString();
                }
                if (nbyte == 9)                 //AMOUNT 03
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    CMM.Text = byteValue.ToString();
                }
                if (nbyte == 10)                //AMOUNT 04
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    DMM.Text = byteValue.ToString();
                }
                if (nbyte == 11)                //AMOUNT 05
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    UMM.Text = byteValue.ToString();
                }
                if (nbyte == 12)                //AMOUNT 06
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    CM.Text = byteValue.ToString();
                }
                if (nbyte == 13)                //AMOUNT 07
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    DM.Text = byteValue.ToString();
                    sMillosnew = byteValue.ToString();
                }
                if (nbyte == 14)                //AMOUNT 08
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    UM.Text = byteValue.ToString();
                    sMillosnew += byteValue.ToString();
                }
                if (nbyte == 15)                //AMOUNT 09
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    CMIL.Text = byteValue.ToString();
                }
                if (nbyte == 16)                //AMOUNT 10
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    DMIL.Text = byteValue.ToString();
                }
                if (nbyte == 17)                //AMOUNT 11
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    UMIL.Text = byteValue.ToString();
                }
                if (nbyte == 18)                //AMOUNT 12
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    CEN.Text = byteValue.ToString();
                }
                if (nbyte == 19)                //AMOUNT 13
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    DEC.Text = byteValue.ToString();
                }
                if (nbyte == 20)                //AMOUNT 14
                {
                    byteValue = byteValue - 48;
                    textoR += ", " + byteValue.ToString();
                    UNI.Text = byteValue.ToString();
                    AMOUNT.Text = textoR;
                    textoR = "";
                }
                if (nbyte == 21)                // COUNT 1
                {
                    byteValue = byteValue - 48;
                    CUM.Text = byteValue.ToString();
                    textoR = byteValue.ToString();

                }
                if (nbyte == 22)                // COUNT 2
                {
                    byteValue = byteValue - 48;
                    CCMIL.Text = byteValue.ToString();
                    textoR += ", " + byteValue.ToString();
                }
                if (nbyte == 23)                // COUNT 3
                {
                    byteValue = byteValue - 48;
                    CDMIL.Text = byteValue.ToString();
                    textoR += ", " + byteValue.ToString();
                }
                if (nbyte == 24)                // COUNT 4
                {
                    byteValue = byteValue - 48;
                    CUMIL.Text = byteValue.ToString();
                    textoR += ", " + byteValue.ToString();
                    sPiezasnew = byteValue.ToString();
                }
                if (nbyte == 25)                // COUNT 5
                {
                    byteValue = byteValue - 48;
                    CCEN.Text = byteValue.ToString();
                    textoR += ", " + (byteValue).ToString();
                    sPiezasnew += byteValue.ToString();
                }
                if (nbyte == 26)                // COUNT 6
                {
                    byteValue = byteValue - 48;
                    CDEC.Text = byteValue.ToString();
                    textoR += ", " + (byteValue).ToString();
                    sPiezasnew += byteValue.ToString();
                }
                if (nbyte == 27)                // COUNT 7
                {
                    byteValue = byteValue - 48;
                    CUNI.Text = byteValue.ToString();
                    textoR += ", " + (byteValue).ToString();
                    sPiezasnew += byteValue.ToString();
                    COUNT.Text = textoR;
                    textoR = "";
                }
                if (nbyte == 28)                //ETX
                {
                    if (byteValue == 0x03)
                    {
                        ETX.Text = "ETX";
                    }
                }
                if (nbyte == 29)                //BCC
                {
                    BCC.Text = byteValue.ToString();

                    nbyte = -1;
                    nToNack++;
                    if (nToNack == 3)
                    {
                        serialPort.Write(nack, 0, ack.Length); // NACK
                        nToNack = 0;                                     // 
                    }
                    else
                    {
                        serialPort.Write(ack, 0, ack.Length); // ACK }
                    }
                    // --------------------Determinacion del paso 99 a 100 millos
                    int.TryParse(sMillosnew, out Millos);
                    int.TryParse(sMillosold, out Millos_old);
                    if((Millos - Millos_old)<0 && contando && (Millos == 99)) {
                        cienMillos=true;
                        value_Millos++;
                        textoR = "00000";
                        textoR += value_Millos.ToString() + "00" + CMIL.Text + DMIL.Text + UMIL.Text + 
                        CEN.Text + DEC.Text + UNI.Text;
                        AMOUNT.Text = textoR;
                    }
                    sMillosold = sMillosnew;
                    // --------------------

                    //-------------Actualizacion de COUNT en decenas de miles
                    int.TryParse(sPiezasnew, out Piezas);
                    int.TryParse(sPiezasold, out Piezas_old);
                    if (((Piezas - Piezas_old) < 0) && contando && (Piezas_old == 9999))
                    {
                        value_Miles++;
                        textoR = "000" + value_Miles.ToString() + CUMIL.Text + CCEN.Text + 
                        CDEC.Text + CUNI.Text;
                        COUNT.Text = textoR;
                    }
                    sPiezasold = sPiezasnew;
                    // --------------------------------------------------
                }
                nbyte++;
            }));
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }

    }
}
