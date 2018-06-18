using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace ismPrint3
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        string iniFilePath = "";

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            iniFilePath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\print3Ayarlar.ini";

            try
            {

            

                IniFile ini = new IniFile(iniFilePath);
                btnLoadPrinters_Click(null, null);
                
                string PrintFileLocation = ini.ReadValue("Ayarlar", "PrintFileLocation");




                if (PrintFileLocation != null)
                        txtPrintFileLocation.Text = PrintFileLocation.Trim();
                //--------------------------------------------------------------------

                string keyName = @"Software\Microsoft\Internet Explorer\PageSetup";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (key != null)
                    {
                        string old_footer = key.GetValue("footer").ToString();
                        string old_header = key.GetValue("header").ToString();

                        string margin_bottom = key.GetValue("margin_bottom").ToString();
                        string margin_left = key.GetValue("margin_left").ToString();
                        string margin_right = key.GetValue("margin_right").ToString();
                        string margin_top = key.GetValue("margin_top").ToString();


                        txtSfAlt.Text = margin_bottom;
                        txtSfSol.Text = margin_left;
                        txtSfSag.Text = margin_right;
                        txtSfUst.Text = margin_top;


                        chkPrintHaderFooter.Checked = true;
                        if (old_footer.Trim() == string.Empty)
                            chkPrintHaderFooter.Checked = false;

                    }
                }


            }
            catch 
            {
                
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbPrinters.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen yazıcı seçimini yapınız");
                    return;
                }

                IniFile ini = new IniFile(iniFilePath);
                string PrintFileLocation = txtPrintFileLocation.Text;
                string printName = cmbPrinters.Text+"IE";

                ini.WriteValue("Ayarlar", "PrintFileLocation", PrintFileLocation);



                //--------------------------------------------------------------------

                string keyName = @"Software\Microsoft\Internet Explorer\PageSetup";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (key != null)
                    {
                        string old_footer = "&u&b&d";
                        string old_header = "&w&bPage &p of &P";



                        string margin_bottom = txtSfAlt.Text;
                        key.SetValue("margin_bottom", margin_bottom);
                        string margin_left = txtSfSol.Text;
                        key.SetValue("margin_left", margin_left);
                        string margin_right = txtSfSag.Text;
                        key.SetValue("margin_right", margin_right);
                        string margin_top = txtSfUst.Text;
                        key.SetValue("margin_top", margin_top);

                        ini.WriteValue(printName, "margin_bottom", margin_bottom);
                        ini.WriteValue(printName, "margin_left", margin_left);
                        ini.WriteValue(printName, "margin_right", margin_right);
                        ini.WriteValue(printName, "margin_top", margin_top);

                        ini.WriteValue("Ayarlar", "PrintFileLocation", PrintFileLocation);



                        if (!chkPrintHaderFooter.Checked)
                        {
                            key.SetValue("footer", "");
                            key.SetValue("header", "");
                        }
                        else
                        {

                            key.SetValue("footer", old_footer);
                            key.SetValue("header", old_header);
                        }
                    }
                }








                MessageBox.Show("Başarılı!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

 

        private void btnLoadPrinters_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(iniFilePath);
            try
            {
                cmbPrinters.Items.Clear();
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
                    //string[] dvItem = dv.Split('=');

                    //if (dvItem == null)
                    //    continue;
                    //ComboboxItem item = new ComboboxItem();
                    //item.Text = dvItem[0];
                    //item.Value = dvItem[1];
                    cmbPrinters.Items.Add(key);
 
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool yeniPrinterEkle()
        {
            IniFile ini = new IniFile(iniFilePath);

            try
            {



                btnLoadPrinters_Click(null, null);
                int j = cmbPrinters.Items.Count;
                string newPrinterName = cmbPrinters.Text.Trim();
                bool var = false;
                for (int i = 0; i < j; i++)
                {
                    string dvc = cmbPrinters.Items[i].ToString();
                    if (dvc.Trim() == newPrinterName)
                        var = true;
                }
                if (var)
                {
                    return true;
                }
                ini.WriteValue("Printers", newPrinterName,j.ToString());
                btnLoadPrinters_Click(null, null);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void btnSilPrinter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili yazıcıyı silemek istediğinizden eminmisiniz?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            IniFile ini = new IniFile(iniFilePath);
            try
            {
                //string key = cmbAllDeviceList.Text.Replace("=0", "");
                ini.DeleteKey("Printers", cmbPrinters.Text);
                cmbPrinters.Text = "";
                btnLoadPrinters_Click(null, null);
                List<string> printers = new List<string>();
                for (int i = 0; i < cmbPrinters.Items.Count; i++)
                {
                   string dvc = cmbPrinters.Items[i].ToString();
                   printers.Add(dvc);
 
                }
                int p = 0;
                foreach (string printer in printers)
                {
                    ini.WriteValue("Printers", printer, p.ToString());
                    p++;
                }
                btnLoadPrinters_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnYaziciAyarlariKaydet_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(iniFilePath);
            try
            {
                string printername = cmbPrinters.Text.Trim();
                if (printername == string.Empty)
                {
                    MessageBox.Show("Bir Yazıcı seçiniz veya bir yazıcı adı giriniz.");
                    return;
                }
                if (!yeniPrinterEkle())
                {
                    MessageBox.Show("Yazıcı kaydetme işlemi başarısız oldu!");
                    return;
                }
                

                int printCount = Convert.ToInt32(txtPrintCount.Text);
                ini.WriteValue(printername, "PrintCount", printCount.ToString());
                int interval = Convert.ToInt32(txtTimerShutdownInterval.Text);
                ini.WriteValue(printername, "ShutdownInterval", interval.ToString());

                MessageBox.Show("Başarılı!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(iniFilePath);
            
            try
            {
                string printername = cmbPrinters.Text.Trim();
                if (printername == string.Empty)
                {
                    MessageBox.Show("Bir Yazıcı seçiniz veya bir yazıcı adı giriniz.");
                    return;
                }

                string interval = ini.ReadValue(printername, "ShutdownInterval");

                if (interval != null)
                    if (interval != string.Empty)
                        txtTimerShutdownInterval.Text = Convert.ToInt32(interval).ToString();

                string printCount = ini.ReadValue(printername, "PrintCount");
                if (printCount != null)
                    if (printCount != string.Empty)
                        txtPrintCount.Text = Convert.ToInt32(printCount).ToString();


                string printNameIE = cmbPrinters.Text + "IE";

  

                string margin_bottom= ini.ReadValue(printNameIE, "margin_bottom");
                string margin_left = ini.ReadValue(printNameIE, "margin_left");
                string margin_right = ini.ReadValue(printNameIE, "margin_right");
                string margin_top = ini.ReadValue(printNameIE, "margin_top");


                txtSfAlt.Text = margin_bottom;
                txtSfSol.Text = margin_left;
                txtSfSag.Text = margin_right;
                txtSfUst.Text = margin_top ;




            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        //-------------------------------------------------------------------------------------------------------

    }
}
