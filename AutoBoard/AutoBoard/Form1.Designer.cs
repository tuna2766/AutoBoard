namespace AutoBoard
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BoardKey1 = new System.Windows.Forms.TextBox();
            this.TimeCloser1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeCloser2 = new System.Windows.Forms.NumericUpDown();
            this.BoardKey2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TimeCloser3 = new System.Windows.Forms.NumericUpDown();
            this.BoardKey3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.TimeCloser4 = new System.Windows.Forms.NumericUpDown();
            this.BoardKey4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.TimeCloser5 = new System.Windows.Forms.NumericUpDown();
            this.BoardKey5 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.TimeCloser6 = new System.Windows.Forms.NumericUpDown();
            this.BoardKey6 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.TimeCloser7 = new System.Windows.Forms.NumericUpDown();
            this.BoardKey7 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser7)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(451, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "啟動";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BoardKey1
            // 
            this.BoardKey1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey1.Location = new System.Drawing.Point(47, 160);
            this.BoardKey1.Name = "BoardKey1";
            this.BoardKey1.Size = new System.Drawing.Size(100, 36);
            this.BoardKey1.TabIndex = 1;
            this.BoardKey1.TextChanged += new System.EventHandler(this.BoardKey1_TextChanged);
            // 
            // TimeCloser1
            // 
            this.TimeCloser1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser1.Location = new System.Drawing.Point(250, 160);
            this.TimeCloser1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser1.Name = "TimeCloser1";
            this.TimeCloser1.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser1.TabIndex = 2;
            this.TimeCloser1.ValueChanged += new System.EventHandler(this.TimeCloser1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "鍵盤鍵";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(215, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "延遲秒數";
            // 
            // TimeCloser2
            // 
            this.TimeCloser2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser2.Location = new System.Drawing.Point(250, 242);
            this.TimeCloser2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser2.Name = "TimeCloser2";
            this.TimeCloser2.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser2.TabIndex = 7;
            this.TimeCloser2.ValueChanged += new System.EventHandler(this.TimeCloser2_ValueChanged);
            // 
            // BoardKey2
            // 
            this.BoardKey2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey2.Location = new System.Drawing.Point(47, 241);
            this.BoardKey2.Name = "BoardKey2";
            this.BoardKey2.Size = new System.Drawing.Size(100, 36);
            this.BoardKey2.TabIndex = 6;
            this.BoardKey2.TextChanged += new System.EventHandler(this.BoardKey2_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(451, 244);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 33);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "啟動";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "0秒會當機";
            // 
            // TimeCloser3
            // 
            this.TimeCloser3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser3.Location = new System.Drawing.Point(250, 322);
            this.TimeCloser3.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser3.Name = "TimeCloser3";
            this.TimeCloser3.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser3.TabIndex = 11;
            this.TimeCloser3.ValueChanged += new System.EventHandler(this.TimeCloser3_ValueChanged);
            // 
            // BoardKey3
            // 
            this.BoardKey3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey3.Location = new System.Drawing.Point(47, 321);
            this.BoardKey3.Name = "BoardKey3";
            this.BoardKey3.Size = new System.Drawing.Size(100, 36);
            this.BoardKey3.TabIndex = 10;
            this.BoardKey3.TextChanged += new System.EventHandler(this.BoardKey3_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox3.Location = new System.Drawing.Point(451, 324);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 33);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "啟動";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // TimeCloser4
            // 
            this.TimeCloser4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser4.Location = new System.Drawing.Point(250, 402);
            this.TimeCloser4.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser4.Name = "TimeCloser4";
            this.TimeCloser4.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser4.TabIndex = 14;
            this.TimeCloser4.ValueChanged += new System.EventHandler(this.TimeCloser4_ValueChanged);
            // 
            // BoardKey4
            // 
            this.BoardKey4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey4.Location = new System.Drawing.Point(47, 399);
            this.BoardKey4.Name = "BoardKey4";
            this.BoardKey4.Size = new System.Drawing.Size(100, 36);
            this.BoardKey4.TabIndex = 13;
            this.BoardKey4.TextChanged += new System.EventHandler(this.BoardKey4_TextChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox4.Location = new System.Drawing.Point(451, 402);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(103, 33);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "啟動";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // TimeCloser5
            // 
            this.TimeCloser5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser5.Location = new System.Drawing.Point(250, 481);
            this.TimeCloser5.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser5.Name = "TimeCloser5";
            this.TimeCloser5.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser5.TabIndex = 17;
            this.TimeCloser5.ValueChanged += new System.EventHandler(this.TimeCloser5_ValueChanged);
            // 
            // BoardKey5
            // 
            this.BoardKey5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey5.Location = new System.Drawing.Point(47, 478);
            this.BoardKey5.Name = "BoardKey5";
            this.BoardKey5.Size = new System.Drawing.Size(100, 36);
            this.BoardKey5.TabIndex = 16;
            this.BoardKey5.TextChanged += new System.EventHandler(this.BoardKey5_TextChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox5.Location = new System.Drawing.Point(451, 481);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(103, 33);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "啟動";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // TimeCloser6
            // 
            this.TimeCloser6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser6.Location = new System.Drawing.Point(250, 553);
            this.TimeCloser6.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser6.Name = "TimeCloser6";
            this.TimeCloser6.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser6.TabIndex = 20;
            this.TimeCloser6.ValueChanged += new System.EventHandler(this.TimeCloser6_ValueChanged);
            // 
            // BoardKey6
            // 
            this.BoardKey6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey6.Location = new System.Drawing.Point(47, 550);
            this.BoardKey6.Name = "BoardKey6";
            this.BoardKey6.Size = new System.Drawing.Size(100, 36);
            this.BoardKey6.TabIndex = 19;
            this.BoardKey6.TextChanged += new System.EventHandler(this.BoardKey6_TextChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox6.Location = new System.Drawing.Point(451, 553);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(103, 33);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "啟動";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // TimeCloser7
            // 
            this.TimeCloser7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeCloser7.Location = new System.Drawing.Point(250, 629);
            this.TimeCloser7.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeCloser7.Name = "TimeCloser7";
            this.TimeCloser7.Size = new System.Drawing.Size(120, 36);
            this.TimeCloser7.TabIndex = 23;
            this.TimeCloser7.ValueChanged += new System.EventHandler(this.TimeCloser7_ValueChanged);
            // 
            // BoardKey7
            // 
            this.BoardKey7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BoardKey7.Location = new System.Drawing.Point(47, 626);
            this.BoardKey7.Name = "BoardKey7";
            this.BoardKey7.Size = new System.Drawing.Size(100, 36);
            this.BoardKey7.TabIndex = 22;
            this.BoardKey7.TextChanged += new System.EventHandler(this.BoardKey7_TextChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("新細明體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox7.Location = new System.Drawing.Point(451, 629);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(103, 33);
            this.checkBox7.TabIndex = 21;
            this.checkBox7.Text = "啟動";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "開發者:flicker8815";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 762);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "版本:1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 810);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeCloser7);
            this.Controls.Add(this.BoardKey7);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.TimeCloser6);
            this.Controls.Add(this.BoardKey6);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.TimeCloser5);
            this.Controls.Add(this.BoardKey5);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.TimeCloser4);
            this.Controls.Add(this.BoardKey4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.TimeCloser3);
            this.Controls.Add(this.BoardKey3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeCloser2);
            this.Controls.Add(this.BoardKey2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeCloser1);
            this.Controls.Add(this.BoardKey1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "AutoBoard";
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCloser7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox BoardKey1;
        private System.Windows.Forms.NumericUpDown TimeCloser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TimeCloser2;
        private System.Windows.Forms.TextBox BoardKey2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TimeCloser3;
        private System.Windows.Forms.TextBox BoardKey3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NumericUpDown TimeCloser4;
        private System.Windows.Forms.TextBox BoardKey4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.NumericUpDown TimeCloser5;
        private System.Windows.Forms.TextBox BoardKey5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.NumericUpDown TimeCloser6;
        private System.Windows.Forms.TextBox BoardKey6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.NumericUpDown TimeCloser7;
        private System.Windows.Forms.TextBox BoardKey7;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

