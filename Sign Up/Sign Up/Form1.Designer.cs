﻿
namespace Sign_Up
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLight = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox3 = new ns1.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox4 = new ns1.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(337, 628);
            this.panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "We Create, We Design\r\n     We Develop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelLight
            // 
            this.panelLight.Controls.Add(this.bunifuCheckbox1);
            this.panelLight.Controls.Add(this.button1);
            this.panelLight.Controls.Add(this.bunifuMaterialTextbox4);
            this.panelLight.Controls.Add(this.label7);
            this.panelLight.Controls.Add(this.label6);
            this.panelLight.Controls.Add(this.bunifuMaterialTextbox3);
            this.panelLight.Controls.Add(this.label5);
            this.panelLight.Controls.Add(this.bunifuMaterialTextbox2);
            this.panelLight.Controls.Add(this.label4);
            this.panelLight.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelLight.Controls.Add(this.label3);
            this.panelLight.Controls.Add(this.label2);
            this.panelLight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLight.Location = new System.Drawing.Point(335, 0);
            this.panelLight.Name = "panelLight";
            this.panelLight.Size = new System.Drawing.Size(514, 628);
            this.panelLight.TabIndex = 1;
            this.panelLight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLight_Paint);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Full Name";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(29, 103);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(453, 44);
            this.bunifuMaterialTextbox1.TabIndex = 2;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(454, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password :";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "Password";
            this.bunifuMaterialTextbox2.isPassword = true;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(29, 180);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(453, 44);
            this.bunifuMaterialTextbox2.TabIndex = 2;
            this.bunifuMaterialTextbox2.Text = "Full Name";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(25, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Re-Enter Password";
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "Password";
            this.bunifuMaterialTextbox3.isPassword = true;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(29, 257);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(453, 44);
            this.bunifuMaterialTextbox3.TabIndex = 2;
            this.bunifuMaterialTextbox3.Text = "Full Name";
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(25, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "someone@example.com";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(29, 334);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(453, 44);
            this.bunifuMaterialTextbox4.TabIndex = 2;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(76, 430);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(118, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "I Agree Terms and Conditons";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 628);
            this.Controls.Add(this.panelLight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLight.ResumeLayout(false);
            this.panelLight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Button button1;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label7;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}

