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
                i++;
                label5.Text +=process.Name+"    "+process.Brust_time.ToString() + "           " + process.Arrival_time.ToString() +"            "+process.Priority.ToString()+ "\n";
               
            }
          
        }


        private void draw_on_chart(Process p,int t)
        {

            
            
                chart1.Series.Add(p.Name);
            
            chart1.Series[p.Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;

               
            
            
            chart1.Series[p.Name].Points.AddXY(1, t);


        }


        private void Add_Process_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            no_processess_entered++;
            int x = 0;
            Int32.TryParse(textBox2.Text, out x);
            int y= 0;
            Int32.TryParse(textBox3.Text, out y);
            int z = 0;
            Int32.TryParse(textBox4.Text, out z);
            p.Brust_time = x;
            p.Arrival_time = y;
            p.Priority = z;
            p.Name = "p" + no_processess_entered.ToString();
           

            processes.AddLast(p);

           
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";




           

            if (no_processess_entered >= no_processess_needed)
            {

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;


            }

            label6.Visible = true;
            Display(processes);

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

        private void Run_Click(object sender, EventArgs e)
        {
            if (Priority_NON.Checked )
            {

                non_preemptive_priority();

            }


            if (FCFS.Checked)
            {

                fcfs();

            }
            if(SJF_NON.Checked)
            {

                sjf_non_preemptive();


            }
            if(RR.Checked)
            {


               round_robin();

            }

        }


        

        private void non_preemptive_priority()
        {

            IEnumerable<Process> query = processes.OrderBy(p => p.Priority);

           Process[] temp = new Process[no_processess_entered];
            int i = 0;
            int current_time = 0;

            foreach (Process p in query)
            {
                temp[i] = p;

                i++;
            }

            while (true)
            {
                int f = current_time;
                int counter = 0;
                for (int j = 0; j < temp.Length; j++)
                {

                    if (temp[j].Name == "")
                        counter++;
                   
                    if (temp[j].Arrival_time <= current_time && temp[j].Name!="")
                    {
                        draw_on_chart(temp[j], temp[j].Brust_time);

                        current_time += temp[j].Brust_time;

                        temp[j].Name = "";
                        break;
                    }


                }

                if(counter==temp.Length)
                {


                    break;
                }


                if(f==current_time)
                current_time++;
            }

        }



        private void fcfs()
        {


            IEnumerable<Process> query = processes.OrderBy(p => p.Arrival_time);

            foreach (Process p in query)
            {
                draw_on_chart(p,p.Brust_time);
            }


        }



        private void sjf_non_preemptive()
        {


            IEnumerable<Process> query = processes.OrderBy(p => p.Brust_time);

            Process[] temp = new Process[no_processess_entered];
            int i = 0;
            int current_time = 0;

            foreach (Process p in query)
            {
                temp[i] = p;

                i++;
            }

            while (true)
            {
                int f = current_time;
                int counter = 0;
                for (int j = 0; j < temp.Length; j++)
                {

                    if (temp[j].Name == "")
                        counter++;

                    if (temp[j].Arrival_time <= current_time && temp[j].Name != "")
                    {
                        draw_on_chart(temp[j], temp[j].Brust_time);

                        current_time += temp[j].Brust_time;

                        temp[j].Name = "";
                        break;
                    }


                }

                if (counter == temp.Length)
                {


                    break;
                }


                if (f == current_time)
                    current_time++;
            }


        }



        private void round_robin()
        {
            int q = 2;
            int i = 0;
            int current_time = 0;
            Process[] temp = new Process[no_processess_entered];
            IEnumerable<Process> query = processes.OrderBy(p => p.Arrival_time);

            foreach (Process p in query)
            {
                temp[i] = p;

                i++;
            }


            while(true)
            {
                int start_p= current_time;
                int f = current_time;
                int counter = 0;
                for (int j=0;j<temp.Length;j++)
                {
                    if (temp[j].Brust_time == 0)
                        counter++;
                    if (current_time>=temp[j].Arrival_time && temp[j].Brust_time!=0)
                    {
                        if (temp[j].Brust_time >= 2)
                        {
                            //draw_on_chart(temp[j], 2);
                            start_p = current_time;
                            current_time += 2;
                            draw_in_table(temp[j],start_p,current_time);
                            temp[j].Brust_time -= 2;
                           
                        }
                        else
                        {
                            //draw_on_chart(temp[j], temp[j].Brust_time);
                            start_p = current_time;
                            current_time += temp[j].Brust_time;
                            draw_in_table(temp[j] , start_p , current_time);
                           
                            temp[j].Brust_time= 0;


                        }
                       

                        

                    }






                }


                if (counter == temp.Length)
                    break;





                    if(f==current_time)
                current_time++;
            }




        }


        private void draw_in_table(Process p, int start,int finish)
        {
            ColumnStyle temp = panel.ColumnStyles[panel.ColumnCount - 1];
            panel.ColumnCount++;
            panel.ColumnStyles.Add(new ColumnStyle(temp.SizeType, 30*(finish-start)));
            panel.Controls.Add(new Label() { Text = p.Name }, panel.ColumnCount - 1, 0);
            panel.Controls.Add(new Label() { Text = " "+start+"         "+finish }, panel.ColumnCount - 1, 1);
            
        }


    }
}
