namespace OOP_lab4_2
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(59, 224);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(180, 31);
            textBoxA.TabIndex = 0;
            textBoxA.KeyDown += textBoxA_KeyDown;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(309, 224);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(180, 31);
            textBoxB.TabIndex = 1;
            textBoxB.KeyDown += textBoxB_KeyDown;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(554, 224);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(180, 31);
            textBoxC.TabIndex = 2;
            textBoxC.KeyDown += textBoxC_KeyDown;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(59, 293);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(180, 31);
            numericUpDownA.TabIndex = 3;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(309, 293);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(180, 31);
            numericUpDownB.TabIndex = 4;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(554, 293);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(180, 31);
            numericUpDownC.TabIndex = 5;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(59, 353);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(180, 69);
            trackBarA.TabIndex = 6;
            trackBarA.Scroll += trackBarA_Scroll;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(309, 353);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(180, 69);
            trackBarB.TabIndex = 7;
            trackBarB.Scroll += trackBarB_Scroll;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(554, 353);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(180, 69);
            trackBarC.TabIndex = 8;
            trackBarC.Scroll += trackBarC_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 64);
            label1.Name = "label1";
            label1.Size = new Size(116, 128);
            label1.TabIndex = 9;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(347, 64);
            label2.Name = "label2";
            label2.Size = new Size(109, 128);
            label2.TabIndex = 10;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(588, 64);
            label3.Name = "label3";
            label3.Size = new Size(113, 128);
            label3.TabIndex = 11;
            label3.Text = "C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}