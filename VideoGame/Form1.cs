using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
        Battle battle = new Battle();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAttack_Click(object sender, EventArgs e)
        {

            battle.castSkill(player, enemy, "Basic");
            endTurn();

            if (battle.getInProgress() == true)
            {
                battle.enemyTurn(enemy, player);
                endTurn();
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
            battle.castSkill(player, enemy, lbSkills.GetItemText(lbSkills.Items[lbSkills.SelectedIndex]));
            endTurn();
            lbSkills.Visible = false;

            if (battle.getInProgress() == true)
            {
                battle.enemyTurn(enemy, player);
                endTurn();
            }
        }

        private void endTurn()
        {
            updatelPlayerHp();
            updatelEnemyHp();

            if (player.getHp() <= 0 || enemy.getHp() <= 0)
            {
                battle.setInProgress(false);
                pBattleActions.Visible = false;
                pEndBattle.Visible = true;
            }
        }
        
        private void updatelPlayerHp()
        {
            lPlayerHp.Text = player.getHp() + " / " + player.getMaxHp();
        }

        private void updatelEnemyHp()
        {
            lEnemyHp.Text = enemy.getHp() + " / " + enemy.getMaxHp();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            pBattle.Visible = false;
        }
    }
}
