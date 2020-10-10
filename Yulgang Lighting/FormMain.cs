using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace Yulgang_Lighting
{
    public partial class FormMain : Form
    {
        private const string LightingPath = "datas\\EFFECT\\AMD";
        private const string LightingRed = "AuraRedMH8th.amd";
        private const string LightingRedFire = "139_1_anhong.DXT";
        private const string LightingRedThunderbolt = "shandinaA_003.DXT";
        private const string LightingBlue = "AuraBlueMH8th.amd";
        private const string LightingBlueFire = "139_1B.dxt";
        private const string LightingBlueThunderbolt = "shandinaA_002.dxt";
        private string _yulgangPath = "";
        private string _yulgangEffectPath = "";
        private List<Lighting> _lightings;
        private FolderBrowserDialog _folderDlg;
        private IniData _settingData;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Warning
            FormWarning formWarning = new FormWarning();
            formWarning.ShowDialog();

            //Set title
            this.Text = "Yulgang Lighting " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //List Lighting
            _lightings = new List<Lighting>();

            //Read profile.ini
            var parser = new FileIniDataParser();
            _settingData = parser.ReadFile(AppDomain.CurrentDomain.BaseDirectory + @"/profile.ini");
            KeyDataCollection dataLighting = _settingData["lighting"];

            //Add none lighting
            _lightings.Add(new Lighting() { Name = dataLighting["lighting_none_name"], Path = dataLighting["lighting_none_path"] });

            //Loop set data to lighting
            int i = 0;
            while( dataLighting["lighting_" + i + "_name"] != null )
            {
                Console.WriteLine("i = {0}", i);
                var lt = new Lighting()
                {
                    Name = dataLighting["lighting_" + i + "_name"],
                    Path = dataLighting["lighting_" + i + "_path"]
                };
                _lightings.Add(lt);

                Console.WriteLine(lt.Name, lt.Path);
                i++;
            }

            //Render combo box Lighting 
            RenderComboBoxLighting();
            comboBoxSide.SelectedIndex = 0;

            //Folder Browser Dialog
            _folderDlg = new FolderBrowserDialog();

            //Set Yulgang path
            if( _settingData["app"]["yulgang_path"] != null && CheckPathYulgang(_settingData["app"]["yulgang_path"]) )
            {
                SetPathYulgang(_settingData["app"]["yulgang_path"]);
            }

            //Set logo
            pictureBoxLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\data\\logo.png");
        }

        private void RenderComboBoxLighting()
        {
            foreach( var lighting in _lightings )
            {
                comboBoxLighting.Items.Add(new ComboboxItem() { Text = lighting.Name, Value = lighting.Path });
            }
            comboBoxLighting.SelectedIndex = 1;
        }

        private void buttonFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            //Show the FolderBrowserDialog
            DialogResult result = _folderDlg.ShowDialog();
            if( result == DialogResult.OK )
            {
                if( CheckPathYulgang(_folderDlg.SelectedPath) )
                {
                    SetPathYulgang(_folderDlg.SelectedPath);
                }
                else
                {
                    MessageBox.Show(@"นี่ไม่ใช่โฟลเดอร์ที่ติดตั้งตัวเกม Yulgang กรุณาลองใหม่!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckPathYulgang(string path)
        {
            return File.Exists(Path.GetFullPath(Path.Combine(path, "client\\YGOnline.exe")));
        }

        private void SetPathYulgang(string path)
        {
            _yulgangPath = path;
            _yulgangEffectPath = Path.GetFullPath(Path.Combine(path, LightingPath));
            textBoxYulgangPath.Text = path;

            Console.WriteLine(_yulgangPath);
            Console.WriteLine(_yulgangEffectPath);

            //Cache yulgang path
            var parser = new FileIniDataParser();
            _settingData["app"]["yulgang_path"] = _yulgangPath;
            parser.WriteFile(AppDomain.CurrentDomain.BaseDirectory + @"/profile.ini", _settingData);
        }

        private void RollbackLighting()
        {
            //Red
            var red = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settingData["lighting"]["lighting_none_path"])) + "\\red.amd";
            var yulgangRed = _yulgangEffectPath + "\\" + LightingRed;
            File.Copy(red, yulgangRed, true);

            //Blue
            var blue = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settingData["lighting"]["lighting_none_path"])) + "\\blue.amd";
            var yulgangBlue = _yulgangEffectPath + "\\" + LightingBlue;
            File.Copy(blue, yulgangBlue, true);

            //Lighting red 1.5
            var redFirePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settingData["lighting"]["lighting_0_path"])) + "\\fire.dxt";
            var redThunderboltPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settingData["lighting"]["lighting_0_path"]))+ "\\thunderbolt.dxt";
            File.Copy(redFirePath, _yulgangEffectPath + "\\" + LightingRedFire, true);
            File.Copy(redThunderboltPath, _yulgangEffectPath + "\\" + LightingRedThunderbolt, true);

            //Lighting blue 1.5
            var blueFirePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settingData["lighting"]["lighting_1_path"])) + "\\fire.dxt";
            var blueThunderboltPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _settingData["lighting"]["lighting_1_path"]))+ "\\thunderbolt.dxt";
            File.Copy(blueFirePath, _yulgangEffectPath + "\\" + LightingBlueFire, true);
            File.Copy(blueThunderboltPath, _yulgangEffectPath + "\\" + LightingBlueThunderbolt, true);
        }
        private void buttonChangeLighting_Click(object sender, EventArgs e)
        {
            var lightPath = ((ComboboxItem) comboBoxLighting.SelectedItem).Value.ToString();
            var firePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, lightPath)) + "\\fire.dxt";
            var thunderboltPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, lightPath))+ "\\thunderbolt.dxt";

            Console.WriteLine("fire : " + firePath);
            Console.WriteLine("thunderbolt : " + thunderboltPath);
            Console.WriteLine(File.Exists(firePath));
            Console.WriteLine(File.Exists(thunderboltPath));

            if( File.Exists(firePath) && File.Exists(thunderboltPath) )
            {
                var yulgangLighting = _yulgangEffectPath;
                var yulgangFirePath = _yulgangEffectPath;
                var yulgangThunderboltPath = _yulgangEffectPath;

                //Check side
                if( comboBoxSide.SelectedIndex == 0 )
                {
                    //RED
                    yulgangLighting += "\\" + LightingRed;
                    yulgangFirePath += "\\" + LightingRedFire;
                    yulgangThunderboltPath += "\\" + LightingRedThunderbolt;
                }
                else
                {
                    //BLUE
                    yulgangLighting += "\\" + LightingBlue;
                    yulgangFirePath += "\\" + LightingBlueFire;
                    yulgangThunderboltPath += "\\" + LightingBlueThunderbolt;
                }

                //Copy file
                try
                {
                    //Rollback first
                    RollbackLighting();

                    if (comboBoxLighting.SelectedIndex == 0)
                    {
                        //None lighting
                        File.Delete(yulgangLighting);
                    }
                    else
                    {
                        Console.WriteLine("Copy :");
                        Console.WriteLine(firePath);
                        Console.WriteLine(yulgangFirePath);
                        Console.WriteLine("Copy :");
                        Console.WriteLine(thunderboltPath);
                        Console.WriteLine(yulgangThunderboltPath);

                        File.Copy(firePath, yulgangFirePath, true);
                        File.Copy(thunderboltPath, yulgangThunderboltPath, true);
                    }
                    
                    MessageBox.Show(@"เรียบร้อยแล้ว เข้าเกมใหม่ได้เลย!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch( Exception exception )
                {
                    Console.WriteLine(exception.Message);
                    MessageBox.Show("โปรแกรมไม่สามารถคัดลอกไฟล์ได้ กรุณาให้สิทธิ์โปรแกรมก่อน! \n(Run as Administrator)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"ไฟล์โปรแกรมไม่สมบูรณ์ คลิกที่เมนู ""อัปเดต""เพื่อเข้าไปหน้าเว็บไซต์แล้วโหลดโปรแกรมใหม่!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxLighting_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lightPath = ((ComboboxItem) comboBoxLighting.SelectedItem).Value.ToString();
            var cover = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, lightPath)) + "\\cover.png";

            //Load cover
            pictureBoxCover.Image = Image.FromFile(cover);
        }

        private void buttonRollbackLighting_Click(object sender, EventArgs e)
        {
            try
            {
                RollbackLighting();
                MessageBox.Show(@"เรียบร้อยแล้ว เข้าเกมใหม่ได้เลย!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch( Exception exception )
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("โปรแกรมไม่สามารถคัดลอกไฟล์ได้ กรุณาให้สิทธิ์โปรแกรมก่อน! \n(Run as Administrator)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/meawmuay/yulgang-lighting");
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("โปรแกรมนี้สร้างโดย แมวหมวย\nหากคุณพบปัญหา กรุณาติดต่อเราเพื่อแก้ไข", "เกี่ยวกับ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
