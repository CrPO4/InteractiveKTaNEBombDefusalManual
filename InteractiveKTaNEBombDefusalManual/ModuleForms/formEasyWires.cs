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
            this.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["ModuleNames"]["EasyWires"].ToString();
            LblWires3.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Description"].ToString();
            LblWires4.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Description"].ToString();
            LblWires5.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Description"].ToString();
            LblWires6.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Description"].ToString();
            LblWires3Step1.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case1"].ToString();
            LblWires3Step2.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case2"].ToString();
            LblWires3Step3.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case3"].ToString();
            LblWires3Step4.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires3"]["Case4"].ToString();
            LblWires4Step1.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case1"].ToString();
            LblWires4Step2.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case2"].ToString();
            LblWires4Step3.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case3"].ToString();
            LblWires4Step4.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case4"].ToString();
            LblWires4Step5.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires4"]["Case5"].ToString();
            LblWires5Step1.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case1"].ToString();
            LblWires5Step2.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case2"].ToString();
            LblWires5Step3.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case3"].ToString();
            LblWires5Step4.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires5"]["Case4"].ToString();
            LblWires6Step1.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case1"].ToString();
            LblWires6Step2.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case2"].ToString();
            LblWires6Step3.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case3"].ToString();
            LblWires6Step4.Text = GlobalVariables.json[GlobalVariables.activeLanguage]["EasyWires"]["Wires6"]["Case4"].ToString();

        }
    }
}
