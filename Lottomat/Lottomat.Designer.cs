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
            Label_DrawnNumbers = new Label();
            Label_SelectedNumbers = new Label();
            Button_DrawNumbers = new Button();
            Label_CorrectNumbers = new Label();
            Button_DoSimulation = new Button();
            NumericUpDown_NumberOfDraws = new NumericUpDown();
            MaskedTextBox_TicketCost = new MaskedTextBox();
            Label_NumberOfDraws = new Label();
            Label_TicketCost = new Label();
            SimulationTable = new ListView();
            CorrectGuesses = new ColumnHeader();
            NumberOfCorrectGuesses = new ColumnHeader();
            Reward = new ColumnHeader();
            Balance = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_NumberOfDraws).BeginInit();
            SuspendLayout();
            // 
            // Label_DrawnNumbers
            // 
            Label_DrawnNumbers.AutoSize = true;
            Label_DrawnNumbers.Location = new Point(30, 164);
            Label_DrawnNumbers.Name = "Label_DrawnNumbers";
            Label_DrawnNumbers.Size = new Size(94, 15);
            Label_DrawnNumbers.TabIndex = 0;
            Label_DrawnNumbers.Text = "Drawn numbers:";
            // 
            // Label_SelectedNumbers
            // 
            Label_SelectedNumbers.AutoSize = true;
            Label_SelectedNumbers.Location = new Point(30, 137);
            Label_SelectedNumbers.Name = "Label_SelectedNumbers";
            Label_SelectedNumbers.Size = new Size(104, 15);
            Label_SelectedNumbers.TabIndex = 1;
            Label_SelectedNumbers.Text = "Selected numbers:";
            // 
            // Button_DrawNumbers
            // 
            Button_DrawNumbers.Location = new Point(30, 223);
            Button_DrawNumbers.Name = "Button_DrawNumbers";
            Button_DrawNumbers.Size = new Size(97, 23);
            Button_DrawNumbers.TabIndex = 2;
            Button_DrawNumbers.Text = "Draw numbers";
            Button_DrawNumbers.UseVisualStyleBackColor = true;
            Button_DrawNumbers.Click += Draw;
            // 
            // Label_CorrectNumbers
            // 
            Label_CorrectNumbers.AutoSize = true;
            Label_CorrectNumbers.Location = new Point(30, 193);
            Label_CorrectNumbers.Name = "Label_CorrectNumbers";
            Label_CorrectNumbers.Size = new Size(99, 15);
            Label_CorrectNumbers.TabIndex = 3;
            Label_CorrectNumbers.Text = "Correct numbers:";
            // 
            // Button_DoSimulation
            // 
            Button_DoSimulation.Location = new Point(664, 223);
            Button_DoSimulation.Name = "Button_DoSimulation";
            Button_DoSimulation.Size = new Size(97, 23);
            Button_DoSimulation.TabIndex = 4;
            Button_DoSimulation.Text = "Do simulation";
            Button_DoSimulation.UseVisualStyleBackColor = true;
            Button_DoSimulation.Click += Simulation;
            // 
            // NumericUpDown_NumberOfDraws
            // 
            NumericUpDown_NumberOfDraws.Location = new Point(683, 156);
            NumericUpDown_NumberOfDraws.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            NumericUpDown_NumberOfDraws.Name = "NumericUpDown_NumberOfDraws";
            NumericUpDown_NumberOfDraws.Size = new Size(78, 23);
            NumericUpDown_NumberOfDraws.TabIndex = 5;
            NumericUpDown_NumberOfDraws.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // MaskedTextBox_TicketCost
            // 
            MaskedTextBox_TicketCost.Culture = new System.Globalization.CultureInfo("en-US");
            MaskedTextBox_TicketCost.Location = new Point(683, 190);
            MaskedTextBox_TicketCost.Mask = "0.0";
            MaskedTextBox_TicketCost.Name = "MaskedTextBox_TicketCost";
            MaskedTextBox_TicketCost.Size = new Size(28, 23);
            MaskedTextBox_TicketCost.TabIndex = 6;
            MaskedTextBox_TicketCost.Text = "40";
            MaskedTextBox_TicketCost.ValidatingType = typeof(int);
            // 
            // Label_NumberOfDraws
            // 
            Label_NumberOfDraws.AutoSize = true;
            Label_NumberOfDraws.Location = new Point(573, 158);
            Label_NumberOfDraws.Name = "Label_NumberOfDraws";
            Label_NumberOfDraws.Size = new Size(102, 15);
            Label_NumberOfDraws.TabIndex = 8;
            Label_NumberOfDraws.Text = "Number of draws:";
            // 
            // Label_TicketCost
            // 
            Label_TicketCost.AutoSize = true;
            Label_TicketCost.Location = new Point(609, 193);
            Label_TicketCost.Name = "Label_TicketCost";
            Label_TicketCost.Size = new Size(66, 15);
            Label_TicketCost.TabIndex = 7;
            Label_TicketCost.Text = "Ticket cost:";
            // 
            // SimulationTable
            // 
            SimulationTable.Columns.AddRange(new ColumnHeader[] { CorrectGuesses, NumberOfCorrectGuesses, Reward, Balance });
            SimulationTable.Location = new Point(29, 264);
            SimulationTable.Name = "SimulationTable";
            SimulationTable.Size = new Size(759, 174);
            SimulationTable.TabIndex = 9;
            SimulationTable.UseCompatibleStateImageBehavior = false;
            SimulationTable.View = View.Details;
            // 
            // CorrectGuesses
            // 
            CorrectGuesses.Text = "Correct guesses";
            CorrectGuesses.Width = 100;
            // 
            // NumberOfCorrectGuesses
            // 
            NumberOfCorrectGuesses.Text = "Number of guesses";
            NumberOfCorrectGuesses.Width = 120;
            // 
            // Reward
            // 
            Reward.Text = "Reward";
            Reward.Width = 80;
            // 
            // Balance
            // 
            Balance.Text = "Balance";
            Balance.Width = 80;
            // 
            // Lottomat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SimulationTable);
            Controls.Add(Label_NumberOfDraws);
            Controls.Add(Label_TicketCost);
            Controls.Add(MaskedTextBox_TicketCost);
            Controls.Add(NumericUpDown_NumberOfDraws);
            Controls.Add(Button_DoSimulation);
            Controls.Add(Label_CorrectNumbers);
            Controls.Add(Button_DrawNumbers);
            Controls.Add(Label_SelectedNumbers);
            Controls.Add(Label_DrawnNumbers);
            Name = "Lottomat";
            Text = "Lottomat";
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_NumberOfDraws).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_DrawnNumbers;
        private Label Label_SelectedNumbers;
        private Button Button_DrawNumbers;
        private Label Label_CorrectNumbers;
        private Button Button_DoSimulation;
        private NumericUpDown NumericUpDown_NumberOfDraws;
        private MaskedTextBox MaskedTextBox_TicketCost;
        private Label Label_NumberOfDraws;
        private Label Label_TicketCost;
        private ListView SimulationTable;
        private ColumnHeader CorrectGuesses;
        private ColumnHeader NumberOfCorrectGuesses;
        private ColumnHeader Reward;
        private ColumnHeader Balance;
    }
}
