# 内容简介
因为毕业设计要用到，所以计划用一个月的时间自学Winform编程
（2020/3/20-2020/4/17），以下是我的自学笔记，需要的朋友们请自提：

### 使用教材：《C#Winform实践开发教程 》钱哨 + B站
（B站和CSDN是我名誉教授没错了）
### 开发环境： Visual Studio 2013 Freamwork 4.0

为多篇复合笔记，分为代码讲解，控件介绍以及实操记录三个部分，需要的朋友可以在我的Winform自学专栏里找它，比心~

### 内容一览
1. 代码结构
2. 修改窗体外观
3. 窗体的基本事件
4. 控件——按钮 Button
5. 控件——文本框 TextBook
6. 控件——标签 Label
7. 一个操作实例：建立第一个Winform应用——员工信息录入功能
### 正文
2020/3/20——新手小白充满元气的第一天！

### 1.打开软件后自动生成的基础代码

```shell script
using System; //基础核心命名空间
using System.collections.Generic;//包含了一大堆基础类
using System.ComponentModel;//
using System.Data;//数据库访问控制
using System.Drawing;//绘图类
using System.text;//文本类
using Sywtem.Windows.Forms;//大量窗体和控件

namespace WindowsApplication1  //WindowsApplication1是窗体的名字，建立窗体的时候设置的 
{
	public partial class Form011:Form  //从System.Windows.Forms.Form派生
	{
		public Form011()
		{
			InitializeComponent();//初始化函数 
		}
	 } 
 } 
```
### 2.InitializeComponent()方法

由系统生成的对于窗体界面的定义方法。
窗体的名字一般默认为Form，每一个Form被建立以后，都会同时产生程序代码文件（.CS文件）以及与之相匹配的**.Desigener.CS**文件。业务逻辑以及事件方法等被编写在.CS文件中，而界面设计规则责备封装在Designer.CS文件里。
### 2.1 Designer.CS

```shell script
namespace brilandtest2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn1.Location = new System.Drawing.Point(132, 71);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(212, 102);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "testbutton";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(494, 273);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Briland";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
    }
}
```

### 2.2 .CS文件
是一个设计文件。
![img](https://img-blog.csdnimg.cn/20200329141634406.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)


### 3.Winform应用程序中第一个被触发的程序。
在解决资源管理器中选定项目，右键选择“设为启动项目”。

### （一）修改窗体外观
### 1.如何新建窗体？

①打开visual studio 2013，选择文件-》新建项目-》在弹出窗体的左侧选择C#下的windows-》选择Framework4-》选择Windows桌面应用；
②建好项目之后，固定左侧的工具箱（如果找不到工具箱就打开上面的视图选项-》工具箱），打开工具箱之后点击上面的小钉子那个按钮就固定住啦；

新建好的窗体如图：
![img](https://img-blog.csdnimg.cn/20200320161453156.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 2.如何修改标题和默认图标？
标题：只需要修改窗体的Text属性即可。
图标：修改属性Icon （图标图片必须是.ico文件，可以在网上线上转换一下）

### 要展开代码，可以双击application，也可以选择右侧“解决方案资源管理器”的Designer,黄线部分双击可以修改，修改这里和修改属性的效果是一样的。

![img](https://img-blog.csdnimg.cn/20200320161519827.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 修改代码就是双击上图的灰色框框，出现下图情况之后在A处更改

![img](https://img-blog.csdnimg.cn/20200320161732776.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 属性选项可以在视图-》属性选项-》再选择ICON

![img](https://img-blog.csdnimg.cn/20200320162345742.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 修改背景色
同样是在属性里，选择Backcolor更改窗体颜色

![img](https://img-blog.csdnimg.cn/20200320162617460.JPG#pic_center)

### 3.窗体出现的位置？
属性-》布局-》startPosition
![img](https://img-blog.csdnimg.cn/20200320162617460.JPG#pic_center)

### 4.如何固定窗体的大小？
AutoSizeMode
![img](https://img-blog.csdnimg.cn/20200320162759283.JPG#pic_center)

### 5.是否设置窗体有最大化和最小化？
设置为True就是有，FALSE就是没有
![img](https://img-blog.csdnimg.cn/2020032016292794.JPG#pic_center)

2020/3/22 “整整一天没有工作的新手小白上线了！”

### （二）窗体的基本事件
1.在属性当中，有的属性可以去掉，有的属性不能。比如下图中的Name属性，它外面带着括号，这种就是必须存在的，因为它是某个class的名字，所以不能去掉。
![img](https://img-blog.csdnimg.cn/20200322152245865.JPG#pic_center)
### 2.在程序中插入断点的方式
①在程序里右键，选择插入断点；
②直接在灰白色的地方点击；

### 3.在解读程序时要注意：A处为窗体名字；B处为事件名字。
使用this可以访问当前窗体对象。
![img](https://img-blog.csdnimg.cn/20200322153606926.JPG#pic_center)
2020/3/23 “小白今天终于学到按钮惹！”

### （三）控件——按钮 Button
1.如何在已有一个窗体项目的情况下再开一个新的窗体？

在“解决方案资源管理器”里面，在黄色线的位置点击右键，选择新建项目即可。

![img](https://img-blog.csdnimg.cn/20200323161213399.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 2.按钮的基本特性：
1）在鼠标经过的时候颜色会发生改变；
2）鼠标按下时，按钮背景色会发生改变；
3）只有鼠标左键按下的时候才会被触发（右键不行）；

### 3.如何新建一个按钮？
直接在左侧工具箱左键选中公共插件中的“按钮”，然后在右侧画布上单击一下，此时画布上就会出现一个默认大小的按钮，拖动按钮的四周可以改变它的大小。

![img](https://img-blog.csdnimg.cn/20200323154837339.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 4.如何为一个按钮命名并改变它的文字内容？
下面这个花色鲜艳的画布就是我的窗体了哈哈哈哈，点击按钮之后，属性一栏里就会显示出该按钮的属性，在C处调整按钮上显示的文字内容；在A处改变按钮对象的名称（B站的小哥哥说一般把按钮简写为btn+用途）。

![img](https://img-blog.csdnimg.cn/20200323155025340.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 5.按钮外观的进一步更改
这是改变了字体，字号以及背景色之后的样子。
![img](https://img-blog.csdnimg.cn/20200323155509275.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)

### 6.所有控件通用的Enable属性——
如果不想让用户对其进行操作，可以将其Enable属性设定为false.

### 7.Button控件的属性，方法及事件：
    - Enabled:确认是否可以启用或禁用该控件；
    - PerFormClick:Button按钮的Click事件
    - Click:单击按钮时将触发该事件。
### （四）控件——文本框Textbook

4.1该控件方便用户从键盘输入。
从左侧工具箱选择TextBook，移动到画布。
![img](https://img-blog.csdnimg.cn/20200324145759812.JPG?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70#pic_center)
1）选择视图-》输出，这样就能在整个软件最下方看见输出框（即看见获取的数据）；
2）txt1是文本框的名字，在设置文本框的时候可以在它的属性一栏进行更改；
3）console.txt是输出函数；
![img](https://img-blog.csdnimg.cn/20200324150528586.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)
TextBook控件的属性：
    - MaxLength：可在文本框内输入的最大字符数；
    - Multiline:表示是否可以在文本框内输入多行文本；
    - Passwordchar:机密和敏感数据，密码输入字符；在这个属性后面输入的符号，意思是当用户输入密码时，它总是显示这个符号。
    ![img](https://img-blog.csdnimg.cn/20200401140744109.png)
    - ReadOnly:文本框中的文本为只读；
    - Text：检索在控件中输入的文本
### TextBook控件的方法及事件：

    - Clear:删除现在的所有文本
    - Show:True时显示控件
    - KeyPress:用户按一个键时发生该事件
### （六）控件——标签 Label
标签控件用于显示窗体文本信息。
属性：
    - Text ：用于设置或获取与该控件的文本；
方法：
    - Hide：隐藏控件，调用该方法时，即使Visible属性设置为True，控件也不可见；
    - Show：相当于将控件的Visible属性设置为True并显示控件
    - Click：用户单击控件时将发生的事件。
**LinkLabel**
超链接文本

### （五）一个操作实例
**【建立第一个Winform应用——员工信息录入功能】**
**实验一、建立两个窗口，掌握Label和LinkLabel控件**
**实验目标：**
建立两个窗体，当单击“Login”时，打开另一个窗体；单击：“ShowText”时，显示学校名称；单击“HideText”时，隐藏学校名称。

**实验步骤一：**

1. 从工具箱中拖拽标签控件(label)和超链接文本LinkLabel 到Form窗体上，更改标签文本的颜色，字体和大小属性，填写每个控件的Text属性，使其达到和谐美观的效果；再建立Form2窗体，以便在单击“Login”之后能将它打开。

2. 双击“Login”进入.cs文件编辑状态，准备进行开发，这是“打开新窗体”的详细代码：

```shell script
 private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;   //确认超文本文件链接是按照连接后的样式呈现
            Form3 newFrom = new Form3();//实例化From窗体,命名为newForm
            newFrom.Show();//将实例化后的窗体打开
            this.Hide();//当前的窗体隐藏
        }
```

3. “ShowText”源代码：
```shell script
// Label2是要显示的文字（TextBook控件）的名称
 private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    label2.Show();
}
```
4. “HideText”源代码：
```shell script
 private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Hide();
        }
```
5. 因为有两个窗体，所以需要在.Program文件中确定哪一个才是最开始要打开的窗体：
![img](https://img-blog.csdnimg.cn/20200330142910533.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)

6. 这是效果图：
![img](https://img-blog.csdnimg.cn/2020033014301414.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)
    单击A处
    ![img](https://img-blog.csdnimg.cn/20200330143057998.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)
    单击C处：
    ![img](https://img-blog.csdnimg.cn/20200330143150839.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)
    再单击B处：
    ![img](https://img-blog.csdnimg.cn/20200330143215507.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)
### 实验步骤二：

**目标：**
本次实验的目标是通过用户键入名称和密码，判别为非空之后，再判断是否符合系统规定的内容，无论成功或失败都提示用户操作结果。

**步骤：**

1. 从工具箱中拖拽标签控件、Button按钮以及在工具栏内的容器中的groupBox控件到Form窗体上，调整各个控件的基本属性以达到目标效果，特别值得注意的是用户米面文本框的设置工作。
2. 双击确定按钮，进入.CS 文件编辑状态，准备进行开发。
3. 源代码：
```shell script
 namespace Staff
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        if(textBox1.Text==string.Empty||textBox2.Text==string.Empty)
    {
        MessageBox.Show("信息禁止为空","登录提示");
        clearone();
            return;
    }
        else if(!textBox1.Text.Equals("admin")||!textBox2.Text.Equals("admin")){
            MessageBox.Show("用户名或密码为空","登录提示");
            clearone();
            return;

        }
        else{
            MessageBox.Show("Welcome to our system!","Information");
            clearone();
        }
        }
            public void clearone()
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox2.Focus();//清空名称和密码文本框，并使文本框获得焦点
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear ();
            textBox2.Focus();//清空名称和密码文本框，并使名称文本框获得焦点
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

           
          }
    
        }
```
效果图：
![img](https://img-blog.csdnimg.cn/20200401141015873.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0NhbWJyaWRnZTI2,size_16,color_FFFFFF,t_70)
