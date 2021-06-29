using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace TF2KillSay
{
    public partial class Main : Form
    {
        public static Regex PlayerKilled = new Regex(@"^(.*) killed (.*) with (.*)$");
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainMenu.SelectedIndex = 1;
        }

        private void SetTF2DirBtn_Click(object sender, EventArgs e)
        {
            if (SetTF2DirBtn.Text == "Set")
            {
                SetTF2DirBtn.Text = "Change";
                TF2Directory.Enabled = false;
                SetConfig();
            }
            else
            {
                SetTF2DirBtn.Text = "Set";
                TF2Directory.Enabled = true;
            }
        }
        private void SetPlayerNameBtn_Click(object sender, EventArgs e)
        {
            if (SetPlayerNameBtn.Text == "Set")
            {
                SetPlayerNameBtn.Text = "Change";
                PlayerName.Enabled = false;
            }
            else
            {
                SetPlayerNameBtn.Text = "Set";
                PlayerName.Enabled = true;
            }
        }
        private void SetConfig()
        {
            if (string.IsNullOrEmpty(TF2Directory.Text) || string.IsNullOrEmpty(TF2Directory.Text) || !Directory.Exists(TF2Directory.Text))
            {
                MessageBox.Show(null, "Could not locate the TF2 Directory!", "TF2 KillSay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string cfgfolder = Path.Combine(new string[] { TF2Directory.Text, @"tf\cfg" });
                string consolefilepath = Path.Combine(new string[] { TF2Directory.Text, @"tf\console.log" });
                bool cfgfolderexists = Directory.Exists(cfgfolder);
                bool consolefileexists = File.Exists(consolefilepath);
                if (!cfgfolderexists || !File.Exists(Path.Combine(new string[] { cfgfolder, @"config.cfg" })))
                {
                    MessageBox.Show(null, "Could not locate the config file and/or the cfg folder!", "TF2 KillSay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!consolefileexists)
                    {
                        File.Create(consolefilepath);
                    }
                    try
                    {
                        var cfginfo = new FileInfo(Path.Combine(new string[] { cfgfolder, @"config.cfg" }));
                        List<string> contents = File.ReadAllLines(Path.Combine(new string[] { cfgfolder, @"config.cfg" })).ToList();
                        Parallel.ForEach(contents, new ParallelOptions() { MaxDegreeOfParallelism = 10 }, line =>
                        {
                            if (line.StartsWith(@"bind F9"))
                            {
                                contents[Array.IndexOf(contents.ToArray(), line)] = @"bind ""F9"" ""exec tf2killsay/latestbind.cfg\""";
                            }
                        });
                        if (!contents.Contains(@"bind ""F9"" ""exec tf2killsay/latestbind.cfg\"""))
                        {
                            contents.Add(@"bind ""F9"" ""exec tf2killsay/latestbind.cfg""");
                        }
                        if (!contents.Contains(@"con_logfile ""console.log"""))
                        {
                            contents.Add(@"con_logfile ""console.log""");
                        }
                        if (!contents.Contains(@"exec tf2killsay/latestbind.cfg"))
                        {
                            contents.Add(@"exec tf2killsay/latestbind.cfg");
                        }
                        bool wasreadonly = cfginfo.IsReadOnly;
                        if (wasreadonly)
                        {
                            cfginfo.IsReadOnly = false;
                        }
                        File.WriteAllLines(Path.Combine(new string[] { cfgfolder, @"config.cfg" }), contents);
                        if (!Directory.Exists(Path.Combine(new string[] { cfgfolder, @"tf2killsay" })))
                        {
                            var dir = Directory.CreateDirectory(Path.Combine(new string[] { cfgfolder, @"tf2killsay" }));
                        }
                        File.WriteAllText(Path.Combine(new string[] { cfgfolder, @"tf2killsay/latestbind.cfg" }), @"echo ""TF2 KillSay - Created by the sewer pig.""");
                        if (wasreadonly)
                        {
                            /*You need to create a new variable for some reason.*/
                            var cfginfo2 = new FileInfo(Path.Combine(new string[] { cfgfolder, @"config.cfg" }))
                            {
                                IsReadOnly = true
                            };
                        }
                        new Thread(() =>
                        {
                            ReadConsole(consolefilepath);
                        })
                        { IsBackground = true, Priority = ThreadPriority.Highest }.Start();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(null, e.Message + e.StackTrace, "TF2 KillSay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        private void ReadConsole(string consolepath)
        {
            var fs = new FileStream(consolepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (var sr = new StreamReader(fs, Encoding.GetEncoding("UTF-8")))
            {
                sr.ReadToEnd();
                while (true)
                {
                    var ln = sr.ReadLine();
                    if (!string.IsNullOrEmpty(ln))
                    {
                        if (PlayerKilled.IsMatch(ln) && ln.StartsWith(PlayerName.Text))
                        {
                            var victimname = Regex.Split(Regex.Split(Regex.Split(ln.Substring(0, ln.IndexOf(Regex.Split(ln, "with").LastOrDefault())), " with")[0], $"{PlayerName} killed ").LastOrDefault(), "killed ").LastOrDefault();
                            ExecuteGameCommand($"say \"{KillSayText.Text.Replace("%v", victimname)}\"");
                        }
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
            }
        }
        private void ExecuteGameCommand(string command)
        {
            var latestcmdpath = Path.Combine(new string[] { TF2Directory.Text, @"tf\cfg\tf2killsay\latestbind.cfg" });
            try
            {
                Thread.Sleep(50);
                /*Just in case someone sets it to read-only.*/
                var cfginfo = new FileInfo(latestcmdpath)
                {
                    IsReadOnly = false
                };
                File.WriteAllText(latestcmdpath, command);
                var inp = new InputSimulator();
                inp.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.F9);
            }
            catch/* (Exception e)*/
            {
                /*MessageBox.Show(null, e.Message, "TF2 KillSay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;*/
            }
        }
    }
}
