using System;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace WpfApplication {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private Question[] questions;
        private int counter;
        private int correct;
        System.Timers.Timer loadTimer;

        public MainWindow() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            questions = new Question[5];
            questions[0] = new Question("1 + x = 3, solve X", 2);
            questions[1] = new Question("Square root of 169", 13);
            questions[2] = new Question("Solve (a^2 + b^2 = c+2), with A = 3 and B = 4", 5);
            questions[3] = new Question("Square root of x equals 12, solve X", 144);
            questions[4] = new Question("1 + 1", 2);

            counter = 0;
            correct = 0;

            loadTimer = new System.Timers.Timer();
            loadTimer.Interval = 250;
            loadTimer.Elapsed += LoadTimer_Elapsed;

            confirm.Click += Confirm_Click;
            ShowQuestion();
        }

        private void LoadTimer_Elapsed(object sender, ElapsedEventArgs e) {
            this.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate () {
                if (this.progessBar.Value < 100)
                    this.progessBar.Value += 10;
                else {
                    this.loadTimer.Enabled = false;
                    this.progessBar.Opacity = 0;
                    this.question.Opacity = 100;
                    this.question.FontSize = 26;
                    this.question.Content = "You scored " + correct + " out of " + questions.Length + "!";
                }
            }));
        }

        private void Confirm_Click(object sender, RoutedEventArgs e) {
            CheckAnswer();
            counter++;
            ShowQuestion();
        }

        public void ShowQuestion() {
            if (counter < questions.Length)
                question.Content = questions[counter].GetQuestion();
            else {
                ProcessResults();
            }
        }

        public void CheckAnswer() {
            int givenAnswer = System.Convert.ToInt32(answerField.Text);
            if (questions[counter].IsCorrect(givenAnswer))
                correct++;
            answerField.Text = "";
        }

        public void ProcessResults() {
            answerField.Opacity = 0;
            confirm.Opacity = 0;
            question.Opacity = 0;
            progessBar.Opacity = 100;
            loadTimer.Enabled = true;
        }
    }
}
