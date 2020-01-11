using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static InteractiveKTaNEBombDefusalManual.MainWindow;

namespace InteractiveKTaNEBombDefusalManual.ModuleForms
{
    public partial class FormEasyWires : Form
    {
        public FormEasyWires()
        {
            InitializeComponent();
        }

        private void FormEasyWires_Load(object sender, EventArgs e)
        {
            SetLanguage();
        }

        public void SetLanguage()
        {
            RichEasyWires.Clear();
            EpigraphBox.Clear();
            this.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["ModuleNames"]["EasyWires"].ToString();
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Description"].ToString(), true, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case1"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case2"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case3"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case4"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Description"].ToString(), true, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case1"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case2"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case3"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case4"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case5"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Description"].ToString(), true, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case1"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case2"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case3"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case4"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Description"].ToString(), true, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case1"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case2"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case3"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case4"].ToString(), false, RichEasyWires);
            AddTextToTheBox(GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Epigraph"].ToString(), false, EpigraphBox);
        }

        private void FormEasyWires_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void RichEasyWires_Enter(object sender, EventArgs e)
        {
            FocusLabel.Focus();
        }

        private void RichEasyWires_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void AddTextToTheBox(string text, bool header, RichTextBox box)
        {
            if (header == true)
            {
                box.SelectionFont = new Font("Georgia", 16, FontStyle.Bold);
                box.SelectionBullet = false;
                box.SelectionIndent = 0;
                box.SelectedText = text + '\n';
            }
            else if (box == EpigraphBox)
            {
                box.SelectionFont = new Font("Georgia", 8, FontStyle.Italic);
                box.SelectedText = text;
                box.SelectionBullet = false;
                box.SelectionAlignment = HorizontalAlignment.Right;
                box.SelectionIndent = 10;
                box.SelectedText = "\n";
                box.SelectionBullet = false;
                box.SelectionIndent = 0;
            }
            else
            {
                box.SelectionFont = new Font("Georgia", 12, FontStyle.Regular);
                box.SelectedText = text;
                box.SelectionBullet = true;
                box.SelectionIndent = 10;
                box.SelectedText = "\n";
                box.SelectionBullet = false;
                box.SelectionIndent = 0;
            }
        }

        private void RichEasyWires_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            RichEasyWires.Height = e.NewRectangle.Height + 5;
            this.Size = new Size(this.Width, RichEasyWires.Height + 55);
        }
    }
}
