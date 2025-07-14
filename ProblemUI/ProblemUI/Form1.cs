using System;
using System.Windows.Forms;
using Test0714;

namespace ProblemUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProblem1_Click(object sender, EventArgs e)
        {
            string result = Problem1.Solve();
            txtOutput.Text = result;            // 출력창에 결과 표시

        }

        private void btnProblem2_Click(object sender, EventArgs e)
        {
            string result = Problem2.Solve();
            txtOutput.Text = result;
        }

        private void btnProblem3_Click(object sender, EventArgs e)
        {
            string result = Problem3.Solve();
            txtOutput.Text = result;
        }

        private void btnProblem4_Click(object sender, EventArgs e)
        {
            string result = Problem4.Solve();
            txtOutput.Text = result;
        }

        private void btnProblem5_Click(object sender, EventArgs e)
        {
            // Problem5의 Solve는 static이 아니라 인스턴스를 생성해야 호출 가능
            Problem5 p5 = new Problem5();
            string result = p5.Solve();
            txtOutput.Text = result;
        }
    }
}
