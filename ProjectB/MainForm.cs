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
        bool assessmentflag = false;
        bool componentflag = false;
        bool studentattendanceflag = false;
        bool classattendanceflag = false;
        bool studentresultflag = false;
        bool cloreportflag = false;
        bool assessmentreportflag = false;




        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        Student std;
        CLO clo;
        Rubric rubric;
        Assesment assessment;
        AssessmentComponent component;
        StudentAttendance stdattendance;
        Class classattendance;
        Result result;
        Reports cloreport;
        AssessmentReport assessmentreport;


        
    
        


        
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(std == null)
            {
                std = new Student();
                std.MdiParent = this;
                std.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                std.Show();
                



                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }


                stdflag = true;
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
            assessment = null;
            component = null;
            result = null;
            classattendance = null;
            stdattendance = null;
            cloreport = null;
            assessmentreport = null;


            stdflag = false;
            cloflag = false;
            rbflag = false;
            assessmentflag = false;
            componentflag = false;
            studentresultflag = false;
            classattendanceflag = false;
            studentresultflag = false;
            cloreportflag = false;
            assessmentreportflag = false;
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
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

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
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }


                rbflag = true;

            }
            else
            {
                rubric.Activate();
            }
        }

        private void manageToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (assessment == null)
            {
                assessment = new Assesment();
                assessment.MdiParent = this;
                assessment.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                assessment.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                assessmentflag = true;

            }
            else
            {
                assessment.Activate();
            }
        }

        private void manageToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (component == null)
            {
                component = new AssessmentComponent();
                component.MdiParent = this;
                component.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                component.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }


                componentflag = true;

            }
            else
            {
                component.Activate();
            }

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manageToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (stdattendance == null)
            {
                stdattendance = new StudentAttendance();
                stdattendance.MdiParent = this;
                stdattendance.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                stdattendance.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }

                studentattendanceflag = true;

            }
            else
            {
                stdattendance.Activate();
            }
        }

        private void manageToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (classattendance == null)
            {
                classattendance = new Class();
                classattendance.MdiParent = this;
                classattendance.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                classattendance.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                classattendanceflag = true;


            }
            else
            {
                classattendance.Activate();
            }

        }

        private void manageToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //Result r = new Result();
            //this.Hide();
            //r.Show();
            if (result == null)
            {
                result = new Result();
                result.MdiParent = this;
                result.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                result.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloreportflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                studentresultflag = true;


            }
            else
            {
                result.Activate();
            }
        }

        private void manageToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (cloreport == null)
            {
                cloreport = new Reports();
                cloreport.MdiParent = this;
                cloreport.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                cloreport.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentreportflag)
                {
                    assessmentreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                cloreportflag = true;


            }
            else
            {
                cloreport.Activate();
            }

        }

        private void manageToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (assessmentreport == null)
            {
                assessmentreport = new AssessmentReport();
                assessmentreport.MdiParent = this;
                assessmentreport.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.std_FormClosed);
                assessmentreport.Show();
                if (stdflag)
                {
                    std.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (rbflag)
                {
                    rubric.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (assessmentflag)
                {
                    assessment.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (componentflag)
                {
                    component.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentattendanceflag)
                {
                    stdattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    clo.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (classattendanceflag)
                {
                    classattendance.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (studentresultflag)
                {
                    result.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                if (cloflag)
                {
                    cloreport.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                assessmentreportflag= true;


            }
            else
            {
                assessmentreport.Activate();
            }


        }
    }
}
