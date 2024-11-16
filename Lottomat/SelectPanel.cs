namespace Lottomat
{
    public partial class SelectPanel : FlowLayoutPanel
    {
        public readonly byte fieldNumber = 49;
        public readonly byte maximumSelection = 6;
        public List<byte> SelectedNumbers
        {
            get => Controls.OfType<Button>().Where(button => button.FlatStyle == FlatStyle.Flat).Select(button => byte.Parse(button.Text)).ToList();
        }

        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick? Changed;

        public SelectPanel() : base()
        {
            FlowDirection = FlowDirection.LeftToRight;
            WrapContents = true;
            Reload();
        }

        public void Reload()
        {
            Controls.Clear();
            for (byte i = 0; i < fieldNumber; i++)
            {
                Button button = new()
                {
                    Text = (i + 1).ToString(),
                    Width = 30,
                };
                button.Click += SetButton;
                Controls.Add(button);
            }
        }

        private void SetButton(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.FlatStyle == FlatStyle.Standard && SelectedNumbers.Count < maximumSelection) button.FlatStyle = FlatStyle.Flat;
                else button.FlatStyle = FlatStyle.Standard;
                Changed?.Invoke(sender, e);
            }
        }
    }
}