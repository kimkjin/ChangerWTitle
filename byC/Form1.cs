using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Windows;

namespace byC
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        public string FilePath;

        public void OpenProcess()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath = openFile.FileName;
                processText.Text = FilePath;
                processText.Enabled = true;
            }
        }
        private void StarMyCE()
        {
            StringBuilder sb = new StringBuilder();
            string nome_do_precesso = nomeFile.Text;
            string nomeStatP = "Renomeado!";

            Process p = Process.Start(FilePath);
            p.WaitForInputIdle(3000);  // Tempo estimado até a função abaixo ser executada
            SetWindowText(p.MainWindowHandle, nome_do_precesso);
            statusName.Text = nomeStatP;
            statusName.ForeColor = System.Drawing.Color.Green;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarMyCE();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenProcess();
        }
    }
}
