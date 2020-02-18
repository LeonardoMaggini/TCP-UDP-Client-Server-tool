using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CUProtocol;
using ClienteConcentrador;
using NetworkProtocolServices;

namespace WindowsFormsApplication1
    {
    public partial class Form2 : Form
        {

        ClienteConcentrador.CRC32CITT crc32 = new CRC32CITT();

        public Form2()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            try
                {
                byte[] pbuff = NetworkProtocolServices.Utilities.Utilities.GetBytesBigEndian(textBox1.Text);
                uint seed = 3802665723;
                UInt16 len = Convert.ToUInt16(pbuff.Length);

                textBox3.Text = NetworkProtocolServices.Utilities.Utilities.ToString(crc32.CalcCRC32(pbuff, len));
                }
            catch (Exception ex)
                {

                MessageBox.Show(ex.Message);
                }
            
            }
        }
    }
