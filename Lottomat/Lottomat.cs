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

        private void Clicked(object sender, EventArgs e) => SelectedNumbers.Text = $"Selected numbers: {ListToString(selectPanel.SelectedNumbers)}";

        private void Draw(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                byte[] numbers = Array.ConvertAll(Enumerable.Range(1, selectPanel.fieldNumber - 1).ToArray(), number => (byte)number);
                RandomNumberGenerator.Shuffle<byte>(numbers);

                List<byte> drawn = numbers.Take(selectPanel.maximumSelection).ToList();
                DrawnNumbers.Text = $"Drawn numbers: {ListToString(drawn)}";

                byte correct = (byte)selectPanel.SelectedNumbers.Intersect(drawn).Count();
                CorrectNumbers.Text = $"Correct numbers: {correct}";
            }
        }

        private void Simulation(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                ushort initialCash = 4000;
                Dictionary<byte, int> rewards = new() { { 3, 10 }, { 4, 100 }, { 5, 3500 }, { 6, 1000000 } };
                int cash = initialCash;
                for (ushort i = 0; i < 1000; i++)
                {
                    Draw(DrawNumbers, EventArgs.Empty);
                    byte correct = CorrectNumbers.Text.Split(": ")[1].Select(c => byte.Parse(c.ToString())).First();
                    int reward = rewards.GetValueOrDefault(correct, 0);
                    cash += -4 + reward;
                }
                Balance.Text = $"Balance: {cash - initialCash} PLN";
            }
        }
    }
}