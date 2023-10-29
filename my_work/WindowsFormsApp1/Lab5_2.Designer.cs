namespace WindowsFormsApp1
{
    partial class Lab5_2
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
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Form1 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(37, 24);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(48, 20);
            this.txtMinutes.TabIndex = 0;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(140, 24);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(48, 20);
            this.txtSeconds.TabIndex = 1;
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(177, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сек";
            // 
            // Form1
            // 
            this.Form1.Location = new System.Drawing.Point(6, 118);
            this.Form1.Name = "Form1";
            this.Form1.Size = new System.Drawing.Size(54, 22);
            this.Form1.TabIndex = 5;
            this.Form1.Text = "For";
            this.Form1.UseVisualStyleBackColor = true;
            this.Form1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(102, 122);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(30, 13);
            this.txtData.TabIndex = 6;
            this.txtData.Text = "Date";
            // 
            // Data
            // 
            this.Data.Tick += new System.EventHandler(this.Data_Tick);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(177, 122);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Сброс";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Lab5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 152);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.Form1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Name = "Lab5_2";
            this.Text = "Секундомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Form1;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Timer Data;
        private System.Windows.Forms.Button Clear;
    }
}