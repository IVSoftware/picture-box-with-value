Your question is **C# can picture boxes store values?** 

The answer is _yes" _is_ possible and one way is using the `Tag` property of `PictureBox` as LarsTech mentions. But looking at your code and use case, you would probably benefit from making a custom PictureBox that can store a values like "N" or any _other_ kind of value in app-specific ways. A minimal example looks like this:

    class CustomPictureBox : PictureBox, INotifyPropertyChanged
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

At this point you could meaningfully assign `pb[I,j].Value="N"`.

***
**Example**

Add a 3x3 `TableLayoutPanel` to the main form and initialize it:

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
        .
        .
        .
    }

***
Set the value of the center square to "N" using `cpb.Value="N"`.

    private void onClickButtonSetValue(object? sender, EventArgs e)
    {
        CustomPictureBox cpb = (CustomPictureBox) tableLayoutPanel.GetControlFromPosition(1, 1);
        cpb.Value = "N";
    }

[![set value][1]][1]
***
Set the image of the center square:

    private void onClickButtonSetImage(object? sender, EventArgs e)
    {
        var imagePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Images",
            "smiley.png");

        CustomPictureBox cpb = (CustomPictureBox)tableLayoutPanel.GetControlFromPosition(1, 1);
        cpb.Image = Image.FromFile(imagePath);
    }

[![set image][2]][2]
***
Click on the center square.

    private void onAnyClickShip(object? sender, EventArgs e)
    {
        if(sender is CustomPictureBox cpb)
        {
            MessageBox.Show($"Current cell value is {cpb.Value}");
        }
    }
[![click smiley][3]][3]

But click on any other cell:

[![click other][4]][4]


  [1]: https://i.stack.imgur.com/Nc7vv.png
  [2]: https://i.stack.imgur.com/t4qGI.png
  [3]: https://i.stack.imgur.com/L7vov.png
  [4]: https://i.stack.imgur.com/sF6zF.png