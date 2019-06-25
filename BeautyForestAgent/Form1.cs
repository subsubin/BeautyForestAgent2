using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public string Title
        {
            set { this.Text = value; }
        }

    public Form1()
        {
            InitializeComponent();
        }

        private void ShowModify()
        {
            this.statusMessage.Text = "수정 창을 띄웁니다.";
            FormModify m = new FormModify();
            m.Title = "수정 창띄우기";
            m.ShowDialog();
        }

        private void ShowAdd()
        {
            this.statusMessage.Text = "추가 창을 띄웁니다.";
            FormAdd m = new FormAdd();
            m.Title = "추가 창띄우기";
            m.Show();
        }

        private void 이프로그램은ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은..";
            FormAbout m = new FormAbout();
            m.Title = "이 프로그램은..";
            m.ShowDialog();

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ShowModify();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ShowAdd();
        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "종료합니다.";
            Application.ExitThread();  // 어플리케이션 쓰레드 완전 종료
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModify();
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAdd();
        }
    }

}
