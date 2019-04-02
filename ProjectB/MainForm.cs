using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class MainForm : Form
    {
       

        public MainForm()
        {
            InitializeComponent();
        }
        bool rbflag = false;
        bool stdflag = false;
        bool cloflag = false;



        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        Student std;
        CLO clo;
        Rubric rubric;
        
    
        


        
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(std == null)
            {
                std = new Student();
                std.MdiParent = this;
                std.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                std.Show();
                stdflag = true;



                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }

            }
            else
            {
                std.Activate();
            }
            
        }

        void std_FormClosed(object sender, FormClosingEventArgs e)
        {
            std = null;
            clo = null;
            rubric = null;
            stdflag = false;
            cloflag = false;
            rbflag = false;
            //throw new NotImplementedException();
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clo == null)
            {
                clo = new CLO();
                clo.MdiParent = this;
                clo.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                clo.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                cloflag = true;


            }
            else
            {
                clo.Activate();
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (rubric == null)
            {
                rubric = new Rubric();
                rubric.MdiParent = this;
                rubric.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                rubric.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
               
                
                rbflag = true;

            }
            else
            {
                rubric.Activate();
            }
        }
    }
}
