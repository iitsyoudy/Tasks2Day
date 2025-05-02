using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks2Day
{
    public partial class Form1 : Form
    {
       private Label task1Label;
        private Label motLabel;
        private Label task5Label;
        private Label task3Label;
        private Label task4Label;
        private TextBox task1Text;
        private Button task1Button;
        private Label task2Label;
        private TextBox task2Text;
        private TextBox task3Text;
        private TextBox task4Text;
        private TextBox task5Text;
        private Button task2Button;
        private Button task3Button;
        private Button task4Button;
        private Button task5Button;
        private PictureBox pictureBox;
        private PictureBox pictureBox1;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.LightPink;
            this.Icon = new Icon(Path.Combine(Application.StartupPath, "Office_-62_icon-icons.com_73994.ico"));
            this.Text = "Tasks2Day";
            motLabel=new Label();
            motLabel.Location = new System.Drawing.Point(10, 700);
            motLabel.Size = new Size(1000, 1000);
            motLabel.Font = new Font("Arial", 21, FontStyle.Bold);
            motLabel.Text = "It is not the movement of the clock that produces the newness of life,it is the movement in your mind .";
            Controls.Add(motLabel);
            pictureBox = new PictureBox();
            string imagePath = Path.Combine(Application.StartupPath, "done (1).png");
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new System.Drawing.Point(10, 410);
            pictureBox.Size = new System.Drawing.Size(150, 150);
            pictureBox.BackColor = Color.LightPink;
            Controls.Add(pictureBox);
            pictureBox1 = new PictureBox();
            string imagePath1 = Path.Combine(Application.StartupPath, "planner.png");
            pictureBox1.Image = Image.FromFile(imagePath1);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Location = new System.Drawing.Point(1350, 690);
            pictureBox1.Size = new System.Drawing.Size(150, 150);
            pictureBox1.BackColor = Color.LightPink;
            Controls.Add(pictureBox1);
            task1Label = new Label();
            task1Label.Text = "Task 1";
            task1Label.Location = new System.Drawing.Point(10, 5);
            task1Label.Font = new System.Drawing.Font(task1Label.Font, System.Drawing.FontStyle.Bold);
            task1Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Controls.Add(task1Label);
            task1Text=new TextBox();
            task1Text.Location = new System.Drawing.Point(10, 30);
            task1Text.BackColor = Color.LightYellow;
            task1Text.Size = new Size(1000, 200);
            task1Text.Font = new Font("Arial", 12, FontStyle.Italic);
            task1Text.BorderStyle = BorderStyle.None;
            task1Text.WordWrap = false;
            task1Text.ScrollBars = ScrollBars.None;
            task1Text.KeyPress += TextBox_KeyPress;
            Controls.Add(task1Text);
            task1Button=new Button();
            task1Button.Size = new Size(40, 40);
            task1Button.Location = new System.Drawing.Point(1100, 20);
            task1Button.BackColor = Color.LightYellow;
            task1Button.Click += IconButton_Click;
            Controls.Add(task1Button);
            task2Label = new Label();
            task2Label.Text = "Task 2";
            task2Label.Location = new System.Drawing.Point(10, 85);
            task2Label.Font = new System.Drawing.Font(task2Label.Font, System.Drawing.FontStyle.Bold);
            task2Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Controls.Add(task2Label);
            task2Text = new TextBox();
            task2Text.Location = new System.Drawing.Point(10, 110);
            task2Text.BackColor = Color.LightYellow;
            task2Text.Size = new Size(1000, 200);
            task2Text.Font = new Font("Arial", 12, FontStyle.Italic);
            task2Text.BorderStyle = BorderStyle.None;
            task2Text.WordWrap = false;
            task2Text.ScrollBars = ScrollBars.None;
            task2Text.KeyPress += TextBox_KeyPress;
            Controls.Add(task2Text);
            task2Button = new Button();
            task2Button.Size = new Size(40, 40);
            task2Button.Location = new System.Drawing.Point(1100, 100);
            task2Button.BackColor = Color.LightYellow;
            task2Button.Click += IconButton_Click;
            Controls.Add(task2Button);
            task3Label = new Label();
            task3Label.Text = "Task 3";
            task3Label.Location = new System.Drawing.Point(10, 165);
            task3Label.Font = new System.Drawing.Font(task3Label.Font, System.Drawing.FontStyle.Bold);
            task3Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Controls.Add(task3Label);
            task3Text = new TextBox();
            task3Text.Location = new System.Drawing.Point(10, 190);
            task3Text.BackColor = Color.LightYellow;
            task3Text.Size = new Size(1000, 200);
            task3Text.Font = new Font("Arial", 12, FontStyle.Italic);
            task3Text.BorderStyle = BorderStyle.None;
            task3Text.WordWrap = false;
            task3Text.ScrollBars = ScrollBars.None;
            task3Text.KeyPress += TextBox_KeyPress;
            Controls.Add(task3Text);
            task3Button = new Button();
            task3Button.Size = new Size(40, 40);
            task3Button.Location = new System.Drawing.Point(1100, 180);
            task3Button.BackColor = Color.LightYellow;
            task3Button.Click += IconButton_Click;
            Controls.Add(task3Button);
            task4Label = new Label();
            task4Label.Text = "Task 4";
            task4Label.Location = new System.Drawing.Point(10, 245);
            task4Label.Font = new System.Drawing.Font(task4Label.Font, System.Drawing.FontStyle.Bold);
            task4Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Controls.Add(task4Label);
            task4Text = new TextBox();
            task4Text.Location = new System.Drawing.Point(10, 270);
            task4Text.BackColor = Color.LightYellow;
            task4Text.Size = new Size(1000, 200);
            task4Text.Font = new Font("Arial", 12, FontStyle.Italic);
            task4Text.BorderStyle = BorderStyle.None;
            task4Text.WordWrap = false;
            task4Text.ScrollBars = ScrollBars.None;
            task4Text.KeyPress += TextBox_KeyPress;
            Controls.Add(task4Text);
            task4Button = new Button();
            task4Button.Size = new Size(40, 40);
            task4Button.Location = new System.Drawing.Point(1100, 260);
            task4Button.BackColor = Color.LightYellow;
            task4Button.Click += IconButton_Click;
            Controls.Add(task4Button);
            task5Label = new Label();
            task5Label.Text = "Task 5";
            task5Label.Location = new System.Drawing.Point(10, 325);
            task5Label.Font = new System.Drawing.Font(task5Label.Font, System.Drawing.FontStyle.Bold);
            task5Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Controls.Add(task5Label);
            task5Text = new TextBox();
            task5Text.Location = new System.Drawing.Point(10, 350);
            task5Text.BackColor = Color.LightYellow;
            task5Text.Size = new Size(1000, 200);
            task5Text.Font = new Font("Arial", 12, FontStyle.Italic);
            task5Text.BorderStyle = BorderStyle.None;
            task5Text.WordWrap = false;
            task5Text.ScrollBars = ScrollBars.None;
            task5Text.KeyPress += TextBox_KeyPress;
            Controls.Add(task5Text);
            task5Button = new Button();
            task5Button.Size = new Size(40, 40);
            task5Button.Location = new System.Drawing.Point(1100, 340);
            task5Button.BackColor = Color.LightYellow;
            task5Button.Click += IconButton_Click;
            Controls.Add(task5Button);
            LoadData();
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered character is a letter
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Space)
            {
                // Suppress the non-letter character
                e.Handled = true;
                MessageBox.Show("Please enter letters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TextBox textBox = (TextBox)sender;
            int characterLimit = 100; // Adjust the limit as needed

            if (textBox.Text.Length >= characterLimit && e.KeyChar != (char)Keys.Back)
            {
                // Suppress the key press if the limit is reached (allowing Backspace)
                e.Handled = true;
                MessageBox.Show($"Character limit of {characterLimit} reached.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SaveData();
        }
        private void IconButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                if (clickedButton.Image != null)
                {
                    clickedButton.Image = null;
                }
                else
                {
                    
                    string iconPath = Path.Combine(Application.StartupPath, "checklist_icon_259211 (1).png");
                    Image iconImage = Image.FromFile(iconPath);
                    clickedButton.Image = iconImage;

                }
            }
            SaveData();
        }
        private void SaveData()
        {
            
            SaveTextBoxData(task1Text, "task1.txt", task1Button.Image != null);
            SaveTextBoxData(task2Text, "task2.txt", task2Button.Image != null);
            SaveTextBoxData(task3Text, "task3.txt", task3Button.Image != null);
            SaveTextBoxData(task4Text, "task4.txt", task4Button.Image != null);
            SaveTextBoxData(task5Text, "task5.txt", task5Button.Image != null);
        }

        private void SaveTextBoxData(TextBox textBox, string fileName, bool buttonState)
        {
            
            File.WriteAllText(fileName, $"{textBox.Text}{Environment.NewLine}ButtonState:{buttonState}");
        }

        private void LoadTextBoxData(TextBox textBox, Button button, string fileName)
        {
            // Load data from a file to a textbox and set the button state
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length > 0)
                {
                    textBox.Text = lines[0];
                }

                if (lines.Length > 1 && lines[1].StartsWith("ButtonState:"))
                {
                    bool buttonState = bool.Parse(lines[1].Substring("ButtonState:".Length));
                    button.Image = buttonState ? new Bitmap(Path.Combine(Application.StartupPath, "checklist_icon_259211 (1).png")) : null;
                }
            }
        }

        private void LoadData()
        {
           
            LoadTextBoxData(task1Text, task1Button, "task1.txt");
            LoadTextBoxData(task2Text, task2Button, "task2.txt");
            LoadTextBoxData(task3Text, task3Button, "task3.txt");
            LoadTextBoxData(task4Text, task4Button, "task4.txt");
            LoadTextBoxData(task5Text, task5Button, "task5.txt");
        }
    }
}
