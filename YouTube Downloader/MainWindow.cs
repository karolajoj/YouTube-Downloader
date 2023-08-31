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
using ComponentFactory.Krypton.Toolkit;

namespace YouTube_Downloader {
    public partial class MainWindow : KryptonForm {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e) {

        }



        // Hide original windows buttons
        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) return;
            
            base.WndProc(ref m);
        }

        // Make custom form draggable

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private void TopPanel_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
    }
}
