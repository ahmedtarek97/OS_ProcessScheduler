using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Schdular
{
    public partial class Form1 : Form
    {
        int no_processess_needed=0;
        int no_processess_entered=0;
        LinkedList<Process> processes = new LinkedList<Process>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Priority_PRE_CheckedChanged(object sender, EventArgs e)
        {
            if(Priority_PRE.Checked)
            {

                this.label4.Visible = true;
                this.textBox4.Visible = true;

            }
            else
            {

                this.label4.Visible = false;
                this.textBox4.Visible = false;

            }
        }

        private void Priority_NON_CheckedChanged(object sender, EventArgs e)
        {
            if (Priority_NON.Checked)
            {

                this.label4.Visible = true;
                this.textBox4.Visible = true;

            }
            else
            {

                this.label4.Visible = false;
                this.textBox4.Visible = false;

            }

        }

        private  void Display(LinkedList<Process> processes)
        {
            label5.Text = "";

            int i = 0;
            foreach (Process process in processes)
            {

                label5.Text += process.Brust_time.ToString() + " " + process.Arrival_time.ToString()+" "+i + "\n";
                i++;
            }
          
        }




        private void Add_Process_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            int x1 = 0;
            Int32.TryParse(textBox2.Text, out x1);
            int y1 = 0;
            Int32.TryParse(textBox3.Text, out y1);
            p.Brust_time = x1;
            p.Arrival_time = y1;

            processes.AddLast(p);
            textBox2.Text = "";
            textBox3.Text = "";




            no_processess_entered++;

            if (no_processess_entered >= no_processess_needed)
            {

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;


            }

        }


        private void Number_of_processes_Click(object sender, EventArgs e)
        {


            Int32.TryParse(textBox1.Text, out no_processess_needed);
            if (no_processess_needed > 0)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            textBox1.Text = "";

        }







        private void print_all_Click(object sender, EventArgs e)
        {
            Display(processes);
        }

       
    }
}
