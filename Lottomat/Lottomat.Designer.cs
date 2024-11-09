namespace Lottomat
{
    partial class Lottomat
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
            DrawnNumbers = new Label();
            SelectedNumbers = new Label();
            DrawNumbers = new Button();
            CorrectNumbers = new Label();
            doSimulation = new Button();
            Balance = new Label();
            SuspendLayout();
            // 
            // DrawnNumbers
            // 
            DrawnNumbers.AutoSize = true;
            DrawnNumbers.Location = new Point(30, 192);
            DrawnNumbers.Name = "DrawnNumbers";
            DrawnNumbers.Size = new Size(94, 15);
            DrawnNumbers.TabIndex = 0;
            DrawnNumbers.Text = "Drawn numbers:";
            // 
            // SelectedNumbers
            // 
            SelectedNumbers.AutoSize = true;
            SelectedNumbers.Location = new Point(30, 165);
            SelectedNumbers.Name = "SelectedNumbers";
            SelectedNumbers.Size = new Size(104, 15);
            SelectedNumbers.TabIndex = 1;
            SelectedNumbers.Text = "Selected numbers:";
            // 
            // DrawNumbers
            // 
            DrawNumbers.Location = new Point(27, 277);
            DrawNumbers.Name = "DrawNumbers";
            DrawNumbers.Size = new Size(97, 23);
            DrawNumbers.TabIndex = 2;
            DrawNumbers.Text = "Draw numbers";
            DrawNumbers.UseVisualStyleBackColor = true;
            DrawNumbers.Click += Draw;
            // 
            // CorrectNumbers
            // 
            CorrectNumbers.AutoSize = true;
            CorrectNumbers.Location = new Point(30, 221);
            CorrectNumbers.Name = "CorrectNumbers";
            CorrectNumbers.Size = new Size(99, 15);
            CorrectNumbers.TabIndex = 3;
            CorrectNumbers.Text = "Correct numbers:";
            // 
            // doSimulation
            // 
            doSimulation.Location = new Point(130, 277);
            doSimulation.Name = "doSimulation";
            doSimulation.Size = new Size(97, 23);
            doSimulation.TabIndex = 4;
            doSimulation.Text = "Do simulation";
            doSimulation.UseVisualStyleBackColor = true;
            doSimulation.Click += Simulation;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Location = new Point(30, 248);
            Balance.Name = "Balance";
            Balance.Size = new Size(51, 15);
            Balance.TabIndex = 5;
            Balance.Text = "Balance:";
            // 
            // Lottomat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Balance);
            Controls.Add(doSimulation);
            Controls.Add(CorrectNumbers);
            Controls.Add(DrawNumbers);
            Controls.Add(SelectedNumbers);
            Controls.Add(DrawnNumbers);
            Name = "Lottomat";
            Text = "Lottomat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DrawnNumbers;
        private Label SelectedNumbers;
        private Button DrawNumbers;
        private Label CorrectNumbers;
        private Button doSimulation;
        private Label Balance;
    }
}
