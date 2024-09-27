namespace xiaoxiao
{
    public partial class Form1 : Form
    {
        public static bool isOpen = true;
        KeyboardHook k_hook;

        public Form1()
        {
            InitializeComponent();
            k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += K_hook_KeyDownEvent;
            k_hook.Start();

        }

        private void K_hook_KeyDownEvent(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2)
            {

                //SendMsg sendMsg = new SendMsg();
                //sendMsg.SendText("@小小 修炼");
                if (e.KeyCode == Keys.F1)
                {
                    TimerCallback callback = new TimerCallback(Send);
                    System.Threading.Timer timer = new System.Threading.Timer(callback, null, 0, 65000);
                }
                if (e.KeyCode == Keys.F2)
                {
                    Application.Exit();
                }

            }

        }
        private static void Send(object state)
        {
            SendKeys.SendWait("@");
            SendKeys.SendWait("小小");
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(200);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(200);
            SendKeys.SendWait("{ENTER}");
        }

        private void transparentRect1_Load(object sender, EventArgs e)
        {

        }

        private void transTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void transTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void transTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}