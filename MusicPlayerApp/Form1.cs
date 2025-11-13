using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Music_Player_App
{
    public partial class MusicPlayerApp : Form
    {
        List<Control> panel1;
        List<Control> panel2;
        List<Control> buttons;
        List<Control> listboxes;
        List<Control> label;

        public Point mouseLocation;

        public static MusicPlayerApp instance;
        public ComboBox cb1;

        public MusicPlayerApp()
        {
            InitializeComponent();
            instance = this;
            cb1 = comboBoxTheme;
        }

        public void Initialize_Add()
        {
            panel1 = new List<Control>();
            panel2 = new List<Control>();
            buttons = new List<Control>();
            listboxes = new List<Control>();
            label = new List<Control>();

            panel1.Add(TopPanel);
            panel2.Add(TaskPanel);

            buttons.Add(ButtonSelectFiles);
            buttons.Add(ButtonSelectInfo);

            listboxes.Add(listBoxSongs);

            label.Add(LabelLogo);
        }

        List<string> paths, files;
        private void LabelLogo_Click(object sender, EventArgs e)
        {
           
        }

        public void ApplyTheme(Color topPanel, Color taskPanel, Color background, Color button, Color listbox, Color combobox, Color textcolour, Color labelcolour)
        {
            this.BackColor = background;
            comboBoxTheme.BackColor = combobox;
            comboBoxTheme.ForeColor = textcolour;

            foreach (Control items in panel1)
            {
                items.BackColor = topPanel;
                items.ForeColor = textcolour;
            }
            foreach (Control items in panel2)
            {
                items.BackColor = taskPanel;
                items.ForeColor = textcolour;
            }
            foreach (Control items in buttons)
            {
                items.BackColor = button;
                items.ForeColor = textcolour;
            }
            foreach (Control items in listboxes)
            {
                items.BackColor = listbox;
                items.ForeColor = textcolour;
            }
            foreach (Control items in label)
            {
                items.ForeColor = labelcolour;
            }
        }
        

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close(); //Code closes the app
        }

        private void ButtonSelectInfo_Click(object sender, EventArgs e)
        {
          Info f2 = new Info(); //Code to open new form from Info button
          f2.ShowDialog(); //opens form2
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex == -1)
                return;
            axWindowsMediaPlayer.URL = paths[listBoxSongs.SelectedIndex]; //Code to play music
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Code to minimise form
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Maximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) //if window is normal then maximise
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Code that makes program not cover the windows taskbar
                this.WindowState = FormWindowState.Maximized;
            }
            else //if window is maximise then return to normal
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        public void MusicPlayerApp_Load(object sender, EventArgs e)
        {
            Initialize_Add();
            comboBoxTheme.SelectedIndex = 0;

        }

        public void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e) //When text from combox selected changes the windows form theme
        {
            if (comboBoxTheme.Text == "Default")
            {
                ApplyTheme(zcolor(64, 64, 64), zcolor(224, 224, 224), zcolor(192, 192, 192), zcolor(224, 224, 224), zcolor(224, 224, 224), zcolor(224, 224, 224), Color.Black, Color.White);
            }
            else if (comboBoxTheme.Text == "Pink")
            {
                ApplyTheme(zcolor(255, 0, 208), zcolor(255, 161, 238), zcolor(253, 129, 255), zcolor(255, 161, 238), zcolor(255, 161, 238), zcolor(255, 161, 238), Color.Black, Color.White);
            }
            else if (comboBoxTheme.Text == "Light")
            {
                ApplyTheme(zcolor(255, 255, 255), zcolor(242, 238, 238), zcolor(255, 255, 255), zcolor(242, 238, 238), zcolor(242, 238, 238), zcolor(255, 255, 255), Color.Black, Color.Black);
            }
            else if (comboBoxTheme.Text == "Dark")
            {
                ApplyTheme(Color.Black, zcolor(22, 22, 22), Color.Black, zcolor(22, 22, 22), zcolor(22, 22, 22), Color.Black, Color.White, Color.White);
            }
        }

        Color zcolor(int r , int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

        private void ButtonSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //code to select songs

            ofd.Filter = "Files|*.mp3; *.wav; *.mp4; *.m4a; *.wma; *.flac; *.mkv; *.webm; *.avi; *.flv; *.ogg"; //Code to only show file types which are specified

            ofd.Multiselect = true; //Code to select multiple files

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               if (files == null || paths == null)
               {
                  files = ofd.SafeFileNames.ToList(); //Save the name of the track in files array
                  paths = ofd.FileNames.ToList(); //Saves the paths of the tracks in path array
               }
               else
               {
                  files.AddRange(ofd.SafeFileNames.ToList());
                  paths.AddRange(ofd.FileNames.ToList());
               }
               listBoxSongs.Items.Clear();

               for (int i = 0; i < files.Count; i++) //Displays the music titles in listbox
               {
                  listBoxSongs.Items.Add(files[i]); //Displays songs in listbox
               }
            }
        }
    }
}
