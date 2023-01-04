using System.CodeDom;
using System.ComponentModel;

namespace picture_box_with_value
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            for (int col = 0; col < tableLayoutPanel.ColumnCount; col++)
            {
                for (int row = 0; row < tableLayoutPanel.ColumnCount; row++)
                {
                    var ship = new CustomPictureBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Anchor = (AnchorStyles)0xF,
                        Margin = new Padding(1),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                    };
                    ship.Click += onAnyClickShip;
                    tableLayoutPanel.Controls.Add(ship, col, row);
                }
            }
            // Tests
            buttonSetValue.Click += onClickButtonSetValue;
            buttonSetImage.Click += onClickButtonSetImage;
        }

        private void onClickButtonSetValue(object? sender, EventArgs e)
        {
            CustomPictureBox cpb = (CustomPictureBox) tableLayoutPanel.GetControlFromPosition(1, 1);
            cpb.Value = "N";
        }

        private void onClickButtonSetImage(object? sender, EventArgs e)
        {
            var imagePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Images",
                "smiley.png");

            CustomPictureBox cpb = (CustomPictureBox)tableLayoutPanel.GetControlFromPosition(1, 1);
            cpb.Image = Image.FromFile(imagePath);
        }

        private void onAnyClickShip(object? sender, EventArgs e)
        {
            if(sender is CustomPictureBox cpb)
            {
                MessageBox.Show($"Current cell value is {cpb.Value}");
            }
        }
    }

    class CustomPictureBox : PictureBox , INotifyPropertyChanged
    {
        object _value = "Empty";
        public object Value
        {
            get => _value;
            set
            {
                if (!Equals(_value, value))
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                    // Demo purposes only:
                    MessageBox.Show($"New value is {value}");
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}