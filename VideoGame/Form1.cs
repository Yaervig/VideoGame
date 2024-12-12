using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VideoGame
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        Enemy[] enemy = new Enemy[]
        {
            new Enemy("Slime"),
            new Enemy("Slime"),
            new Enemy("Slime")
        };
        PictureBox[] pbEnemies = new PictureBox[3];
        Label[] lEnemiesHp = new Label[3];
        Battle battle = new Battle();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbEnemies[0] = pbEnemyA;
            pbEnemies[1] = pbEnemyB;
            pbEnemies[2] = pbEnemyC;

            lEnemiesHp[0] = lEnemyAHp;
            lEnemiesHp[1] = lEnemyBHp;
            lEnemiesHp[2] = lEnemyCHp;
        }

        private void bAttack_Click(object sender, EventArgs e)
        {
            int i = player.getTargetIndex();

            if (i != -1 && enemy[i].getHp() > 0)
            {
                battle.castSkill(player, enemy[i], "Basic");
                endTurn();
                enemyTurn();
            }
        }

        private void bSkills_Click(object sender, EventArgs e)
        {
            if (lbSkills.Visible == false)
                lbSkills.Visible = true;
            else
                lbSkills.Visible = false;
        }

        private void lbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = player.getTargetIndex();

            if (i != -1 && enemy[i].getHp() > 0)
            {
                battle.castSkill(player, enemy[i], lbSkills.GetItemText(lbSkills.Items[lbSkills.SelectedIndex]));
                endTurn();
                lbSkills.Visible = false;
                enemyTurn();
            }
        }

        private void endTurn()
        {
            int i = player.getTargetIndex();

            updatelPlayerHp();
            updatelEnemyHp();
            updateFeedback();

            if (i != -1 && enemy[i].getHp() <= 0)
            {
                player.setTargetIndex(-1);
                updatelTarget();
            }

            if (player.getHp() <= 0 || (enemy[0].getHp() <= 0 && enemy[1].getHp() <= 0 && enemy[2].getHp() <= 0))
            {
                battle.setInProgress(false);
                pBattleActions.Visible = false;
                pEndBattle.Visible = true;
            }
        }

        private void enemyTurn()
        {
            for (int i = 0; i < 3; i++)
            {
                if (battle.getInProgress() == true && enemy[i].getHp() > 0)
                {
                    battle.enemyTurn(enemy[0], player);
                    endTurn();
                }
            }
        }
        
        private void updatelPlayerHp()
        {
            lPlayerHp.Text = player.getHp() + " / " + player.getMaxHp();
        }

        private void updatelEnemyHp()
        {
            for (int i = 0; i < 3; i++)
            {
                lEnemiesHp[i].Text = enemy[i].getHp() + " / " + enemy[i].getMaxHp();
            }
        }

        //Alex
        private void updateFeedback()
        {
            oldFeedback.Text = newFeedback.Text;
            newFeedback.Text = battle.getMsg();
        }
        //End Alex

        private void updatelTarget()
        {
            int i = player.getTargetIndex();

            if (i == -1)
                lTarget.Location = pbPlayer.Location;
            else if (i >= 0 && i <= 2)
                lTarget.Location = pbEnemies[i].Location;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            pBattle.Visible = false;
        }

        private void pbEnemyA_Click(object sender, EventArgs e)
        {
            player.setTargetIndex(0);
            updatelTarget();
        }

        private void pbEnemyB_Click(object sender, EventArgs e)
        {
            player.setTargetIndex(1);
            updatelTarget();
        }

        private void pbEnemyC_Click(object sender, EventArgs e)
        {
            player.setTargetIndex(2);
            updatelTarget();
        }

        //Alex
        private void addSkill(string name, string verb, int mult, bool heals)
        {
            lbSkills.Items.Add(name);
            battle.addSkill(new Skill(name, verb, mult, heals));
        }
        //End Alex

        private void bShop_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
