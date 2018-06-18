using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
 

namespace ismPrint3
{
    public partial class Form1 : Form
    {  
        public string iniFilePath = "";
        public string printDocumentFileName = "";
        public int printerIndex = 0;
        public string printFileLocation = "";
        public Printer aktifPrinter = new Printer();

        public Form1()
        {
             
  //test
            InitializeComponent();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //if (!IsBrowserEmulationSet())
                //{ 
                GetBrowserEmulationVersion();
                    SetBrowserEmulationVersion();
                //}
                  
            //-------------------------------------------------------------------------------------------
                iniFilePath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\print3Ayarlar.ini";
            IniFile ini = new IniFile(iniFilePath);


            string PrintFileLocation = ini.ReadValue("Ayarlar", "PrintFileLocation");


            if (PrintFileLocation != null)
                    printFileLocation = PrintFileLocation.Trim();

            //-------------------------------------------------------------------------------------------

           
            //this.Text = iniFilePath;
            this.Visible = false;
            String[] args =  System.Environment.GetCommandLineArgs();

            if (args != null)
            {
                if (args.Length > 0)
                {

                    string cmd = "";
                    foreach (string s in args)
                    {
                        cmd += " " + s;

                    }
                    string[] cmdParam = cmd.Split('#');
                    int i = 0;
                    foreach (string s in cmdParam)
                    {

                        switch (i)
                        {
                            case 1: printDocumentFileName = s.Trim(); break;
                            case 2: printerIndex =Convert.ToInt32( s.Trim()); break;
                            default:
                                break;
                        };
                        cmd += " " + s;

                        i++;
                    }
            
                    setAktifPrinterByIndex(printerIndex);

                    timer1.Interval = aktifPrinter.interval;


                    lblAktifYazici.Text = aktifPrinter.name;

                    if (printDocumentFileName != null)
                    {
                        if (printDocumentFileName != string.Empty)
                        {
                            WebBrowser wb = new WebBrowser();
                            wb.DocumentCompleted += wb_DocumentCompleted;
                            printDocumentFileName = printFileLocation + printDocumentFileName;
                            txtPrintingFullFileName.Text = printDocumentFileName;
                            wb.Navigate(printDocumentFileName);

                        }

                    }



                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        [DllImport("Winspool.drv")]
        private static extern bool SetDefaultPrinter(string printerName);
        bool isDocumentSendToPrinter = false;

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            
            if (aktifPrinter.name != string.Empty)
                SetDefaultPrinter(aktifPrinter.name.Trim());


            // Print the document now that it is fully loaded.
            if (isDocumentSendToPrinter)
                return;
            int i = 0;
            while (i < aktifPrinter.printCount)
            {

                ((WebBrowser)sender).Print();
                i++;
                isDocumentSendToPrinter = true;
            }
            // Dispose the WebBrowser now that the task is complete. 
            ((WebBrowser)sender).Dispose();
             

            timer1.Enabled = true;
        }

        int initInterval = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if(initInterval >= 1)
            {
                timer1.Stop();
                Application.Exit();
            }
            initInterval++;

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyarlar f = new frmAyarlar();
            f.ShowDialog();
        }

        private void setAktifPrinterByIndex(int index)
        {
            IniFile ini = new IniFile(iniFilePath);

            try
            {
                int px = -1;
                string printername = "";
                string[] dvs = ini.ReadSection("Printers");
                foreach (string dv in dvs)
                {

                    if (dv == null)
                        continue;

                    string[] keys = dv.Split('=');
                    if (keys == null)
                        continue;
                    if (keys.ToString() == string.Empty)
                        continue;

                    string key = keys[0];
                    px++;
                    if (px == index)
                    {
                        printername = key;
                        aktifPrinter.name = printername;

                        string interval = ini.ReadValue(printername, "ShutdownInterval");

                        if (interval != null)
                            if (interval != string.Empty)
                                aktifPrinter.interval = Convert.ToInt32(interval);
                        string printCount = ini.ReadValue(printername, "PrintCount");

                        if (printCount != null)
                            if (printCount != string.Empty)
                                aktifPrinter.printCount = Convert.ToInt32(printCount);




                        string printNameIE = printername + "IE";



                        string margin_bottom = ini.ReadValue(printNameIE, "margin_bottom");
                        string margin_left = ini.ReadValue(printNameIE, "margin_left");
                        string margin_right = ini.ReadValue(printNameIE, "margin_right");
                        string margin_top = ini.ReadValue(printNameIE, "margin_top");




                        string keyName = @"Software\Microsoft\Internet Explorer\PageSetup";
                        using (RegistryKey ekey = Registry.CurrentUser.OpenSubKey(keyName, true))
                        {
                            if (ekey != null)
                            {




                                ekey.SetValue("margin_bottom", margin_bottom);
                                ekey.SetValue("margin_left", margin_left);
                                ekey.SetValue("margin_right", margin_right);
                                ekey.SetValue("margin_top", margin_top);

 

                                 
 
                            }
                        }








                    }
 

                }
                
            }
            catch 
            {

                
            }
        }



        #region internetExlorer10 11 register
        private const string InternetExplorerRootKey = @"Software\Microsoft\Internet Explorer";
        public static int GetInternetExplorerMajorVersion()
        {
            int result;

            result = 0;

            try
            {
                RegistryKey key;

                key = Registry.LocalMachine.OpenSubKey(InternetExplorerRootKey);

                if (key != null)
                {
                    object value;

                    value = key.GetValue("svcVersion", null) ?? key.GetValue("Version", null);

                    if (value != null)
                    {
                        string version;
                        int separator;

                        version = value.ToString();
                        separator = version.IndexOf('.');
                        if (separator != -1)
                        {
                            int.TryParse(version.Substring(0, separator), out result);
                        }
                    }
                }
            }
            catch (SecurityException)
            {
                // The user does not have the permissions required to read from the registry key.
            }
            catch (UnauthorizedAccessException)
            {
                // The user does not have the necessary registry rights.
            }

            return result;
        }
        private const string BrowserEmulationKey = InternetExplorerRootKey + @"\Main\FeatureControl\FEATURE_BROWSER_EMULATION";

        public static BrowserEmulationVersion GetBrowserEmulationVersion()
        {
            BrowserEmulationVersion result;

            result = BrowserEmulationVersion.Default;

            try
            {
                RegistryKey key;
                Registry.CurrentUser.CreateSubKey(BrowserEmulationKey);
                key = Registry.CurrentUser.OpenSubKey(BrowserEmulationKey, true);


                if (key != null)
                {
                    string programName;
                    object value;

                    programName = Path.GetFileName(Environment.GetCommandLineArgs()[0]);
                    value = key.GetValue(programName, null);

                    if (value != null)
                    {
                        result = (BrowserEmulationVersion)Convert.ToInt32(value);
                    }
                }
            }
            catch (SecurityException)
            {
                // The user does not have the permissions required to read from the registry key.
            }
            catch (UnauthorizedAccessException)
            {
                // The user does not have the necessary registry rights.
            }
            //MessageBox.Show(result.ToString());
            return result;
        }

        public static bool IsBrowserEmulationSet()
        {
            return GetBrowserEmulationVersion() != BrowserEmulationVersion.Default;
        }

        public static bool SetBrowserEmulationVersion(BrowserEmulationVersion browserEmulationVersion)
        {
            bool result;

            result = false;

            try
            {
                RegistryKey key;

                key = Registry.CurrentUser.OpenSubKey(BrowserEmulationKey, true);

                if (key != null)
                {
                    string programName;

                    programName = Path.GetFileName(Environment.GetCommandLineArgs()[0]);

                    if (browserEmulationVersion != BrowserEmulationVersion.Default)
                    {
                        // if it's a valid value, update or create the value
                        key.SetValue(programName, (int)browserEmulationVersion, RegistryValueKind.DWord);
                    }
                    else
                    {
                        // otherwise, remove the existing value
                        key.DeleteValue(programName, false);
                    }

                    result = true;
                }
            }
            catch (SecurityException)
            {
                // The user does not have the permissions required to read from the registry key.
            }
            catch (UnauthorizedAccessException)
            {
                // The user does not have the necessary registry rights.
            }

            return result;
        }

        public static bool SetBrowserEmulationVersion()
        {
            int ieVersion;
            BrowserEmulationVersion emulationCode;
            ieVersion = 11;
            ieVersion = GetInternetExplorerMajorVersion();

            if (ieVersion >= 11)
            {
                emulationCode = BrowserEmulationVersion.Version11;
            }
            else
            {
                switch (ieVersion)
                {
                    case 10:
                        emulationCode = BrowserEmulationVersion.Version10;
                        break;
                    case 9:
                        emulationCode = BrowserEmulationVersion.Version9;
                        break;
                    case 8:
                        emulationCode = BrowserEmulationVersion.Version8;
                        break;
                    default:
                        emulationCode = BrowserEmulationVersion.Version7;
                        break;
                }
            }

            return SetBrowserEmulationVersion(emulationCode);
        }

        #endregion


        public enum BrowserEmulationVersion
        {
            Default = 0,
            Version7 = 7000,
            Version8 = 8000,
            Version8Standards = 8888,
            Version9 = 9000,
            Version9Standards = 9999,
            Version10 = 10000,
            Version10Standards = 10001,
            Version11 = 11000,
            Version11Edge = 11001
        }
    }



}

