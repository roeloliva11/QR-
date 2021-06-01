namespace steg
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.atmpCounterLBL = new System.Windows.Forms.Label();
            this.SecsLBL = new System.Windows.Forms.Label();
            this.timeremainLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PublicipLBL = new System.Windows.Forms.Label();
            this.LocalipLBL = new System.Windows.Forms.Label();
            this.MachineLBL = new System.Windows.Forms.Label();
            this.IdipBLockLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(178, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(178, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(320, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // atmpCounterLBL
            // 
            this.atmpCounterLBL.AutoSize = true;
            this.atmpCounterLBL.Location = new System.Drawing.Point(216, 403);
            this.atmpCounterLBL.Name = "atmpCounterLBL";
            this.atmpCounterLBL.Size = new System.Drawing.Size(87, 17);
            this.atmpCounterLBL.TabIndex = 6;
            this.atmpCounterLBL.Text = "atmpcounter";
            this.atmpCounterLBL.Click += new System.EventHandler(this.atmpCounterLBL_Click);
            // 
            // SecsLBL
            // 
            this.SecsLBL.AutoSize = true;
            this.SecsLBL.Location = new System.Drawing.Point(56, 198);
            this.SecsLBL.Name = "SecsLBL";
            this.SecsLBL.Size = new System.Drawing.Size(68, 17);
            this.SecsLBL.TabIndex = 7;
            this.SecsLBL.Text = "Secs LBL";
            // 
            // timeremainLBL
            // 
            this.timeremainLBL.AutoSize = true;
            this.timeremainLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeremainLBL.Location = new System.Drawing.Point(45, 227);
            this.timeremainLBL.Name = "timeremainLBL";
            this.timeremainLBL.Size = new System.Drawing.Size(127, 25);
            this.timeremainLBL.TabIndex = 8;
            this.timeremainLBL.Text = "Remain Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(205, 272);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 25);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PublicipLBL
            // 
            this.PublicipLBL.AutoSize = true;
            this.PublicipLBL.Location = new System.Drawing.Point(48, 376);
            this.PublicipLBL.Name = "PublicipLBL";
            this.PublicipLBL.Size = new System.Drawing.Size(61, 17);
            this.PublicipLBL.TabIndex = 10;
            this.PublicipLBL.Text = "Public Ip";
            // 
            // LocalipLBL
            // 
            this.LocalipLBL.AutoSize = true;
            this.LocalipLBL.Location = new System.Drawing.Point(48, 403);
            this.LocalipLBL.Name = "LocalipLBL";
            this.LocalipLBL.Size = new System.Drawing.Size(52, 17);
            this.LocalipLBL.TabIndex = 11;
            this.LocalipLBL.Text = "local Ip";
            // 
            // MachineLBL
            // 
            this.MachineLBL.AutoSize = true;
            this.MachineLBL.Location = new System.Drawing.Point(48, 351);
            this.MachineLBL.Name = "MachineLBL";
            this.MachineLBL.Size = new System.Drawing.Size(102, 17);
            this.MachineLBL.TabIndex = 12;
            this.MachineLBL.Text = "Machine Name";
            // 
            // IdipBLockLBL
            // 
            this.IdipBLockLBL.AutoSize = true;
            this.IdipBLockLBL.Location = new System.Drawing.Point(216, 376);
            this.IdipBLockLBL.Name = "IdipBLockLBL";
            this.IdipBLockLBL.Size = new System.Drawing.Size(136, 17);
            this.IdipBLockLBL.TabIndex = 13;
            this.IdipBLockLBL.Text = "id ip block reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Account Login ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(465, 320);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdipBLockLBL);
            this.Controls.Add(this.MachineLBL);
            this.Controls.Add(this.LocalipLBL);
            this.Controls.Add(this.PublicipLBL);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.timeremainLBL);
            this.Controls.Add(this.SecsLBL);
            this.Controls.Add(this.atmpCounterLBL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label atmpCounterLBL;
        private System.Windows.Forms.Label SecsLBL;
        private System.Windows.Forms.Label timeremainLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label PublicipLBL;
        private System.Windows.Forms.Label LocalipLBL;
        private System.Windows.Forms.Label MachineLBL;
        private System.Windows.Forms.Label IdipBLockLBL;
        private System.Windows.Forms.Label label3;
    }
}