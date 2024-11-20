namespace VideoGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBattle = new System.Windows.Forms.Panel();
            this.pEndBattle = new System.Windows.Forms.Panel();
            this.bNext = new System.Windows.Forms.Button();
            this.pBattleActions = new System.Windows.Forms.Panel();
            this.bAttack = new System.Windows.Forms.Button();
            this.lPlayerHp = new System.Windows.Forms.Label();
            this.lEnemyHp = new System.Windows.Forms.Label();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.bSkills = new System.Windows.Forms.Button();
            this.lbSkills = new System.Windows.Forms.ListBox();
            this.pBattle.SuspendLayout();
            this.pEndBattle.SuspendLayout();
            this.pBattleActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pBattle
            // 
            this.pBattle.Controls.Add(this.pEndBattle);
            this.pBattle.Controls.Add(this.pBattleActions);
            this.pBattle.Controls.Add(this.lPlayerHp);
            this.pBattle.Controls.Add(this.lEnemyHp);
            this.pBattle.Controls.Add(this.pbEnemy);
            this.pBattle.Controls.Add(this.pbPlayer);
            this.pBattle.Location = new System.Drawing.Point(0, -2);
            this.pBattle.Name = "pBattle";
            this.pBattle.Size = new System.Drawing.Size(800, 455);
            this.pBattle.TabIndex = 5;
            // 
            // pEndBattle
            // 
            this.pEndBattle.BackColor = System.Drawing.Color.Transparent;
            this.pEndBattle.Controls.Add(this.bNext);
            this.pEndBattle.Location = new System.Drawing.Point(457, 287);
            this.pEndBattle.Name = "pEndBattle";
            this.pEndBattle.Size = new System.Drawing.Size(109, 53);
            this.pEndBattle.TabIndex = 12;
            this.pEndBattle.Visible = false;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(14, 13);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 0;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // pBattleActions
            // 
            this.pBattleActions.Controls.Add(this.lbSkills);
            this.pBattleActions.Controls.Add(this.bSkills);
            this.pBattleActions.Controls.Add(this.bAttack);
            this.pBattleActions.Location = new System.Drawing.Point(102, 287);
            this.pBattleActions.Name = "pBattleActions";
            this.pBattleActions.Size = new System.Drawing.Size(291, 143);
            this.pBattleActions.TabIndex = 11;
            // 
            // bAttack
            // 
            this.bAttack.Location = new System.Drawing.Point(18, 13);
            this.bAttack.Name = "bAttack";
            this.bAttack.Size = new System.Drawing.Size(75, 23);
            this.bAttack.TabIndex = 10;
            this.bAttack.Text = "Attack";
            this.bAttack.UseVisualStyleBackColor = true;
            this.bAttack.Click += new System.EventHandler(this.bAttack_Click);
            // 
            // lPlayerHp
            // 
            this.lPlayerHp.AutoSize = true;
            this.lPlayerHp.Location = new System.Drawing.Point(137, 72);
            this.lPlayerHp.Name = "lPlayerHp";
            this.lPlayerHp.Size = new System.Drawing.Size(42, 13);
            this.lPlayerHp.TabIndex = 9;
            this.lPlayerHp.Text = "20 / 20";
            // 
            // lEnemyHp
            // 
            this.lEnemyHp.AutoSize = true;
            this.lEnemyHp.Location = new System.Drawing.Point(425, 72);
            this.lEnemyHp.Name = "lEnemyHp";
            this.lEnemyHp.Size = new System.Drawing.Size(42, 13);
            this.lEnemyHp.TabIndex = 8;
            this.lEnemyHp.Text = "20 / 20";
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackColor = System.Drawing.Color.Lime;
            this.pbEnemy.Location = new System.Drawing.Point(428, 113);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(25, 25);
            this.pbEnemy.TabIndex = 7;
            this.pbEnemy.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Blue;
            this.pbPlayer.Location = new System.Drawing.Point(140, 113);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(25, 25);
            this.pbPlayer.TabIndex = 6;
            this.pbPlayer.TabStop = false;
            // 
            // bSkills
            // 
            this.bSkills.Location = new System.Drawing.Point(109, 13);
            this.bSkills.Name = "bSkills";
            this.bSkills.Size = new System.Drawing.Size(75, 23);
            this.bSkills.TabIndex = 11;
            this.bSkills.Text = "Skills";
            this.bSkills.UseVisualStyleBackColor = true;
            this.bSkills.Click += new System.EventHandler(this.bSkills_Click);
            // 
            // lbSkills
            // 
            this.lbSkills.FormattingEnabled = true;
            this.lbSkills.Items.AddRange(new object[] {
            "Fireball",
            "Heal"});
            this.lbSkills.Location = new System.Drawing.Point(201, 13);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(73, 56);
            this.lbSkills.TabIndex = 12;
            this.lbSkills.Visible = false;
            this.lbSkills.SelectedIndexChanged += new System.EventHandler(this.lbSkills_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBattle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pBattle.ResumeLayout(false);
            this.pBattle.PerformLayout();
            this.pEndBattle.ResumeLayout(false);
            this.pBattleActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pBattle;
        private System.Windows.Forms.Button bAttack;
        private System.Windows.Forms.Label lPlayerHp;
        private System.Windows.Forms.Label lEnemyHp;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Panel pBattleActions;
        private System.Windows.Forms.Panel pEndBattle;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bSkills;
        private System.Windows.Forms.ListBox lbSkills;
    }
}

