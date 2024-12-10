namespace WinForms.CalulateArea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtRadius = new TextBox();
            label2 = new Label();
            txtHeight = new TextBox();
            txtWidth = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHexagonWidth = new TextBox();
            lblResult = new Label();
            label6 = new Label();
            btnCircleArea = new Button();
            btnTriangleArea = new Button();
            btnHexagonArea = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "รัศมี";
            // 
            // txtRadius
            // 
            txtRadius.BorderStyle = BorderStyle.FixedSingle;
            txtRadius.Location = new Point(101, 47);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(125, 29);
            txtRadius.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 50);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "ความสูง";
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Location = new Point(172, 48);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 29);
            txtHeight.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.BorderStyle = BorderStyle.FixedSingle;
            txtWidth.Location = new Point(172, 115);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 29);
            txtWidth.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "ความยาวฐาน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 78);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 6;
            label4.Text = "ความยาวด้าน";
            label4.Click += label4_Click;
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.BorderStyle = BorderStyle.FixedSingle;
            txtHexagonWidth.Location = new Point(157, 76);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(125, 29);
            txtHexagonWidth.TabIndex = 7;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 255);
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(0, 0, 192);
            lblResult.Location = new Point(712, 51);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(281, 159);
            lblResult.TabIndex = 8;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(714, 15);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 9;
            label6.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(273, 39);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(225, 49);
            btnCircleArea.TabIndex = 10;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(340, 65);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(225, 49);
            btnTriangleArea.TabIndex = 11;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(325, 69);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(225, 49);
            btnHexagonArea.TabIndex = 12;
            btnHexagonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 155);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 255);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(28, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(621, 185);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Location = new Point(28, 420);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(621, 188);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(766, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(183, 89);
            btnClear.TabIndex = 16;
            btnClear.Text = "ล้างค่า";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 639);
            Controls.Add(btnClear);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "WinForms.CalculateArea (คำนวณพื้นที่รูปภาพเรขาคณิต)";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadius;
        private Label label2;
        private TextBox txtHeight;
        private TextBox txtWidth;
        private Label label3;
        private Label label4;
        private TextBox txtHexagonWidth;
        private Label lblResult;
        private Label label6;
        private Button btnCircleArea;
        private Button btnTriangleArea;
        private Button btnHexagonArea;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnClear;
    }
}
