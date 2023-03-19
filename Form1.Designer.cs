namespace WindowsFormsApp_exam0211
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
            this.InchBox = new System.Windows.Forms.TextBox();
            this.Inch2cm = new System.Windows.Forms.Button();
            this.cmLabel = new System.Windows.Forms.Label();
            this.kgBox = new System.Windows.Forms.TextBox();
            this.kg2pound = new System.Windows.Forms.Button();
            this.poundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InchBox
            // 
            this.InchBox.Location = new System.Drawing.Point(23, 67);
            this.InchBox.Name = "InchBox";
            this.InchBox.Size = new System.Drawing.Size(100, 21);
            this.InchBox.TabIndex = 0;
            this.InchBox.Text = "0";
            this.InchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.InchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InchBox_KeyPress);
            // 
            // Inch2cm
            // 
            this.Inch2cm.Location = new System.Drawing.Point(173, 64);
            this.Inch2cm.Name = "Inch2cm";
            this.Inch2cm.Size = new System.Drawing.Size(75, 23);
            this.Inch2cm.TabIndex = 1;
            this.Inch2cm.Text = "Inch2cm";
            this.Inch2cm.UseVisualStyleBackColor = true;
            this.Inch2cm.Click += new System.EventHandler(this.Inch2cm_Click);
            // 
            // cmLabel
            // 
            this.cmLabel.AutoSize = true;
            this.cmLabel.Location = new System.Drawing.Point(304, 74);
            this.cmLabel.Name = "cmLabel";
            this.cmLabel.Size = new System.Drawing.Size(11, 12);
            this.cmLabel.TabIndex = 2;
            this.cmLabel.Text = "0";
            this.cmLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // kgBox
            // 
            this.kgBox.Location = new System.Drawing.Point(23, 122);
            this.kgBox.Name = "kgBox";
            this.kgBox.Size = new System.Drawing.Size(100, 21);
            this.kgBox.TabIndex = 3;
            this.kgBox.Text = "0";
            this.kgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kgBox.TextChanged += new System.EventHandler(this.kgBox_TextChanged);
            this.kgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kgBox_KeyPress);
            // 
            // kg2pound
            // 
            this.kg2pound.Location = new System.Drawing.Point(173, 122);
            this.kg2pound.Name = "kg2pound";
            this.kg2pound.Size = new System.Drawing.Size(75, 23);
            this.kg2pound.TabIndex = 4;
            this.kg2pound.Text = "button1";
            this.kg2pound.UseVisualStyleBackColor = true;
            this.kg2pound.Click += new System.EventHandler(this.kg2pound_Click);
            // 
            // poundLabel
            // 
            this.poundLabel.AutoSize = true;
            this.poundLabel.Location = new System.Drawing.Point(304, 133);
            this.poundLabel.Name = "poundLabel";
            this.poundLabel.Size = new System.Drawing.Size(11, 12);
            this.poundLabel.TabIndex = 5;
            this.poundLabel.Text = "0";
            this.poundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.poundLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.poundLabel);
            this.Controls.Add(this.kg2pound);
            this.Controls.Add(this.kgBox);
            this.Controls.Add(this.cmLabel);
            this.Controls.Add(this.Inch2cm);
            this.Controls.Add(this.InchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InchBox;
        private System.Windows.Forms.Button Inch2cm;
        private System.Windows.Forms.Label cmLabel;
        private System.Windows.Forms.TextBox kgBox;
        private System.Windows.Forms.Button kg2pound;
        private System.Windows.Forms.Label poundLabel;
    }
}

