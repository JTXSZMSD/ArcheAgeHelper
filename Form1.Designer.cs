namespace ArcheAgeHelper
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            ButtonPremium1 = new RadioButton();
            ButtonPremium3 = new RadioButton();
            ButtonPremium2 = new RadioButton();
            DailyWP = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 65);
            label1.TabIndex = 0;
            label1.Text = "Hewo";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1184, 761);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(32, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1148, 753);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Главная";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(DailyWP);
            tabPage2.Location = new Point(32, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1148, 753);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Очки работы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(ButtonPremium1);
            panel1.Controls.Add(ButtonPremium3);
            panel1.Controls.Add(ButtonPremium2);
            panel1.Location = new Point(6, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 136);
            panel1.TabIndex = 5;
            // 
            // ButtonPremium1
            // 
            ButtonPremium1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPremium1.AutoSize = true;
            ButtonPremium1.Checked = true;
            ButtonPremium1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPremium1.Location = new Point(3, 4);
            ButtonPremium1.Name = "ButtonPremium1";
            ButtonPremium1.Size = new Size(152, 29);
            ButtonPremium1.TabIndex = 2;
            ButtonPremium1.TabStop = true;
            ButtonPremium1.Text = "Без премиума";
            ButtonPremium1.UseVisualStyleBackColor = true;
            ButtonPremium1.CheckedChanged += ButtonPremium1_CheckedChanged;
            // 
            // ButtonPremium3
            // 
            ButtonPremium3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPremium3.AutoSize = true;
            ButtonPremium3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPremium3.Location = new Point(3, 74);
            ButtonPremium3.Name = "ButtonPremium3";
            ButtonPremium3.Size = new Size(185, 29);
            ButtonPremium3.TabIndex = 4;
            ButtonPremium3.Text = "Премиум + сиоль";
            ButtonPremium3.UseVisualStyleBackColor = true;
            ButtonPremium3.CheckedChanged += ButtonPremium3_CheckedChanged;
            // 
            // ButtonPremium2
            // 
            ButtonPremium2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPremium2.AutoSize = true;
            ButtonPremium2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPremium2.Location = new Point(3, 39);
            ButtonPremium2.Name = "ButtonPremium2";
            ButtonPremium2.Size = new Size(172, 29);
            ButtonPremium2.TabIndex = 3;
            ButtonPremium2.Text = "Премиум/Сиоль";
            ButtonPremium2.UseVisualStyleBackColor = true;
            ButtonPremium2.CheckedChanged += ButtonPremium2_CheckedChanged;
            // 
            // DailyWP
            // 
            DailyWP.AutoSize = true;
            DailyWP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DailyWP.Location = new Point(6, 147);
            DailyWP.Name = "DailyWP";
            DailyWP.Size = new Size(370, 25);
            DailyWP.TabIndex = 0;
            DailyWP.Text = "В день получается 1440 очков работы";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "AAhelper";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label DailyWP;
        private RadioButton ButtonPremium3;
        private RadioButton ButtonPremium2;
        private RadioButton ButtonPremium1;
        private Panel panel1;
    }
}