using InteractiveKTaNEBombDefusalManual.ModuleForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace InteractiveKTaNEBombDefusalManual
{
    public partial class MainWindow : Form
    {

        static public class GlobalVariables
        {
          public static JObject json = JObject.Parse(File.ReadAllText(@"Resources/i10n.json"));
          public static string activeLanguage = GlobalVariables.json["ActiveLanguage"].ToString();
        }


        public MainWindow()
        {
            InitializeComponent();
            Loadi10n(GlobalVariables.activeLanguage);
            foreach (JProperty property in GlobalVariables.json.Properties())
            {
                if (property.Name.Length <6) {
                    var currentItem = CMenu.Items.Add(GlobalVariables.json[property.Name]["LanguageName"].ToString());
                    currentItem.Tag = property.Name;
                }
            }
        }

        private void CMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            GlobalVariables.activeLanguage = item.Tag.ToString();
            Loadi10n(GlobalVariables.activeLanguage);
        }

        private void Loadi10n(string activeLanguage)
        {
            this.Text = GlobalVariables.json[activeLanguage]["MainWindowName"].ToString();
            BtnEasyWires.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["EasyWires"].ToString();
            BtnTheButton.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["TheButton"].ToString();
            BtnKeypad.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Keypad"].ToString();
            BtnSimon.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Simon"].ToString();
            BtnWhosOnFirst.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["WhosOnFirst"].ToString();
            BtnMemory.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Memory"].ToString();
            BtnMorse.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Morse"].ToString();
            BtnComplicatedWires.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["ComplicatedWires"].ToString();
            BtnWireSequences.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["WireSequences"].ToString();
            BtnMaze.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Maze"].ToString();
            BtnPassword.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Password"].ToString();
            BtnGas.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Gas"].ToString();
            BtnCapacitor.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Capacitor"].ToString();
            BtnKnob.Text = GlobalVariables.json[activeLanguage]["ModuleNames"]["Knob"].ToString();
            BtnIndicator.Text = GlobalVariables.json[activeLanguage]["AdditionalInfo"]["Indicator"].ToString();
            BtnBattery.Text = GlobalVariables.json[activeLanguage]["AdditionalInfo"]["Battery"].ToString();
            BtnPort.Text = GlobalVariables.json[activeLanguage]["AdditionalInfo"]["Port"].ToString();
        }

        private void BtnEasyWires_Click(object sender, EventArgs e)
        {
            ModuleForms.FormEasyWires.ActiveForm.Show();
            FormEasyWires frmEasyWires = new FormEasyWires();
            frmEasyWires.Show();
            frmEasyWires.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}