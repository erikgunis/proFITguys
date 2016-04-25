namespace Calculator
{
	/// <summary>
    /// graficke rozhrani
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"> true if managed resources should be disposed; otherwise, false. </param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_n7 = new System.Windows.Forms.Button();
            this.button_n8 = new System.Windows.Forms.Button();
            this.button_n9 = new System.Windows.Forms.Button();
            this.button_n4 = new System.Windows.Forms.Button();
            this.button_n5 = new System.Windows.Forms.Button();
            this.button_n6 = new System.Windows.Forms.Button();
            this.button_n1 = new System.Windows.Forms.Button();
            this.button_n2 = new System.Windows.Forms.Button();
            this.button_n3 = new System.Windows.Forms.Button();
            this.button_n0 = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_exp = new System.Windows.Forms.Button();
            this.button_fact = new System.Windows.Forms.Button();
            this.label_operations = new System.Windows.Forms.Label();
            this.button_modulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(14, 40);
            this.textBox1.MaxLength = 39;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button_n7
            // 
            this.button_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n7.Location = new System.Drawing.Point(14, 74);
            this.button_n7.Name = "button_n7";
            this.button_n7.Size = new System.Drawing.Size(49, 36);
            this.button_n7.TabIndex = 1;
            this.button_n7.Text = "7";
            this.button_n7.UseVisualStyleBackColor = true;
            this.button_n7.Click += new System.EventHandler(this.button_n7_Click);
            // 
            // button_n8
            // 
            this.button_n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n8.Location = new System.Drawing.Point(69, 74);
            this.button_n8.Name = "button_n8";
            this.button_n8.Size = new System.Drawing.Size(49, 36);
            this.button_n8.TabIndex = 2;
            this.button_n8.Text = "8";
            this.button_n8.UseVisualStyleBackColor = true;
            this.button_n8.Click += new System.EventHandler(this.button_n8_Click);
            // 
            // button_n9
            // 
            this.button_n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n9.Location = new System.Drawing.Point(124, 74);
            this.button_n9.Name = "button_n9";
            this.button_n9.Size = new System.Drawing.Size(49, 36);
            this.button_n9.TabIndex = 3;
            this.button_n9.Text = "9";
            this.button_n9.UseVisualStyleBackColor = true;
            this.button_n9.Click += new System.EventHandler(this.button_n9_Click);
            // 
            // button_n4
            // 
            this.button_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n4.Location = new System.Drawing.Point(14, 116);
            this.button_n4.Name = "button_n4";
            this.button_n4.Size = new System.Drawing.Size(49, 36);
            this.button_n4.TabIndex = 4;
            this.button_n4.Text = "4";
            this.button_n4.UseVisualStyleBackColor = true;
            this.button_n4.Click += new System.EventHandler(this.button_n4_Click);
            // 
            // button_n5
            // 
            this.button_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n5.Location = new System.Drawing.Point(69, 116);
            this.button_n5.Name = "button_n5";
            this.button_n5.Size = new System.Drawing.Size(49, 36);
            this.button_n5.TabIndex = 5;
            this.button_n5.Text = "5";
            this.button_n5.UseVisualStyleBackColor = true;
            this.button_n5.Click += new System.EventHandler(this.button_n5_Click);
            // 
            // button_n6
            // 
            this.button_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n6.Location = new System.Drawing.Point(124, 116);
            this.button_n6.Name = "button_n6";
            this.button_n6.Size = new System.Drawing.Size(49, 36);
            this.button_n6.TabIndex = 6;
            this.button_n6.Text = "6";
            this.button_n6.UseVisualStyleBackColor = true;
            this.button_n6.Click += new System.EventHandler(this.button_n6_Click);
            // 
            // button_n1
            // 
            this.button_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n1.Location = new System.Drawing.Point(14, 158);
            this.button_n1.Name = "button_n1";
            this.button_n1.Size = new System.Drawing.Size(49, 36);
            this.button_n1.TabIndex = 7;
            this.button_n1.Text = "1";
            this.button_n1.UseVisualStyleBackColor = true;
            this.button_n1.Click += new System.EventHandler(this.button_n1_Click);
            // 
            // button_n2
            // 
            this.button_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n2.Location = new System.Drawing.Point(69, 158);
            this.button_n2.Name = "button_n2";
            this.button_n2.Size = new System.Drawing.Size(49, 36);
            this.button_n2.TabIndex = 8;
            this.button_n2.Text = "2";
            this.button_n2.UseVisualStyleBackColor = true;
            this.button_n2.Click += new System.EventHandler(this.button_n2_Click);
            // 
            // button_n3
            // 
            this.button_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n3.Location = new System.Drawing.Point(124, 158);
            this.button_n3.Name = "button_n3";
            this.button_n3.Size = new System.Drawing.Size(49, 36);
            this.button_n3.TabIndex = 9;
            this.button_n3.Text = "3";
            this.button_n3.UseVisualStyleBackColor = true;
            this.button_n3.Click += new System.EventHandler(this.button_n3_Click);
            // 
            // button_n0
            // 
            this.button_n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_n0.Location = new System.Drawing.Point(14, 200);
            this.button_n0.Name = "button_n0";
            this.button_n0.Size = new System.Drawing.Size(49, 36);
            this.button_n0.TabIndex = 10;
            this.button_n0.Text = "0";
            this.button_n0.UseVisualStyleBackColor = true;
            this.button_n0.Click += new System.EventHandler(this.button_n0_Click);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mul.Location = new System.Drawing.Point(179, 116);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(49, 36);
            this.button_mul.TabIndex = 12;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_plus.Location = new System.Drawing.Point(179, 158);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(49, 36);
            this.button_plus.TabIndex = 13;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dot.Location = new System.Drawing.Point(69, 200);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(49, 36);
            this.button_dot.TabIndex = 15;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_c
            // 
            this.button_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_c.Location = new System.Drawing.Point(179, 200);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(49, 36);
            this.button_c.TabIndex = 16;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_div.Location = new System.Drawing.Point(234, 116);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(49, 36);
            this.button_div.TabIndex = 17;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_minus.Location = new System.Drawing.Point(234, 159);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(49, 35);
            this.button_minus.TabIndex = 18;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_equals
            // 
            this.button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_equals.Location = new System.Drawing.Point(124, 200);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(49, 36);
            this.button_equals.TabIndex = 19;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_exp
            // 
            this.button_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exp.Location = new System.Drawing.Point(179, 74);
            this.button_exp.Name = "button_exp";
            this.button_exp.Size = new System.Drawing.Size(49, 36);
            this.button_exp.TabIndex = 20;
            this.button_exp.Text = "x^n";
            this.button_exp.UseVisualStyleBackColor = true;
            this.button_exp.Click += new System.EventHandler(this.button_exp_Click);
            // 
            // button_fact
            // 
            this.button_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_fact.Location = new System.Drawing.Point(234, 74);
            this.button_fact.Name = "button_fact";
            this.button_fact.Size = new System.Drawing.Size(49, 36);
            this.button_fact.TabIndex = 21;
            this.button_fact.Text = "x!";
            this.button_fact.UseVisualStyleBackColor = true;
            this.button_fact.Click += new System.EventHandler(this.button_fact_Click);
            // 
            // label_operations
            // 
            this.label_operations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_operations.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_operations.Location = new System.Drawing.Point(17, 11);
            this.label_operations.Name = "label_operations";
            this.label_operations.Size = new System.Drawing.Size(266, 22);
            this.label_operations.TabIndex = 22;
            this.label_operations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_modulo
            // 
            this.button_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_modulo.Location = new System.Drawing.Point(235, 200);
            this.button_modulo.Name = "button_modulo";
            this.button_modulo.Size = new System.Drawing.Size(48, 36);
            this.button_modulo.TabIndex = 23;
            this.button_modulo.Text = "MOD";
            this.button_modulo.UseVisualStyleBackColor = true;
            this.button_modulo.Click += new System.EventHandler(this.button_modulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 248);
            this.Controls.Add(this.button_modulo);
            this.Controls.Add(this.label_operations);
            this.Controls.Add(this.button_fact);
            this.Controls.Add(this.button_exp);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_n0);
            this.Controls.Add(this.button_n3);
            this.Controls.Add(this.button_n2);
            this.Controls.Add(this.button_n1);
            this.Controls.Add(this.button_n6);
            this.Controls.Add(this.button_n5);
            this.Controls.Add(this.button_n4);
            this.Controls.Add(this.button_n9);
            this.Controls.Add(this.button_n8);
            this.Controls.Add(this.button_n7);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_Press);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_n7;
        private System.Windows.Forms.Button button_n8;
        private System.Windows.Forms.Button button_n9;
        private System.Windows.Forms.Button button_n4;
        private System.Windows.Forms.Button button_n5;
        private System.Windows.Forms.Button button_n6;
        private System.Windows.Forms.Button button_n1;
        private System.Windows.Forms.Button button_n2;
        private System.Windows.Forms.Button button_n3;
        private System.Windows.Forms.Button button_n0;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_exp;
        private System.Windows.Forms.Button button_fact;
        private System.Windows.Forms.Label label_operations;
        private System.Windows.Forms.Button button_modulo;
    }
}

