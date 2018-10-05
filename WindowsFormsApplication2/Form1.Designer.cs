namespace WindowsFormsApplication2
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
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddL = new System.Windows.Forms.Label();
            this.lblEql = new System.Windows.Forms.Label();
            this.lblAddR = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.diff = new System.Windows.Forms.NumericUpDown();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblSubR = new System.Windows.Forms.Label();
            this.lblEql2 = new System.Windows.Forms.Label();
            this.lblSubL = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMulR = new System.Windows.Forms.Label();
            this.lblEql3 = new System.Windows.Forms.Label();
            this.lblMulL = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDivR = new System.Windows.Forms.Label();
            this.lblEql4 = new System.Windows.Forms.Label();
            this.lblDivL = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(196, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 30);
            this.lblTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // lblAddL
            // 
            this.lblAddL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddL.Location = new System.Drawing.Point(58, 94);
            this.lblAddL.Name = "lblAddL";
            this.lblAddL.Size = new System.Drawing.Size(60, 50);
            this.lblAddL.TabIndex = 2;
            this.lblAddL.Text = "?";
            this.lblAddL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEql
            // 
            this.lblEql.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEql.Location = new System.Drawing.Point(256, 94);
            this.lblEql.Name = "lblEql";
            this.lblEql.Size = new System.Drawing.Size(60, 50);
            this.lblEql.TabIndex = 3;
            this.lblEql.Text = "=";
            this.lblEql.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddR
            // 
            this.lblAddR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddR.Location = new System.Drawing.Point(190, 94);
            this.lblAddR.Name = "lblAddR";
            this.lblAddR.Size = new System.Drawing.Size(60, 50);
            this.lblAddR.TabIndex = 4;
            this.lblAddR.Text = "?";
            this.lblAddR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdd
            // 
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(124, 94);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(60, 50);
            this.lblAdd.TabIndex = 5;
            this.lblAdd.Text = "+";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(322, 99);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 41);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.answer_Check);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // diff
            // 
            this.diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff.Location = new System.Drawing.Point(322, 149);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(120, 41);
            this.diff.TabIndex = 3;
            this.diff.ValueChanged += new System.EventHandler(this.answer_Check);
            this.diff.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lblMinus
            // 
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(124, 144);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(60, 50);
            this.lblMinus.TabIndex = 10;
            this.lblMinus.Text = "-";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubR
            // 
            this.lblSubR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubR.Location = new System.Drawing.Point(190, 144);
            this.lblSubR.Name = "lblSubR";
            this.lblSubR.Size = new System.Drawing.Size(60, 50);
            this.lblSubR.TabIndex = 9;
            this.lblSubR.Text = "?";
            this.lblSubR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEql2
            // 
            this.lblEql2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEql2.Location = new System.Drawing.Point(256, 144);
            this.lblEql2.Name = "lblEql2";
            this.lblEql2.Size = new System.Drawing.Size(60, 50);
            this.lblEql2.TabIndex = 8;
            this.lblEql2.Text = "=";
            this.lblEql2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubL
            // 
            this.lblSubL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubL.Location = new System.Drawing.Point(58, 144);
            this.lblSubL.Name = "lblSubL";
            this.lblSubL.Size = new System.Drawing.Size(60, 50);
            this.lblSubL.TabIndex = 7;
            this.lblSubL.Text = "?";
            this.lblSubL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(322, 199);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 41);
            this.product.TabIndex = 4;
            this.product.ValueChanged += new System.EventHandler(this.answer_Check);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 15;
            this.label9.Text = "×";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMulR
            // 
            this.lblMulR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulR.Location = new System.Drawing.Point(190, 194);
            this.lblMulR.Name = "lblMulR";
            this.lblMulR.Size = new System.Drawing.Size(60, 50);
            this.lblMulR.TabIndex = 14;
            this.lblMulR.Text = "?";
            this.lblMulR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEql3
            // 
            this.lblEql3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEql3.Location = new System.Drawing.Point(256, 194);
            this.lblEql3.Name = "lblEql3";
            this.lblEql3.Size = new System.Drawing.Size(60, 50);
            this.lblEql3.TabIndex = 13;
            this.lblEql3.Text = "=";
            this.lblEql3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMulL
            // 
            this.lblMulL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulL.Location = new System.Drawing.Point(58, 194);
            this.lblMulL.Name = "lblMulL";
            this.lblMulL.Size = new System.Drawing.Size(60, 50);
            this.lblMulL.TabIndex = 12;
            this.lblMulL.Text = "?";
            this.lblMulL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(322, 249);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 41);
            this.quotient.TabIndex = 5;
            this.quotient.ValueChanged += new System.EventHandler(this.answer_Check);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(124, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 20;
            this.label13.Text = "÷";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivR
            // 
            this.lblDivR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivR.Location = new System.Drawing.Point(190, 244);
            this.lblDivR.Name = "lblDivR";
            this.lblDivR.Size = new System.Drawing.Size(60, 50);
            this.lblDivR.TabIndex = 19;
            this.lblDivR.Text = "?";
            this.lblDivR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEql4
            // 
            this.lblEql4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEql4.Location = new System.Drawing.Point(256, 244);
            this.lblEql4.Name = "lblEql4";
            this.lblEql4.Size = new System.Drawing.Size(60, 50);
            this.lblEql4.TabIndex = 18;
            this.lblEql4.Text = "=";
            this.lblEql4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivL
            // 
            this.lblDivL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivL.Location = new System.Drawing.Point(58, 244);
            this.lblDivL.Name = "lblDivL";
            this.lblDivL.Size = new System.Drawing.Size(60, 50);
            this.lblDivL.TabIndex = 17;
            this.lblDivL.Text = "?";
            this.lblDivL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(155, 302);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start the quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDivR);
            this.Controls.Add(this.lblEql4);
            this.Controls.Add(this.lblDivL);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMulR);
            this.Controls.Add(this.lblEql3);
            this.Controls.Add(this.lblMulL);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblSubR);
            this.Controls.Add(this.lblEql2);
            this.Controls.Add(this.lblSubL);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblAddR);
            this.Controls.Add(this.lblEql);
            this.Controls.Add(this.lblAddL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddL;
        private System.Windows.Forms.Label lblEql;
        private System.Windows.Forms.Label lblAddR;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown diff;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblSubR;
        private System.Windows.Forms.Label lblEql2;
        private System.Windows.Forms.Label lblSubL;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMulR;
        private System.Windows.Forms.Label lblEql3;
        private System.Windows.Forms.Label lblMulL;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDivR;
        private System.Windows.Forms.Label lblEql4;
        private System.Windows.Forms.Label lblDivL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

