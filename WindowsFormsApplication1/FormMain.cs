using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class FormMain : Form
        {
        formCP frmCP;
        public FormMain()
            {
            InitializeComponent();
            }

        /// <summary>
        /// este metod carga el formulario Form1 que tiene
        /// la herramienta de diagnostico 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void herramientaDeDiagnosticosToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Form1 formDiagnostico = new Form1();
            formDiagnostico.MdiParent = this;
            formDiagnostico.Show();
            }

        private void clienteTCPToolStripMenuItem_Click(object sender, EventArgs e)
            {
            FormTCPClient formTCPClient = new FormTCPClient();
            formTCPClient.MdiParent = this;
            formTCPClient.Show();
            }

        private void casoN1ToolStripMenuItem_Click(object sender, EventArgs e)
            {
             frmCP = new formCP();
            frmCP.MdiParent = this;
            tabControl1.Controls.Add(frmCP);

            frmCP.Show();
            }


        private void onSplitPanel2Resize(object sender, EventArgs e)
            {
            if (tabControl1.TabPages.Count >= 1)
                {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                    {
                    foreach (Form f in tabControl1.TabPages[i].Controls)
                        {
                        if (f != null)
                            {
                            f.Width = splitContainer1.Panel2.ClientSize.Width;
                            f.Height = splitContainer1.Panel2.ClientSize.Height;
                            }
                        }
                    }
                }
            }

        private void onTabControlSelected(object sender, TabControlEventArgs e)
            {
            frmCP = new formCP();
            frmCP.MdiParent = this;
            tabControl1.TabPages[e.TabPageIndex].Controls.Add(frmCP);
           
            frmCP.Show();
            }

        private void FormMain_Load(object sender, EventArgs e)
            {

            }

        }
    }
