using System;
using System.Timers;

namespace WineCooler {
    public delegate void SetTextCallback(string text);

    class Winecooler {
        public double defaultTemp;
        public double currentTemp;

        public bool doorOpen;

        private System.Timers.Timer coolTimer;
        private System.Timers.Timer warmUpTimer;

        public Winecooler(double defaultTemp, double currentTemp) {
            this.defaultTemp = defaultTemp;
            this.currentTemp = currentTemp;

            this.doorOpen = false;

            InitTimers();

            Cool();
        }

        private void InitTimers() {
            coolTimer = new System.Timers.Timer();
            warmUpTimer = new System.Timers.Timer();

            coolTimer.Elapsed += new ElapsedEventHandler(OnTimePassedCool);
            coolTimer.Interval = 1000;  //150000

            warmUpTimer.Elapsed += new ElapsedEventHandler(OnTimePassedWarmUp);
            warmUpTimer.Interval = 1000; //60000
        }

        public void Cool() {
            warmUpTimer.Enabled = false;
            coolTimer.Enabled = true;
        }

        public void WarmUp() {
            coolTimer.Enabled = false;
            warmUpTimer.Enabled = true;
        }

        private void OnTimePassedCool(object sender, ElapsedEventArgs e) {
            if (currentTemp >= defaultTemp) {
                currentTemp -= 0.2;
            }
            else {
                WarmUp();
            }
        }

        private void OnTimePassedWarmUp(object sender, ElapsedEventArgs e) {
            if (doorOpen) {
                currentTemp += 0.9;
            }
            else if (defaultTemp >= currentTemp) {
                currentTemp += 0.5;
            }
            else {
                Cool();
            }
        }
    }
}
