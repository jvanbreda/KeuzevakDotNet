using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using WineCooler.Properties;

namespace WineCooler {
    public partial class Form1 : Form {
        private Winecooler wineCooler;
        private System.Timers.Timer refreshTimer;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            wineCooler = new Winecooler(7.2, 10.0);
            default_temp.Text = wineCooler.defaultTemp.ToString();
            current_temp.Text = wineCooler.currentTemp.ToString();
            Object image = Resources.ResourceManager.GetObject("wijnkoeler-dicht");
            wineCoolerImage.Image = (Image)image;

            InitTimer();
        }

        private void InitTimer() {
            refreshTimer = new System.Timers.Timer();
            refreshTimer.Elapsed += new ElapsedEventHandler(OnTimePassedRefresh);
            refreshTimer.Interval = 1000;

            refreshTimer.Enabled = true;
        }

        private void OnTimePassedRefresh(object sender, ElapsedEventArgs e) {
            this.SetText(wineCooler.currentTemp.ToString());
        }

        private void changeDefaultTemp(object sender, EventArgs e) {
            wineCooler.defaultTemp = Convert.ToDouble(textbox_new_default_temp.Text);
            default_temp.Text = wineCooler.defaultTemp.ToString();
        }

        private void openDoor(object sender, EventArgs e) {
            wineCooler.doorOpen = true;
            wineCooler.WarmUp();
            Object image = Resources.ResourceManager.GetObject("wijnkoeler-open");
            wineCoolerImage.Image = (Image)image;
        }

        private void closeDoor(object sender, EventArgs e) {
            wineCooler.doorOpen = false;
            wineCooler.Cool();
            Object image = Resources.ResourceManager.GetObject("wijnkoeler-dicht");
            wineCoolerImage.Image = (Image)image;
        }

        private void SetText(string text) {
            if (current_temp.InvokeRequired) {
                try {
                    SetTextCallback s = new SetTextCallback(SetText);
                    Invoke(s, text);
                } catch (Exception e) {
                    e.ToString();
                }
            }
            else {
                current_temp.Text = text;
            }
        }
    }
}
