 using System.Data.Common;
 using System.Security.Cryptography;

namespace WinFormsApp1;

 public partial class Form1 : Form 
 {
     public Form1()
     {
         InitializeComponent();
         this.Load += Form1_load;
     }

     private void Form1_load(Object sender, EventArgs e)
     {
         //throw new NotImplementedException();
         this.Text = "这个是一个测试的窗体程序";
         //是否允许最大化最小化
         this.MaximizeBox = true;

         this.ClientSize = new System.Drawing.Size(900, 700);
         this.Name = "窗体";

         this.ResumeLayout(false);
     }
 }