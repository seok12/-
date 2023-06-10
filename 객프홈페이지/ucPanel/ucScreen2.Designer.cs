namespace 객프홈페이지.ucPanel
{
    partial class ucScreen2
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox1.Location = new System.Drawing.Point(29, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 616);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "coffee                                     \r\n아메리카노 \r\n돌체 라떼\r\n카라멜 마키야또\r\n초콜릿 모카\r\n카페 " +
    "라떼\r\n바닐라 마키아또\r\n콜드 브루\r\n\r\ntea\r\n바닐라 티 라떼\r\n말차 티\r\n밀크 티\r\n유자 밀크 티";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox2.Location = new System.Drawing.Point(401, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 616);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "frappuccino\r\n자바 칩\r\n에스프레소 칩\r\n말차 크림\r\n바닐라 크림\r\n민트 초코 칩\r\n망고 바나나\r\n\r\n\r\nade\r\n블루레몬에이드\r\n자몽에" +
    "이드\r\n애플망고에디드\r\n청보도에이드";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox3.Location = new System.Drawing.Point(751, 116);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 616);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "side\r\n당근치즈브라우니\r\n소금빵\r\n바질토마토 치킨\r\n에그마요 소금빵\r\n마카롱\r\n핫도그\r\n미니 붕어빵\r\n옥수수빵\r\n크로플\r\n카스테라\r\n패스트리\r" +
    "\n조각케이크\r\n치즈빵\r\n팥크림빵";
            // 
            // ucScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "ucScreen2";
            this.Size = new System.Drawing.Size(1090, 910);
            this.Load += new System.EventHandler(this.ucScreen2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
