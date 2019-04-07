namespace Schdular
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.FCFS = new System.Windows.Forms.RadioButton();
            this.SJF_PRE = new System.Windows.Forms.RadioButton();
            this.SJF_NON = new System.Windows.Forms.RadioButton();
            this.Priority_PRE = new System.Windows.Forms.RadioButton();
            this.Priority_NON = new System.Windows.Forms.RadioButton();
            this.RR = new System.Windows.Forms.RadioButton();
            this.Criteria = new System.Windows.Forms.GroupBox();
            this.number = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Process = new System.Windows.Forms.Button();
            this.Number_of_processes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Criteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a criteria";
            // 
            // FCFS
            // 
            this.FCFS.AutoSize = true;
            this.FCFS.Location = new System.Drawing.Point(6, 28);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(51, 17);
            this.FCFS.TabIndex = 1;
            this.FCFS.TabStop = true;
            this.FCFS.Text = "FCFS";
            this.FCFS.UseVisualStyleBackColor = true;
            // 
            // SJF_PRE
            // 
            this.SJF_PRE.AutoSize = true;
            this.SJF_PRE.Location = new System.Drawing.Point(74, 28);
            this.SJF_PRE.Name = "SJF_PRE";
            this.SJF_PRE.Size = new System.Drawing.Size(105, 17);
            this.SJF_PRE.TabIndex = 2;
            this.SJF_PRE.TabStop = true;
            this.SJF_PRE.Text = "SJF (Preemptive)";
            this.SJF_PRE.UseVisualStyleBackColor = true;
            // 
            // SJF_NON
            // 
            this.SJF_NON.AutoSize = true;
            this.SJF_NON.Location = new System.Drawing.Point(185, 28);
            this.SJF_NON.Name = "SJF_NON";
            this.SJF_NON.Size = new System.Drawing.Size(128, 17);
            this.SJF_NON.TabIndex = 3;
            this.SJF_NON.TabStop = true;
            this.SJF_NON.Text = "SJF (Non Preemptive)";
            this.SJF_NON.UseVisualStyleBackColor = true;
            // 
            // Priority_PRE
            // 
            this.Priority_PRE.AutoSize = true;
            this.Priority_PRE.Location = new System.Drawing.Point(328, 28);
            this.Priority_PRE.Name = "Priority_PRE";
            this.Priority_PRE.Size = new System.Drawing.Size(118, 17);
            this.Priority_PRE.TabIndex = 4;
            this.Priority_PRE.TabStop = true;
            this.Priority_PRE.Text = "Priority (Preemptive)";
            this.Priority_PRE.UseVisualStyleBackColor = true;
            this.Priority_PRE.CheckedChanged += new System.EventHandler(this.Priority_PRE_CheckedChanged);
            // 
            // Priority_NON
            // 
            this.Priority_NON.AutoSize = true;
            this.Priority_NON.Location = new System.Drawing.Point(463, 28);
            this.Priority_NON.Name = "Priority_NON";
            this.Priority_NON.Size = new System.Drawing.Size(141, 17);
            this.Priority_NON.TabIndex = 5;
            this.Priority_NON.TabStop = true;
            this.Priority_NON.Text = "Priority (Non Preemptive)";
            this.Priority_NON.UseVisualStyleBackColor = true;
            this.Priority_NON.CheckedChanged += new System.EventHandler(this.Priority_NON_CheckedChanged);
            // 
            // RR
            // 
            this.RR.AutoSize = true;
            this.RR.Location = new System.Drawing.Point(628, 28);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(88, 17);
            this.RR.TabIndex = 6;
            this.RR.TabStop = true;
            this.RR.Text = "Round Robin";
            this.RR.UseVisualStyleBackColor = true;
            // 
            // Criteria
            // 
            this.Criteria.Controls.Add(this.FCFS);
            this.Criteria.Controls.Add(this.RR);
            this.Criteria.Controls.Add(this.SJF_PRE);
            this.Criteria.Controls.Add(this.Priority_NON);
            this.Criteria.Controls.Add(this.SJF_NON);
            this.Criteria.Controls.Add(this.Priority_PRE);
            this.Criteria.Location = new System.Drawing.Point(12, 116);
            this.Criteria.Name = "Criteria";
            this.Criteria.Size = new System.Drawing.Size(746, 73);
            this.Criteria.TabIndex = 7;
            this.Criteria.TabStop = false;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(15, 35);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(186, 13);
            this.number.TabIndex = 8;
            this.number.Text = "Enter the number of processess";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brust Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arrival Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Priority";
            this.label4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(225, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(225, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(225, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // Add_Process
            // 
            this.Add_Process.Location = new System.Drawing.Point(100, 373);
            this.Add_Process.Name = "Add_Process";
            this.Add_Process.Size = new System.Drawing.Size(75, 23);
            this.Add_Process.TabIndex = 20;
            this.Add_Process.Text = "Add Process";
            this.Add_Process.UseVisualStyleBackColor = true;
            this.Add_Process.Click += new System.EventHandler(this.Add_Process_Click);
            // 
            // Number_of_processes
            // 
            this.Number_of_processes.Location = new System.Drawing.Point(340, 32);
            this.Number_of_processes.Name = "Number_of_processes";
            this.Number_of_processes.Size = new System.Drawing.Size(75, 23);
            this.Number_of_processes.TabIndex = 21;
            this.Number_of_processes.Text = "Enter";
            this.Number_of_processes.UseVisualStyleBackColor = true;
            this.Number_of_processes.Click += new System.EventHandler(this.Number_of_processes_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(563, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Brust     Arrival     Priority  ";
            this.label6.Visible = false;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(594, 373);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 23;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(443, 9);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(345, 101);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Number_of_processes);
            this.Controls.Add(this.Add_Process);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Criteria);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Criteria.ResumeLayout(false);
            this.Criteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FCFS;
        private System.Windows.Forms.RadioButton SJF_PRE;
        private System.Windows.Forms.RadioButton SJF_NON;
        private System.Windows.Forms.RadioButton Priority_PRE;
        private System.Windows.Forms.RadioButton Priority_NON;
        private System.Windows.Forms.RadioButton RR;
        private System.Windows.Forms.GroupBox Criteria;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_Process;
        private System.Windows.Forms.Button Number_of_processes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

