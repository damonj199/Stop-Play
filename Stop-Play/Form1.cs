namespace Stop_Play
{
    public partial class Form1 : Form
    {
        private Thread incrementThread; // Поток для инкремента
        private int number = 0; // Число для инкрементации
        private bool isRunning = false; // Флаг для проверки работы потока
        private ManualResetEvent pauseEvent = new ManualResetEvent(true); // Событие для паузы и возобновления

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (incrementThread == null || !incrementThread.IsAlive)
            {
                isRunning = true;
                incrementThread = new Thread(IncrementNumber);
                incrementThread.IsBackground = true;
                incrementThread.Start();
            }
            pauseEvent.Set();
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            if (pauseEvent.WaitOne(0))
            {
                pauseEvent.Reset();
            }
            else
            {
                pauseEvent.Set();
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            isRunning = false;
            pauseEvent.Set();
            if (incrementThread != null && incrementThread.IsAlive)
            {
                incrementThread.Join();
            }
        }

        private void IncrementNumber()
        {
            while (isRunning)
            {
                pauseEvent.WaitOne();

                number++;
                if (number % 10 == 0)
                {
                    Invoke(new Action(() =>
                    {
                        lblNumber.Text = number.ToString();
                    }));
                }

                Thread.Sleep(200);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            pauseEvent.Set();
            if (incrementThread != null && incrementThread.IsAlive)
            {
                incrementThread.Join();
            }
        }
    }
}
