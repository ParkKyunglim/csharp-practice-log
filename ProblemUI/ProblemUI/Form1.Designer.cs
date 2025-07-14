
namespace ProblemUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProblem1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.btnProblem3 = new System.Windows.Forms.Button();
            this.btnProblem4 = new System.Windows.Forms.Button();
            this.btnProblem5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProblem1
            // 
            this.btnProblem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProblem1.Location = new System.Drawing.Point(102, 33);
            this.btnProblem1.Name = "btnProblem1";
            this.btnProblem1.Size = new System.Drawing.Size(161, 60);
            this.btnProblem1.TabIndex = 0;
            this.btnProblem1.Text = "문제 1";
            this.btnProblem1.UseVisualStyleBackColor = true;
            this.btnProblem1.Click += new System.EventHandler(this.btnProblem1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOutput.Location = new System.Drawing.Point(360, 33);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(381, 370);
            this.txtOutput.TabIndex = 1;
            // 
            // btnProblem2
            // 
            this.btnProblem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProblem2.Location = new System.Drawing.Point(102, 113);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(161, 60);
            this.btnProblem2.TabIndex = 2;
            this.btnProblem2.Text = "문제 2";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // btnProblem3
            // 
            this.btnProblem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProblem3.Location = new System.Drawing.Point(102, 188);
            this.btnProblem3.Name = "btnProblem3";
            this.btnProblem3.Size = new System.Drawing.Size(161, 60);
            this.btnProblem3.TabIndex = 3;
            this.btnProblem3.Text = "문제 3";
            this.btnProblem3.UseVisualStyleBackColor = true;
            this.btnProblem3.Click += new System.EventHandler(this.btnProblem3_Click);
            // 
            // btnProblem4
            // 
            this.btnProblem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProblem4.Location = new System.Drawing.Point(102, 264);
            this.btnProblem4.Name = "btnProblem4";
            this.btnProblem4.Size = new System.Drawing.Size(161, 60);
            this.btnProblem4.TabIndex = 3;
            this.btnProblem4.Text = "문제 4";
            this.btnProblem4.UseVisualStyleBackColor = true;
            this.btnProblem4.Click += new System.EventHandler(this.btnProblem4_Click);
            // 
            // btnProblem5
            // 
            this.btnProblem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProblem5.Location = new System.Drawing.Point(102, 343);
            this.btnProblem5.Name = "btnProblem5";
            this.btnProblem5.Size = new System.Drawing.Size(161, 60);
            this.btnProblem5.TabIndex = 3;
            this.btnProblem5.Text = "문제 5";
            this.btnProblem5.UseVisualStyleBackColor = true;
            this.btnProblem5.Click += new System.EventHandler(this.btnProblem5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProblem5);
            this.Controls.Add(this.btnProblem4);
            this.Controls.Add(this.btnProblem3);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnProblem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProblem1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Button btnProblem3;
        private System.Windows.Forms.Button btnProblem4;
        private System.Windows.Forms.Button btnProblem5;
    }
}

