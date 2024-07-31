namespace DemoGiaoDien
{
    partial class Form_Main
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
            this.btn_GenCode = new System.Windows.Forms.Button();
            this.btn_FormB = new System.Windows.Forms.Button();
            this.pn_Interface = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.btn_FormA = new System.Windows.Forms.Button();
            this.btn_GenPanel = new System.Windows.Forms.Button();
            this.btn_GenNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenCode
            // 
            this.btn_GenCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GenCode.Location = new System.Drawing.Point(9, 222);
            this.btn_GenCode.Name = "btn_GenCode";
            this.btn_GenCode.Size = new System.Drawing.Size(129, 56);
            this.btn_GenCode.TabIndex = 12;
            this.btn_GenCode.Text = "Gen DG";
            this.btn_GenCode.UseVisualStyleBackColor = true;
            this.btn_GenCode.Click += new System.EventHandler(this.GenGiaoDien);
            // 
            // btn_FormB
            // 
            this.btn_FormB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FormB.Location = new System.Drawing.Point(9, 88);
            this.btn_FormB.Name = "btn_FormB";
            this.btn_FormB.Size = new System.Drawing.Size(129, 54);
            this.btn_FormB.TabIndex = 11;
            this.btn_FormB.Text = "Mở Form B";
            this.btn_FormB.UseVisualStyleBackColor = true;
            this.btn_FormB.Click += new System.EventHandler(this.OpenFormB);
            // 
            // pn_Interface
            // 
            this.pn_Interface.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Interface.Location = new System.Drawing.Point(144, 12);
            this.pn_Interface.Name = "pn_Interface";
            this.pn_Interface.Size = new System.Drawing.Size(823, 529);
            this.pn_Interface.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(9, 173);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(27, 20);
            this.lb_Time.TabIndex = 9;
            this.lb_Time.Text = "......";
            // 
            // btn_FormA
            // 
            this.btn_FormA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FormA.Location = new System.Drawing.Point(9, 12);
            this.btn_FormA.Name = "btn_FormA";
            this.btn_FormA.Size = new System.Drawing.Size(129, 51);
            this.btn_FormA.TabIndex = 5;
            this.btn_FormA.Text = "Mở Form A";
            this.btn_FormA.UseVisualStyleBackColor = true;
            this.btn_FormA.Click += new System.EventHandler(this.btn_FormA_Click);
            // 
            // btn_GenPanel
            // 
            this.btn_GenPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GenPanel.Location = new System.Drawing.Point(9, 311);
            this.btn_GenPanel.Name = "btn_GenPanel";
            this.btn_GenPanel.Size = new System.Drawing.Size(129, 54);
            this.btn_GenPanel.TabIndex = 13;
            this.btn_GenPanel.Text = "GenPanel";
            this.btn_GenPanel.UseVisualStyleBackColor = true;
            this.btn_GenPanel.Click += new System.EventHandler(this.btn_GenPanel_Click);
            // 
            // btn_GenNew
            // 
            this.btn_GenNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GenNew.Location = new System.Drawing.Point(10, 395);
            this.btn_GenNew.Name = "btn_GenNew";
            this.btn_GenNew.Size = new System.Drawing.Size(128, 52);
            this.btn_GenNew.TabIndex = 14;
            this.btn_GenNew.Text = "GenDG New";
            this.btn_GenNew.UseVisualStyleBackColor = true;
            this.btn_GenNew.Click += new System.EventHandler(this.btn_GenNew_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 549);
            this.Controls.Add(this.btn_GenNew);
            this.Controls.Add(this.btn_GenPanel);
            this.Controls.Add(this.btn_GenCode);
            this.Controls.Add(this.btn_FormB);
            this.Controls.Add(this.pn_Interface);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.btn_FormA);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_GenCode;
        private Button btn_FormB;
        private Panel pn_Interface;
        private Label label3;
        private Label label2;
        private Label lb_Time;
        private Button btn_FormA;
        private Button btn_GenPanel;
        private Button btn_GenNew;
    }
}