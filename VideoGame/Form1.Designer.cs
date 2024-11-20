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
            this.btnOpenMap = new System.Windows.Forms.Button();
            this.lEnemyHp = new System.Windows.Forms.Label();
            this.lPlayerHp = new System.Windows.Forms.Label();
            this.bNext = new System.Windows.Forms.Button();
            this.pEndBattle = new System.Windows.Forms.Panel();
            this.pBattleActions = new System.Windows.Forms.Panel();
            this.bAttack = new System.Windows.Forms.Button();
            this.bSkills = new System.Windows.Forms.Button();
            this.lbSkills = new System.Windows.Forms.ListBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pBattle.SuspendLayout();
            this.pBattleActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pBattle
            // 
            this.pBattle.BackColor = System.Drawing.Color.Tomato;
            this.pBattle.BackgroundImage = global::VideoGame.Properties.Resources.R;
            this.pBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBattle.Controls.Add(this.btnOpenMap);
            this.pBattle.Controls.Add(this.lEnemyHp);
            this.pBattle.Controls.Add(this.lPlayerHp);
            this.pBattle.Controls.Add(this.bNext);
            this.pBattle.Controls.Add(this.pEndBattle);
            this.pBattle.Controls.Add(this.pBattleActions);
            this.pBattle.Controls.Add(this.pbEnemy);
            this.pBattle.Controls.Add(this.pbPlayer);
            this.pBattle.Location = new System.Drawing.Point(0, -2);
            this.pBattle.Margin = new System.Windows.Forms.Padding(4);
            this.pBattle.Name = "pBattle";
            this.pBattle.Size = new System.Drawing.Size(1067, 560);
            this.pBattle.TabIndex = 5;
            // 
            // btnOpenMap
            // 
            this.btnOpenMap.BackgroundImage = global::VideoGame.Properties.Resources.Screenshot_2024_11_19_141920;
            this.btnOpenMap.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMap.ForeColor = System.Drawing.Color.Gold;
            this.btnOpenMap.Location = new System.Drawing.Point(948, 30);
            this.btnOpenMap.Name = "btnOpenMap";
            this.btnOpenMap.Size = new System.Drawing.Size(116, 48);
            this.btnOpenMap.TabIndex = 13;
            this.btnOpenMap.Text = "Shop";
            this.btnOpenMap.UseVisualStyleBackColor = true;
            this.btnOpenMap.Click += new System.EventHandler(this.btnOpenMap_Click);
            // 
            // lEnemyHp
            // 
            this.lEnemyHp.AutoSize = true;
            this.lEnemyHp.BackColor = System.Drawing.Color.Transparent;
            this.lEnemyHp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnemyHp.ForeColor = System.Drawing.Color.Gold;
            this.lEnemyHp.Location = new System.Drawing.Point(647, 316);
            this.lEnemyHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEnemyHp.Name = "lEnemyHp";
            this.lEnemyHp.Size = new System.Drawing.Size(94, 23);
            this.lEnemyHp.TabIndex = 8;
            this.lEnemyHp.Text = "20 / 20";
            // 
            // lPlayerHp
            // 
            this.lPlayerHp.AutoSize = true;
            this.lPlayerHp.BackColor = System.Drawing.Color.Transparent;
            this.lPlayerHp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerHp.ForeColor = System.Drawing.Color.Gold;
            this.lPlayerHp.Location = new System.Drawing.Point(324, 191);
            this.lPlayerHp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayerHp.Name = "lPlayerHp";
            this.lPlayerHp.Size = new System.Drawing.Size(94, 23);
            this.lPlayerHp.TabIndex = 9;
            this.lPlayerHp.Text = "20 / 20";
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(954, 501);
            this.bNext.Margin = new System.Windows.Forms.Padding(4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(100, 28);
            this.bNext.TabIndex = 0;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // pEndBattle
            // 
            this.pEndBattle.BackColor = System.Drawing.Color.Transparent;
            this.pEndBattle.Location = new System.Drawing.Point(909, 405);
            this.pEndBattle.Margin = new System.Windows.Forms.Padding(4);
            this.pEndBattle.Name = "pEndBattle";
            this.pEndBattle.Size = new System.Drawing.Size(145, 65);
            this.pEndBattle.TabIndex = 12;
            this.pEndBattle.Visible = false;
            // 
            // pBattleActions
            // 
            this.pBattleActions.BackColor = System.Drawing.Color.Transparent;
            this.pBattleActions.Controls.Add(this.bAttack);
            this.pBattleActions.Controls.Add(this.bSkills);
            this.pBattleActions.Controls.Add(this.lbSkills);
            this.pBattleActions.Location = new System.Drawing.Point(227, 401);
            this.pBattleActions.Margin = new System.Windows.Forms.Padding(4);
            this.pBattleActions.Name = "pBattleActions";
            this.pBattleActions.Size = new System.Drawing.Size(311, 128);
            this.pBattleActions.TabIndex = 11;
            // 
            // bAttack
            // 
            this.bAttack.BackgroundImage = global::VideoGame.Properties.Resources.Screenshot_2024_11_19_141920;
            this.bAttack.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAttack.ForeColor = System.Drawing.Color.Gold;
            this.bAttack.Location = new System.Drawing.Point(4, 4);
            this.bAttack.Margin = new System.Windows.Forms.Padding(4);
            this.bAttack.Name = "bAttack";
            this.bAttack.Size = new System.Drawing.Size(99, 42);
            this.bAttack.TabIndex = 10;
            this.bAttack.Text = "Attack";
            this.bAttack.UseVisualStyleBackColor = true;
            this.bAttack.Click += new System.EventHandler(this.bAttack_Click);
            // 
            // bSkills
            // 
            this.bSkills.BackgroundImage = global::VideoGame.Properties.Resources.Screenshot_2024_11_19_141920;
            this.bSkills.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSkills.ForeColor = System.Drawing.Color.Gold;
            this.bSkills.Location = new System.Drawing.Point(196, 4);
            this.bSkills.Margin = new System.Windows.Forms.Padding(4);
            this.bSkills.Name = "bSkills";
            this.bSkills.Size = new System.Drawing.Size(100, 42);
            this.bSkills.TabIndex = 11;
            this.bSkills.Text = "Skills";
            this.bSkills.UseVisualStyleBackColor = true;
            this.bSkills.Click += new System.EventHandler(this.bSkills_Click);
            // 
            // lbSkills
            // 
            this.lbSkills.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbSkills.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkills.ForeColor = System.Drawing.Color.Black;
            this.lbSkills.FormattingEnabled = true;
            this.lbSkills.ItemHeight = 27;
            this.lbSkills.Items.AddRange(new object[] {
            "Fireball",
            "Heal"});
            this.lbSkills.Location = new System.Drawing.Point(200, 56);
            this.lbSkills.Margin = new System.Windows.Forms.Padding(4);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(96, 58);
            this.lbSkills.TabIndex = 12;
            this.lbSkills.Visible = false;
            this.lbSkills.SelectedIndexChanged += new System.EventHandler(this.lbSkills_SelectedIndexChanged);
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy.Image = global::VideoGame.Properties.Resources.dbzw90t_c2f2ed32_f000_4098_91f6_15a8c8e244b1_removebg_preview;
            this.pbEnemy.Location = new System.Drawing.Point(622, 316);
            this.pbEnemy.Margin = new System.Windows.Forms.Padding(4);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(139, 97);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy.TabIndex = 7;
            this.pbEnemy.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::VideoGame.Properties.Resources.Screenshot_2024_11_18_125543_removebg_preview1;
            this.pbPlayer.Location = new System.Drawing.Point(261, 191);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(206, 200);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 6;
            this.pbPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pBattle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pBattle.ResumeLayout(false);
            this.pBattle.PerformLayout();
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
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bSkills;
        private System.Windows.Forms.ListBox lbSkills;
        private System.Windows.Forms.Panel pEndBattle;
        private System.Windows.Forms.Button btnOpenMap;
    }
}

