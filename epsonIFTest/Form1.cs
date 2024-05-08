using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace epsonIFTest
{
    public partial class Form1 : Form
    {
        #region DECLARACIÓN DE LAS FUNCIONES de pnpdlltest.DLL
        [DllImport("pnpdlltest.dll")] public static extern string PFAbreNF();
        [DllImport("pnpdlltest.dll")]
        public static extern string PFabrefiscal(String Razon,
        String RIF);
        [DllImport("pnpdlltest.dll")] public static extern string PFtotal();
        [DllImport("pnpdlltest.dll")] public static extern string PFrepz();
        [DllImport("pnpdlltest.dll")] public static extern string PFrepx();
        [DllImport("pnpdlltest.dll")]
        public static extern string PFrenglon(String Descripcion,
        String cantidad, String monto, String iva);
        [DllImport("pnpdlltest.dll")] public static extern string PFabrepuerto(String numero);
        [DllImport("pnpdlltest.dll")] public static extern string PFcierrapuerto();
        [DllImport("pnpdlltest.dll")] public static extern string PFDisplay950(String edlinea);
        [DllImport("pnpdlltest.dll")] public static extern string PFLineaNF(String edlinea);
        [DllImport("pnpdlltest.dll")] public static extern string PFCierraNF();
        [DllImport("pnpdlltest.dll")] public static extern string PFCortar();
        [DllImport("pnpdlltest.dll")] public static extern string PFTfiscal(String edlinea);
        [DllImport("pnpdlltest.dll")] public static extern string PFparcial();
        [DllImport("pnpdlltest.dll")] public static extern string PFSerial();
        [DllImport("pnpdlltest.dll")] public static extern string PFtoteconomico();
        [DllImport("pnpdlltest.dll")] public static extern string PFestatus(String edlinea);
        [DllImport("pnpdlltest.dll")] public static extern string PFreset();
        [DllImport("pnpdlltest.dll")]
        public static extern string PFendoso(String campo1,
        String campo2, String campo3, String tipoendoso);
        [DllImport("pnpdlltest.dll")]
        public static extern string PFvalida675(String campo1,
        String campo2, String campo3, String campo4);
        [DllImport("pnpdlltest.dll")]
        public static extern string PFCheque2(String mon, String
        ben, String fec, String c1, String c2, String c3, String c4, String campo1, String
        campo2);
        [DllImport("pnpdlltest.dll")]
        public static extern string PFcambiofecha(String edfecha,
        String edhora);
        [DllImport("pnpdlltest.dll")]
        public static extern string PFcambiatasa(String t1, String
        t2, String t3);
        [DllImport("pnpdlltest.dll")] public static extern string PFBarra(String edbarra);
        [DllImport("pnpdlltest.dll")] public static extern string PFVoltea();
        [DllImport("pnpdlltest.dll")] public static extern string PFLeereloj();
        [DllImport("pnpdlltest.dll")]
        public static extern string PFrepMemNF(String desf,
        String hasf, String modmem);
        [DllImport("pnpdlltest.dll")]
        public static extern string PFRepMemoriaNumero(String
        desn, String hasn, String modmem);
        [DllImport("pnpdlltest.dll")] public static extern string PFCambtipoContrib(String tip);
        [DllImport("pnpdlltest.dll")] public static extern string PFultimo();
        [DllImport("pnpdlltest.dll")] public static extern string PFTipoImp(String edtexto);
        #endregion
        [DllImport("pnpdlltest.dll")] public static extern string PFCancelaDoc(String edlinea,String monto);
        [DllImport("pnpdlltest.dll")] public static extern string PFGaveta();
        [DllImport("pnpdlltest.dll")]
        public static extern string PFDevolucion(String razon,
        String rif, String comp, String maqui, String fecha, String hora);
        [DllImport("pnpdlltest.dll")] public static extern string PFSlipON();
        [DllImport("pnpdlltest.dll")] public static extern string PFSLIPOFF();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result= PFabrepuerto(textBox1.Text);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PFabrefiscal("Nombre", "12345678");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PFrenglon("Producto 2", "1", "199", "0");
            PFrenglon("Producto 4", "1", "220", "1");
            PFrenglon("Producto 6", "6", "555", "1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PFtotal();
        }
        void printFactura()
        {
            //PFAbrePuerto(‘1’ );
            //PFAbreFiscal(‘CLIENTE’,’RIF’);
            //PFRenglon(‘PRODUCTO 1’,’1’,’10’,’1200’);
            //PFTOTAL;

        }
    }
}
