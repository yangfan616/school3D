using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School3D
{
    public partial class 帮助 : Form
    {
        public 帮助()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 帮助_Load(object sender, EventArgs e)
        {

        }
        
        private void 标签功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            richTextBox1.Text = "";
            str.AppendLine("欢迎来到数字校园地图管理程序:书签功能介绍!");
            str.AppendLine("书签管理模块包含为当前视图添加书签，缩放至书签，删除某一书签和清空所有书签功能");
            str.AppendLine("操作说明：书签功能在本程序中作用为定位你想要保存的位置,点击书签即可立刻转到你建立标签时候的3d地图的位置");
            richTextBox1.Text += str;
        }
        private void 基础功能介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            richTextBox1.Text = "";
            str.AppendLine("欢迎来到数字校园地图管理程序:基础功能介绍!");
            str.AppendLine("基础功能包括：1 打开地图 2 导航 3 漫游 4 缩放 5 放大至图层 6 测量模式 7 信息概览 ");
            str.AppendLine("操作说明：打开地图即为打开3D图像.导航,缩放和漫游即为对导入的3D地图进行全方位无死角查看.放大至图层即为立刻跳转到你所选图层.测量模式即为得到你在地图上所选两点之间的距离.信息概览模式中可查看点击任意一点的属性");
            richTextBox1.Text+=str;
        }

        private void 鹰眼模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            richTextBox1.Text = "";
            str.AppendLine("欢迎来到数字校园地图管理程序:鹰眼模式介绍");
            str.AppendLine("鹰眼模式是二维地图中显示三维地图的对应位置，当三维地图显示区域变化时，二维地图上显示的位置也会相应变化。也可以在二维地图画矩形来控制三维地图的显示区域");
            richTextBox1.Text += str;
        }

        private void 查询共功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            richTextBox1.Text = "";
            str.AppendLine("欢迎来到数字校园地图管理程序:查询模式介绍");
            str.AppendLine("查询模块功能包括输入内容查询建筑物、得到查询结果、放大至查询结果等");
            str.AppendLine("操作说明：本程序的查询功能主要是查询3d图片中的模型的name属性，得到结果和位置，用户可以直接查询想要得到的地物的name属性，点击“放大查询结果”即可得到具体位置");
            richTextBox1.Text += str;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            richTextBox1.Text = "";
            str.AppendLine("copyright: shuyuan ou 、 yangfan 、 chengkun gan , 三只小咸鱼");
            str.AppendLine("程序成型时间较短，还有诸多不足之处，望谅解，以后会慢慢完善！");
            richTextBox1.Text += str;
        }

    }
}
