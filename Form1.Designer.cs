namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.countScore = new System.Windows.Forms.Label();
            this.numberA = new System.Windows.Forms.Label();
            this.numberB = new System.Windows.Forms.Label();
            this.simbol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultAnswer = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.timerlb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countScore
            // 
            this.countScore.AutoSize = true;
            this.countScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countScore.ForeColor = System.Drawing.Color.Green;
            this.countScore.Location = new System.Drawing.Point(12, 9);
            this.countScore.Name = "countScore";
            this.countScore.Size = new System.Drawing.Size(55, 13);
            this.countScore.TabIndex = 0;
            this.countScore.Text = "Score: 0";
            this.countScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberA
            // 
            this.numberA.AutoSize = true;
            this.numberA.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberA.Location = new System.Drawing.Point(73, 41);
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(45, 35);
            this.numberA.TabIndex = 1;
            this.numberA.Text = "00";
            // 
            // numberB
            // 
            this.numberB.AutoSize = true;
            this.numberB.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberB.Location = new System.Drawing.Point(193, 41);
            this.numberB.Name = "numberB";
            this.numberB.Size = new System.Drawing.Size(45, 35);
            this.numberB.TabIndex = 3;
            this.numberB.Text = "00";
            // 
            // simbol
            // 
            this.simbol.AutoSize = true;
            this.simbol.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simbol.Location = new System.Drawing.Point(138, 41);
            this.simbol.Name = "simbol";
            this.simbol.Size = new System.Drawing.Size(35, 35);
            this.simbol.TabIndex = 4;
            this.simbol.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // resultAnswer
            // 
            this.resultAnswer.AutoSize = true;
            this.resultAnswer.ForeColor = System.Drawing.Color.Blue;
            this.resultAnswer.Location = new System.Drawing.Point(12, 101);
            this.resultAnswer.Name = "resultAnswer";
            this.resultAnswer.Size = new System.Drawing.Size(37, 13);
            this.resultAnswer.TabIndex = 6;
            this.resultAnswer.Text = "Result";
            this.resultAnswer.Click += new System.EventHandler(this.resultAnswer_Click);
            // 
            // textAnswer
            // 
            this.textAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnswer.Location = new System.Drawing.Point(298, 50);
            this.textAnswer.MaxLength = 4000;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(69, 24);
            this.textAnswer.TabIndex = 7;
            this.textAnswer.TextChanged += new System.EventHandler(this.CheckAmswer);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(373, 41);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(60, 35);
            this.Check.TabIndex = 8;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.CheckButtonClickEvent);
            // 
            // timerlb
            // 
            this.timerlb.AutoSize = true;
            this.timerlb.Location = new System.Drawing.Point(76, 9);
            this.timerlb.Name = "timerlb";
            this.timerlb.Size = new System.Drawing.Size(36, 13);
            this.timerlb.TabIndex = 9;
            this.timerlb.Text = "Timer:";
            this.timerlb.Click += new System.EventHandler(this.timerlb_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 138);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timerlb);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.resultAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simbol);
            this.Controls.Add(this.numberB);
            this.Controls.Add(this.numberA);
            this.Controls.Add(this.countScore);
            this.Name = "Form1";
            this.Text = "Math Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countScore;
        private System.Windows.Forms.Label numberA;
        private System.Windows.Forms.Label numberB;
        private System.Windows.Forms.Label simbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultAnswer;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label timerlb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

