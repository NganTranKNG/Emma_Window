using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft.Document;
using SautinSoft.Document.Drawing;
//using Newtonsoft.Json;

namespace HotKeys
{
    
    public partial class Form1 : Form
    {
        /// <summary>
        ///  command list
        /// </summary>
        private const int WM_APPCOMMAND = 0x319;

        private const int APPCOMMAND_R_MENU = 0xF000;
        private const int APPCOMMAND_BROWSER_BACK = 0x10000;
        private const int APPCOMMAND_BROWSER_FORWARD = 0x20000;
        private const int APPCOMMAND_BROWSER_REFRESH = 0x30000;
        private const int APPCOMMAND_BROWSER_STOP = 0x40000;
        private const int APPCOMMAND_BROWSER_SEARCH = 0x50000;
        private const int APPCOMMAND_BROWSER_FAVORITE = 0x60000;
        private const int APPCOMMAND_BROWSER_HOME = 0x70000;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_MEDIA_NEXT = 0xB0000;
        private const int APPCOMMAND_MEDIA_PREVIOUS = 0xC0000;
        private const int APPCOMMAND_MEDIA_STOP = 0xD0000;
        private const int APPCOMMAND_MEDIA_PAUSE = 0xE0000;

        /// <summary>
        ///  config
        /// </summary>
        private const string configFileName = "hotKey.cfg";



        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private class KeyModifier
        {
            public static int None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8;
        }

        public Form1()
        {
            InitializeComponent();
            /// load config
            readConfig();
            registHotKey();
        }

        /**
         * run in application
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.L))
            {
                //MessageBox.Show("What the Ctrl+F?");
                
                Keys key = (Keys)(((int)msg.LParam >> 16) & 0xFFFF);
                int modifier = ((int)msg.LParam & 0xFFFF);
                int id = msg.WParam.ToInt32();
                lblNote.Text = "=>" + key.GetHashCode() + " - " + modifier.GetHashCode() + " = " + id;
                if(id > 0) {
                    keyData = Keys.A;
                    //SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                    //return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /**
         * listener key down
         */
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                int modifier = ((int)m.LParam & 0xFFFF);
                int id = m.WParam.ToInt32();

                lblNote.Text = "=>" + key.GetHashCode() + " - " + modifier.GetHashCode() + " = " + id;

                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)id);
               /* switch (id)
                {
                    case 0:
                        SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                        return;
                    case 1:
                        SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
                        return;
                    case 2:
                        SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
                        return;
                }*/

                //MessageBox.Show("Hotkey hasNot been pressed!");
                // do something
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void edtInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
        }


        /// <summary>
        /// hotkey
        /// </summary>
        
        private void registHotKey()
        {
            // The id of the hotkey. 0 / 1

            /*APPCOMMAND_VOLUME_MUTE = 0x80000; 173
            APPCOMMAND_VOLUME_DOWN = 0x90000;
            APPCOMMAND_VOLUME_UP = 0xA0000;
            APPCOMMAND_MEDIA_NEXT = 0xB0000;
            APPCOMMAND_MEDIA_PREVIOUS = 0xC0000;
            APPCOMMAND_MEDIA_STOP = 0xD0000;
            APPCOMMAND_MEDIA_PAUSE = 0xF0000;*/

            // work
            registHotKey(APPCOMMAND_VOLUME_MUTE, KeyModifier.Control, Keys.Multiply.GetHashCode());
            registHotKey(APPCOMMAND_VOLUME_UP, KeyModifier.Control, Keys.Add.GetHashCode());
            registHotKey(APPCOMMAND_VOLUME_DOWN, KeyModifier.Control, Keys.Subtract.GetHashCode());
            registHotKey(APPCOMMAND_MEDIA_NEXT, KeyModifier.Control, Keys.NumPad6.GetHashCode());
            registHotKey(APPCOMMAND_MEDIA_PREVIOUS, KeyModifier.Control, Keys.NumPad4.GetHashCode());
            registHotKey(APPCOMMAND_MEDIA_STOP, KeyModifier.Control, Keys.NumPad8.GetHashCode());
            registHotKey(APPCOMMAND_MEDIA_PAUSE, KeyModifier.Control, Keys.NumPad5.GetHashCode());

            /// not work
            registHotKey(APPCOMMAND_BROWSER_HOME, KeyModifier.Control, Keys.NumPad2.GetHashCode());
            registHotKey(APPCOMMAND_BROWSER_BACK, KeyModifier.Control, Keys.NumPad1.GetHashCode());
            registHotKey(APPCOMMAND_BROWSER_FORWARD, KeyModifier.Control, Keys.NumPad3.GetHashCode());
        }

        private void registHotKey(int id, int modifier, int hashCode)
        {
            RegisterHotKey(this.Handle, id, modifier, hashCode);
        }

        /// <summary>
        /// area config file
        /// </summary>

        private void saveConfig()
        {
            using (var stream = File.Open(configFileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write(convertDataToJson());
                }
            }
        }

        private void readConfig()
        {
            if (File.Exists(configFileName))
            {
                using (var stream = File.Open(configFileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        convertJsonToData(reader.ReadString());
                    }
                }
            }
        }

        private void convertJsonToData(string data)
        {

            int muteHash = Keys.VolumeMute.GetHashCode();// = 173, 0x80000; 
            int volDownHash = Keys.VolumeDown.GetHashCode();// = 174, 0x90000;
            int volUpHash = Keys.VolumeUp.GetHashCode();// = 175, 0xA0000;
            int trackNextHash = Keys.MediaNextTrack.GetHashCode();// = 176, 0xB0000;
            int trackPreviousHash = Keys.MediaPreviousTrack.GetHashCode();// = 177, 0xC0000;
            int stopHash= Keys.MediaStop.GetHashCode();// = 178, 0xD0000;
            int pauseHash = Keys.MediaPlayPause.GetHashCode();// = 179, 0xE0000;

            lblNote.Text = data
                + "\n"
                + APPCOMMAND_VOLUME_MUTE + " / " + APPCOMMAND_VOLUME_UP + " / " + APPCOMMAND_VOLUME_DOWN
                + " \n "
                + (muteHash & 0xFFFF) + " / " + convertIntToHex(volUpHash) + " / " + (volDownHash).ToString("X4");
            
        }

        private string convertDataToJson()
        {
            return "";
        }
        
        private int convertIntToHex(int intValue)
        {
            // Convert integer 182 as a hex in a string variable
            string hexValue = intValue.ToString("X");
            // Convert the hex string back to the number
            int intAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            return intAgain;
        }

        private void removeAttribute_title()
        {
            string[] filePaths = Directory.GetFiles("C:\\Users\\tranvanngan\\Downloads\\Video", "*.*",SearchOption.AllDirectories).ToList();
            foreach (string filePath in filePaths)
            {
                 if (File.Exists(filePath))
                {
                    var fileInfo = new FileInfo(filePath);
                    FileAttributes attributes = fileInfo.Attributes;
                    FileStream fs = File.Create(filePath);
                }
            }

        }
    }
}
