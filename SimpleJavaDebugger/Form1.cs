using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleJavaDebugger
{
    public partial class Form1 : Form
    {
        public static string filePathWithName = "";
        public static string filePathWithoutName = "";
        public static string fileName = "";
        public static string className = "";
        public static bool isCompiled = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveJavaCode();
        }
        //编译
        private void compile_Click(object sender, EventArgs e)
        {
            compileJava();
        }

        private void run_Click(object sender, EventArgs e)
        {
            runClass();
        }

        private void compileAndRun_Click(object sender, EventArgs e)
        {
            if (compileJava() == 1)
                runClass();
        }

        public bool saveJavaFile()
        {
            // "保存为"对话框
            SaveFileDialog dialog = saveJavaFileDialog;
            dialog.Filter = "java文件|*.java";
            // 显示对话框
            saveStatusLabel.Text = "正在保存...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 路径带文件名
                filePathWithName = dialog.FileName;
                //获取文件名，不带路径  
                fileName = filePathWithName.Substring(filePathWithName.LastIndexOf("\\") + 1);
                //获取文件路径，不带文件名 
                filePathWithoutName = filePathWithName.Substring(0, filePathWithName.LastIndexOf("\\"));
                className = fileName.Replace(".java", "");
                saveStatusLabel.Text = "文件位置:" + filePathWithName;
                return true;
            }
            else// if(dialog.ShowDialog() == DialogResult.Cancel)
            {
                saveStatusLabel.Text = "文件未保存";
                return false;
            }
        }
        public bool saveJavaCode()
        {
            if (filePathWithName == "")
            {
                if (!saveJavaFile())
                    return false;
            }

            // 创建文件，准备写入
            FileStream fs = File.Open(filePathWithName,
                    FileMode.Create,
                    FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs, Encoding.Default);

            // 逐行将textBox1的内容写入到文件中
            foreach (string line in inputBox.Lines)
            {
                string str = line.Replace("\n", "");
                wr.WriteLine(str);

            }

            // 关闭文件
            wr.Flush();
            wr.Close();
            fs.Close();
            return true;

        }
        public void openJavaCode()
        {
            //if (filePathWithName == "") openJavaFile();
            // 创建文件，准备写入
            using (FileStream fs = File.Open(filePathWithName, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string myStr = sr.ReadToEnd();
                inputBox.Text = myStr;
            };
        }
        public int compileJava()
        {
            debugStatusLabel.Text = "正在编译...";
            debugStatusLabel.ForeColor = Color.Orange;
            if (!saveJavaCode())
                return -1;
            string sPath = Environment.GetEnvironmentVariable("JAVA_HOME");

            string path = sPath + @"\bin\javac";
            string fileNames = path;
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.FileName = fileNames;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = filePathWithName;//参数以空格分隔，如果某个参数为空，可以传入””
            StreamWriter s = p.StandardInput;
            s.WriteLine("s");
//                p.StandardInput.WriteLine("exit");
            p.StandardInput.AutoFlush = true;
            p.Start();

          
            p.WaitForExit();
            //此处可以返回一个字符串，此例是返回压缩成功之后的一个文件路径
            
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();

            
            if (output == "" && error == "")
            {
                isCompiled = true;
                run.Enabled = true;
                outputBox.Text = "";
                debugStatusLabel.Text = "编译成功！";
                debugStatusLabel.ForeColor = Color.Green;
                return 1;
            }
            else
            {
                outputBox.Text = error;
                debugStatusLabel.Text = "编译失败！";
                debugStatusLabel.ForeColor = Color.Red;
                return 0;
            }
        }

        public void runClass()
        {
            debugStatusLabel.Text = "正在运行...";
            debugStatusLabel.ForeColor = Color.Orange;
            // if (filePathWithName == "") saveJavaFile();
            string sPath = Environment.GetEnvironmentVariable("JAVA_HOME");

            string path = sPath + @"\bin\java";
            string fileNames = path;
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = fileNames;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "-classpath " + filePathWithoutName + " " + className;//参数以空格分隔，如果某个参数为空，可以传入””
            p.Start();
            p.WaitForExit();
            //此处可以返回一个字符串，此例是返回压缩成功之后的一个文件路径
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            if (output == "" && error == "")
            {
                isCompiled = true;
                run.Enabled = true;
                outputBox.Text = "程序运行无返回结果";

                debugStatusLabel.Text = "运行成功！";
                debugStatusLabel.ForeColor = Color.Green;
            }
            else if (error != "")
            {
                outputBox.Text = "ERROR:" + error + "\r\n" + output.Replace("\n", "\r\n");

                debugStatusLabel.Text = "运行失败！";
                debugStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                outputBox.Text = output.Replace("\n", "\r\n"); ;

                debugStatusLabel.Text = "运行成功！";
                debugStatusLabel.ForeColor = Color.Green;
            }
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // 路径带文件名
            filePathWithName = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            //获取文件名，不带路径
            fileName = filePathWithName.Substring(filePathWithName.LastIndexOf("\\") + 1);
            //获取文件路径，不带文件名 
            filePathWithoutName = filePathWithName.Substring(0, filePathWithName.LastIndexOf("\\"));
            className = fileName.Replace(".java", "");
            saveStatusLabel.Text = "文件位置:" + filePathWithName;
            openJavaCode();
        }
    }
}
