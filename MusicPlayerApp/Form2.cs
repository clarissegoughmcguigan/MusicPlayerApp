using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Music_Player_App
{
    public partial class Info : Form
    {
        List<Control> Panel1;
        List<Control> label;
        List<Control> button;
        List<Control> Textbox;
        
        public Point mouseLocation;

        public static Info instance;
        
        public Info()
        {
            InitializeComponent();
            instance = this;
        }

        public void Initialize_Add()
        {
            Panel1 = new List<Control>();
            label = new List<Control>();
            button = new List<Control>();
            Textbox = new List<Control>();

            Panel1.Add(panel1);
            label.Add(LabelInfo);
            button.Add(ButtonClose);
            Textbox.Add(textBoxMadeBy);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes Info box
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void ApplyTheme(Color topPanel, Color textInfo, Color labelInfo, Color background, Color closeButton)
        {
            this.BackColor = background;
            MusicPlayerApp.instance.cb1.BackColor = background;
            MusicPlayerApp.instance.cb1.ForeColor = textInfo;

            foreach (Control items in Panel1)
            {
                items.BackColor = topPanel;
            }
            foreach (Control items in label)
            {
                items.BackColor = topPanel;
                items.ForeColor = labelInfo;
            }
            foreach (Control items in button)
            {
                items.BackColor = closeButton;
                items.ForeColor = textInfo;
            }
            foreach (Control items in Textbox)
            {
                items.BackColor = background;
                items.ForeColor = textInfo;
            }
        }

        Color zcolor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

        public void Info_Load(object sender, EventArgs e)
        {
            Initialize_Add();
            if (MusicPlayerApp.instance.cb1.Text == "Default") //When text from combox selected changes the windows form theme
            {
                ApplyTheme(zcolor(64, 64, 64), Color.Black, Color.White, Color.Silver, zcolor(217, 217, 217));
            }
            else if (MusicPlayerApp.instance.cb1.Text == "Pink")
            {
                ApplyTheme(zcolor(255, 0, 208), Color.Black, Color.White, zcolor(253, 129, 255), zcolor(255, 161, 238));
            }
            else if (MusicPlayerApp.instance.cb1.Text == "Light")
            {
                ApplyTheme(Color.White, Color.Black, Color.Black, Color.White, zcolor(242, 238, 238));
            }
            else if (MusicPlayerApp.instance.cb1.Text == "Dark")
            {
                ApplyTheme(Color.Black, Color.White, Color.White, Color.Black, zcolor(22, 22, 22));
            }
        }
    }
}
