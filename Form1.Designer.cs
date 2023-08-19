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
            panel1 = new Panel();
            ButtonPremium1 = new RadioButton();
            ButtonPremium3 = new RadioButton();
            ButtonPremium2 = new RadioButton();
            tabPage2 = new TabPage();
            DailyWP = new Label();
            BlacksmithPage = new TabPage();
            BlacksmithChoose = new ComboBox();
            PotionFiveHours = new Label();
            FirstHourPotion = new Label();
            SecondHourPotion = new Label();
            ThirdHourPotion = new Label();
            FourthHourPotion = new Label();
            FifthHourPotion = new Label();
            TotalPotionWP = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            BlacksmithPage.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(686, 39);
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
            tabControl1.Controls.Add(BlacksmithPage);
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
            tabPage1.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(ButtonPremium1);
            panel1.Controls.Add(ButtonPremium3);
            panel1.Controls.Add(ButtonPremium2);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 136);
            panel1.TabIndex = 6;
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
            ButtonPremium1.CheckedChanged += ButtonPremium_CheckedChanged;
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
            ButtonPremium3.CheckedChanged += ButtonPremium_CheckedChanged;
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
            ButtonPremium2.CheckedChanged += ButtonPremium_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TotalPotionWP);
            tabPage2.Controls.Add(FifthHourPotion);
            tabPage2.Controls.Add(FourthHourPotion);
            tabPage2.Controls.Add(ThirdHourPotion);
            tabPage2.Controls.Add(SecondHourPotion);
            tabPage2.Controls.Add(FirstHourPotion);
            tabPage2.Controls.Add(PotionFiveHours);
            tabPage2.Controls.Add(DailyWP);
            tabPage2.Location = new Point(32, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1148, 753);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Очки работы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DailyWP
            // 
            DailyWP.AutoSize = true;
            DailyWP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DailyWP.Location = new Point(6, 5);
            DailyWP.Name = "DailyWP";
            DailyWP.Size = new Size(370, 25);
            DailyWP.TabIndex = 0;
            DailyWP.Text = "В день получается 1440 очков работы";
            // 
            // BlacksmithPage
            // 
            BlacksmithPage.Controls.Add(BlacksmithChoose);
            BlacksmithPage.Location = new Point(32, 4);
            BlacksmithPage.Name = "BlacksmithPage";
            BlacksmithPage.Padding = new Padding(3);
            BlacksmithPage.Size = new Size(1148, 753);
            BlacksmithPage.TabIndex = 2;
            BlacksmithPage.Text = "Кузнечка";
            BlacksmithPage.UseVisualStyleBackColor = true;
            // 
            // BlacksmithChoose
            // 
            BlacksmithChoose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BlacksmithChoose.FormattingEnabled = true;
            BlacksmithChoose.Items.AddRange(new object[] { "Слиток железа", "Слиток меди", "Слиток метеоритного железа", "Слиток серебра", "Слиток золота", "Слиток акхиума", "Слиток анадия", "Слиток пламенного металла" });
            BlacksmithChoose.Location = new Point(6, 8);
            BlacksmithChoose.Name = "BlacksmithChoose";
            BlacksmithChoose.Size = new Size(209, 29);
            BlacksmithChoose.TabIndex = 0;
            BlacksmithChoose.SelectedIndexChanged += BlacksmithChoose_SelectedIndexChanged;
            // 
            // PotionFiveHours
            // 
            PotionFiveHours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PotionFiveHours.AutoSize = true;
            PotionFiveHours.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            PotionFiveHours.Location = new Point(6, 52);
            PotionFiveHours.Name = "PotionFiveHours";
            PotionFiveHours.Size = new Size(398, 25);
            PotionFiveHours.TabIndex = 1;
            PotionFiveHours.Text = "Настойка трудолюбивого ремесленника:";
            // 
            // FirstHourPotion
            // 
            FirstHourPotion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FirstHourPotion.AutoSize = true;
            FirstHourPotion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FirstHourPotion.Location = new Point(6, 92);
            FirstHourPotion.Name = "FirstHourPotion";
            FirstHourPotion.Size = new Size(291, 25);
            FirstHourPotion.TabIndex = 2;
            FirstHourPotion.Text = "Первый час: 36 очков работы";
            // 
            // SecondHourPotion
            // 
            SecondHourPotion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SecondHourPotion.AutoSize = true;
            SecondHourPotion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            SecondHourPotion.Location = new Point(6, 117);
            SecondHourPotion.Name = "SecondHourPotion";
            SecondHourPotion.Size = new Size(272, 25);
            SecondHourPotion.TabIndex = 3;
            SecondHourPotion.Text = "Второй час: 72 очка работы";
            // 
            // ThirdHourPotion
            // 
            ThirdHourPotion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThirdHourPotion.AutoSize = true;
            ThirdHourPotion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ThirdHourPotion.Location = new Point(6, 142);
            ThirdHourPotion.Name = "ThirdHourPotion";
            ThirdHourPotion.Size = new Size(292, 25);
            ThirdHourPotion.TabIndex = 4;
            ThirdHourPotion.Text = "Третий час: 108 очков работы";
            // 
            // FourthHourPotion
            // 
            FourthHourPotion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FourthHourPotion.AutoSize = true;
            FourthHourPotion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FourthHourPotion.Location = new Point(7, 167);
            FourthHourPotion.Name = "FourthHourPotion";
            FourthHourPotion.Size = new Size(329, 25);
            FourthHourPotion.TabIndex = 5;
            FourthHourPotion.Text = "Четвёртый час: 144 очков работы";
            // 
            // FifthHourPotion
            // 
            FifthHourPotion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FifthHourPotion.AutoSize = true;
            FifthHourPotion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FifthHourPotion.Location = new Point(7, 192);
            FifthHourPotion.Name = "FifthHourPotion";
            FifthHourPotion.Size = new Size(289, 25);
            FifthHourPotion.TabIndex = 6;
            FifthHourPotion.Text = "Пятый час: 180 очков работы";
            // 
            // TotalPotionWP
            // 
            TotalPotionWP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TotalPotionWP.AutoSize = true;
            TotalPotionWP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TotalPotionWP.Location = new Point(7, 217);
            TotalPotionWP.Name = "TotalPotionWP";
            TotalPotionWP.Size = new Size(341, 25);
            TotalPotionWP.TabIndex = 7;
            TotalPotionWP.Text = "Всего за 5 часов: 540 очков работы";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            BlacksmithPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label SecondHourPotion;
        private Label DailyWP;
        private Panel panel1;
        private RadioButton ButtonPremium1;
        private RadioButton ButtonPremium3;
        private RadioButton ButtonPremium2;
        private TabPage BlacksmithPage;
        private ComboBox BlacksmithChoose;
        private Label PotionFiveHours;
        private Label FirstHourPotion;
        private Label TotalPotionWP;
        private Label FifthHourPotion;
        private Label FourthHourPotion;
        private Label ThirdHourPotion;
    }
}