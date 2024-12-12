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
            this.newFeedback = new System.Windows.Forms.Label();
            this.oldFeedback = new System.Windows.Forms.Label();
            this.lTarget = new System.Windows.Forms.Label();
            this.lEnemyCHp = new System.Windows.Forms.Label();
            this.lEnemyBHp = new System.Windows.Forms.Label();
            this.lEnemyAHp = new System.Windows.Forms.Label();
            this.lPlayerHp = new System.Windows.Forms.Label();
            this.bShop = new System.Windows.Forms.Button();
            this.pEndBattle = new System.Windows.Forms.Panel();
            this.bNext = new System.Windows.Forms.Button();
            this.pBattleActions = new System.Windows.Forms.Panel();
            this.bAttack = new System.Windows.Forms.Button();
            this.bSkills = new System.Windows.Forms.Button();
            this.lbSkills = new System.Windows.Forms.ListBox();
            this.pbEnemyA = new System.Windows.Forms.PictureBox();
            this.pbEnemyB = new System.Windows.Forms.PictureBox();
            this.pbEnemyC = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pBattle.SuspendLayout();
            this.pEndBattle.SuspendLayout();
            this.pBattleActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pBattle
            // 
            this.pBattle.BackColor = System.Drawing.Color.Tomato;
            this.pBattle.BackgroundImage = global::VideoGame.Properties.Resources.R;
            this.pBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBattle.Controls.Add(this.newFeedback);
            this.pBattle.Controls.Add(this.oldFeedback);
            this.pBattle.Controls.Add(this.lTarget);
            this.pBattle.Controls.Add(this.lEnemyCHp);
            this.pBattle.Controls.Add(this.lEnemyBHp);
            this.pBattle.Controls.Add(this.lEnemyAHp);
            this.pBattle.Controls.Add(this.lPlayerHp);
            this.pBattle.Controls.Add(this.bShop);
            this.pBattle.Controls.Add(this.pEndBattle);
            this.pBattle.Controls.Add(this.pBattleActions);
            this.pBattle.Controls.Add(this.pbEnemyA);
            this.pBattle.Controls.Add(this.pbEnemyB);
            this.pBattle.Controls.Add(this.pbEnemyC);
            this.pBattle.Controls.Add(this.pbPlayer);
            this.pBattle.Location = new System.Drawing.Point(0, -2);
            this.pBattle.Name = "pBattle";
            this.pBattle.Size = new System.Drawing.Size(800, 455);
            this.pBattle.TabIndex = 5;
            // 
            // newFeedback
            // 
            this.newFeedback.AutoSize = true;
            this.newFeedback.Location = new System.Drawing.Point(27, 396);
            this.newFeedback.Name = "newFeedback";
            this.newFeedback.Size = new System.Drawing.Size(0, 13);
            this.newFeedback.TabIndex = 15;
            // 
            // oldFeedback
            // 
            this.oldFeedback.AutoSize = true;
            this.oldFeedback.Location = new System.Drawing.Point(27, 372);
            this.oldFeedback.Name = "oldFeedback";
            this.oldFeedback.Size = new System.Drawing.Size(0, 13);
            this.oldFeedback.TabIndex = 14;
            // 
            // lTarget
            // 
            this.lTarget.AutoSize = true;
            this.lTarget.Location = new System.Drawing.Point(205, 216);
            this.lTarget.Name = "lTarget";
            this.lTarget.Size = new System.Drawing.Size(13, 13);
            this.lTarget.TabIndex = 18;
            this.lTarget.Text = "  ";
            // 
            // lEnemyCHp
            // 
            this.lEnemyCHp.AutoSize = true;
            this.lEnemyCHp.BackColor = System.Drawing.Color.Transparent;
            this.lEnemyCHp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnemyCHp.ForeColor = System.Drawing.Color.Gold;
            this.lEnemyCHp.Location = new System.Drawing.Point(656, 327);
            this.lEnemyCHp.Name = "lEnemyCHp";
            this.lEnemyCHp.Size = new System.Drawing.Size(78, 17);
            this.lEnemyCHp.TabIndex = 17;
            this.lEnemyCHp.Text = "20 / 20";
            // 
            // lEnemyBHp
            // 
            this.lEnemyBHp.AutoSize = true;
            this.lEnemyBHp.BackColor = System.Drawing.Color.Transparent;
            this.lEnemyBHp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnemyBHp.ForeColor = System.Drawing.Color.Gold;
            this.lEnemyBHp.Location = new System.Drawing.Point(546, 286);
            this.lEnemyBHp.Name = "lEnemyBHp";
            this.lEnemyBHp.Size = new System.Drawing.Size(78, 17);
            this.lEnemyBHp.TabIndex = 16;
            this.lEnemyBHp.Text = "20 / 20";
            // 
            // lEnemyAHp
            // 
            this.lEnemyAHp.AutoSize = true;
            this.lEnemyAHp.BackColor = System.Drawing.Color.Transparent;
            this.lEnemyAHp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnemyAHp.ForeColor = System.Drawing.Color.Gold;
            this.lEnemyAHp.Location = new System.Drawing.Point(436, 307);
            this.lEnemyAHp.Name = "lEnemyAHp";
            this.lEnemyAHp.Size = new System.Drawing.Size(78, 17);
            this.lEnemyAHp.TabIndex = 8;
            this.lEnemyAHp.Text = "20 / 20";
            // 
            // lPlayerHp
            // 
            this.lPlayerHp.AutoSize = true;
            this.lPlayerHp.BackColor = System.Drawing.Color.Transparent;
            this.lPlayerHp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerHp.ForeColor = System.Drawing.Color.Gold;
            this.lPlayerHp.Location = new System.Drawing.Point(170, 142);
            this.lPlayerHp.Name = "lPlayerHp";
            this.lPlayerHp.Size = new System.Drawing.Size(78, 17);
            this.lPlayerHp.TabIndex = 9;
            this.lPlayerHp.Text = "20 / 20";
            // 
            // bShop
            // 
            this.bShop.BackgroundImage = global::VideoGame.Properties.Resources.Screenshot_2024_11_19_141920;
            this.bShop.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShop.ForeColor = System.Drawing.Color.Gold;
            this.bShop.Location = new System.Drawing.Point(711, 24);
            this.bShop.Margin = new System.Windows.Forms.Padding(2);
            this.bShop.Name = "bShop";
            this.bShop.Size = new System.Drawing.Size(87, 39);
            this.bShop.TabIndex = 13;
            this.bShop.Text = "Shop";
            this.bShop.UseVisualStyleBackColor = true;
            this.bShop.Click += new System.EventHandler(this.bShop_Click);
            // 
            // pEndBattle
            // 
            this.pEndBattle.BackColor = System.Drawing.Color.Transparent;
            this.pEndBattle.Controls.Add(this.bNext);
            this.pEndBattle.Location = new System.Drawing.Point(679, 387);
            this.pEndBattle.Name = "pEndBattle";
            this.pEndBattle.Size = new System.Drawing.Size(109, 53);
            this.pEndBattle.TabIndex = 12;
            this.pEndBattle.Visible = false;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(19, 14);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 0;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // pBattleActions
            // 
            this.pBattleActions.BackColor = System.Drawing.Color.Transparent;
            this.pBattleActions.Controls.Add(this.bAttack);
            this.pBattleActions.Controls.Add(this.bSkills);
            this.pBattleActions.Controls.Add(this.lbSkills);
            this.pBattleActions.Location = new System.Drawing.Point(99, 320);
            this.pBattleActions.Name = "pBattleActions";
            this.pBattleActions.Size = new System.Drawing.Size(233, 120);
            this.pBattleActions.TabIndex = 11;
            // 
            // bAttack
            // 
            this.bAttack.BackgroundImage = global::VideoGame.Properties.Resources.Screenshot_2024_11_19_141920;
            this.bAttack.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAttack.ForeColor = System.Drawing.Color.Gold;
            this.bAttack.Location = new System.Drawing.Point(3, 3);
            this.bAttack.Name = "bAttack";
            this.bAttack.Size = new System.Drawing.Size(74, 34);
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
            this.bSkills.Location = new System.Drawing.Point(147, 3);
            this.bSkills.Name = "bSkills";
            this.bSkills.Size = new System.Drawing.Size(75, 34);
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
            this.lbSkills.ItemHeight = 21;
            this.lbSkills.Items.AddRange(new object[] {
            "Fireball",
            "Heal",
            "Lightning"});
            this.lbSkills.Location = new System.Drawing.Point(150, 46);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(73, 67);
            this.lbSkills.TabIndex = 12;
            this.lbSkills.Visible = false;
            this.lbSkills.SelectedIndexChanged += new System.EventHandler(this.lbSkills_SelectedIndexChanged);
            // 
            // pbEnemyA
            // 
            this.pbEnemyA.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemyA.Image = global::VideoGame.Properties.Resources.dbzw90t_c2f2ed32_f000_4098_91f6_15a8c8e244b1_removebg_preview;
            this.pbEnemyA.Location = new System.Drawing.Point(421, 225);
            this.pbEnemyA.Name = "pbEnemyA";
            this.pbEnemyA.Size = new System.Drawing.Size(104, 79);
            this.pbEnemyA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyA.TabIndex = 7;
            this.pbEnemyA.TabStop = false;
            this.pbEnemyA.Click += new System.EventHandler(this.pbEnemyA_Click);
            // 
            // pbEnemyB
            // 
            this.pbEnemyB.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemyB.Image = global::VideoGame.Properties.Resources.dbzw90t_c2f2ed32_f000_4098_91f6_15a8c8e244b1_removebg_preview;
            this.pbEnemyB.Location = new System.Drawing.Point(531, 204);
            this.pbEnemyB.Name = "pbEnemyB";
            this.pbEnemyB.Size = new System.Drawing.Size(104, 79);
            this.pbEnemyB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyB.TabIndex = 14;
            this.pbEnemyB.TabStop = false;
            this.pbEnemyB.Click += new System.EventHandler(this.pbEnemyB_Click);
            // 
            // pbEnemyC
            // 
            this.pbEnemyC.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemyC.Image = global::VideoGame.Properties.Resources.dbzw90t_c2f2ed32_f000_4098_91f6_15a8c8e244b1_removebg_preview;
            this.pbEnemyC.Location = new System.Drawing.Point(641, 245);
            this.pbEnemyC.Name = "pbEnemyC";
            this.pbEnemyC.Size = new System.Drawing.Size(104, 79);
            this.pbEnemyC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyC.TabIndex = 15;
            this.pbEnemyC.TabStop = false;
            this.pbEnemyC.Click += new System.EventHandler(this.pbEnemyC_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::VideoGame.Properties.Resources.Screenshot_2024_11_18_125543_removebg_preview1;
            this.pbPlayer.Location = new System.Drawing.Point(127, 142);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(154, 162);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 6;
            this.pbPlayer.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pBattle;
        private System.Windows.Forms.Button bAttack;
        private System.Windows.Forms.Label lPlayerHp;
        private System.Windows.Forms.Label lEnemyAHp;
        private System.Windows.Forms.PictureBox pbEnemyA;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Panel pBattleActions;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bSkills;
        private System.Windows.Forms.ListBox lbSkills;
        private System.Windows.Forms.Panel pEndBattle;
        private System.Windows.Forms.Label oldFeedback;
        private System.Windows.Forms.Label newFeedback;
        private System.Windows.Forms.Button bShop;
        private System.Windows.Forms.PictureBox pbEnemyC;
        private System.Windows.Forms.PictureBox pbEnemyB;
        private System.Windows.Forms.Label lEnemyCHp;
        private System.Windows.Forms.Label lEnemyBHp;
        private System.Windows.Forms.Label lTarget;
    }
}

