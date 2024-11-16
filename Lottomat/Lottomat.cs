using System.Security.Cryptography;

namespace Lottomat
{
    public partial class Lottomat : Form
    {
        private readonly SelectPanel selectPanel = new()
        {
            Left = 0,
            Top = 0,
            Dock = DockStyle.Left & DockStyle.Top & DockStyle.Right,
        };

        public Lottomat()
        {
            InitializeComponent();
            selectPanel.Width = Width;
            selectPanel.Changed += Clicked;
            Controls.Add(selectPanel);
        }

        private static string ListToString(List<byte> list) => string.Join(", ", list);

        private void Clicked(object sender, EventArgs e) => Label_SelectedNumbers.Text = $"Selected numbers: {ListToString(selectPanel.SelectedNumbers)}";

        private void Draw(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                byte[] numbers = Array.ConvertAll(Enumerable.Range(1, selectPanel.fieldNumber - 1).ToArray(), number => (byte)number);
                RandomNumberGenerator.Shuffle<byte>(numbers);

                List<byte> drawn = numbers.Take(selectPanel.maximumSelection).ToList();
                Label_DrawnNumbers.Text = $"Drawn numbers: {ListToString(drawn)}";

                byte correct = (byte)selectPanel.SelectedNumbers.Intersect(drawn).Count();
                Label_CorrectNumbers.Text = $"Correct numbers: {correct}";
            }
        }

        private void Simulation(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                SimulationTable.Items.Clear();
                float cost = float.Parse(MaskedTextBox_TicketCost.Text);
                List<uint> rewards = [0, 0, 0, 10, 100, 3500, 1000000];
                byte maximumSelection = selectPanel.maximumSelection;

                Dictionary<byte, ushort> numberOfGuesses = Enumerable.Range(0, maximumSelection + 1).ToDictionary(i => (byte)i, i => (ushort)0);

                for (ushort i = 0; i < NumericUpDown_NumberOfDraws.Value; i++)
                {
                    Draw(Button_DrawNumbers, EventArgs.Empty);
                    byte correct = Label_CorrectNumbers.Text.Split(": ")[1].Select(c => byte.Parse(c.ToString())).First();
                    numberOfGuesses[correct] += 1;
                }

                for (byte i = 0; i < selectPanel.maximumSelection + 1; i++)
                {
                    ListViewItem correctGuess = SimulationTable.Items.Add(i.ToString());
                    correctGuess.SubItems.Add(numberOfGuesses[i].ToString());
                    correctGuess.SubItems.Add(rewards[i].ToString());
                    float balance = float.Round(numberOfGuesses[i] * (rewards[i] - cost), 2);
                    correctGuess.SubItems.Add(balance.ToString());
                }
            }
        }
    }
}