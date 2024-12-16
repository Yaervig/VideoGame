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
using static System.Net.Mime.MediaTypeNames;
namespace VideoGame
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        Enemy[] enemy = new Enemy[]
        {
            new Enemy(""),
            new Enemy(""),
            new Enemy("")
        };
        PictureBox[] pbEnemies = new PictureBox[3];
        Label[] lEnemiesHp = new Label[3];
        Panel[] pMapButtons = new Panel[8];
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

            pMapButtons[0] = pLevel1;
            pMapButtons[1] = pLevel2;
            pMapButtons[2] = pLevel3;
            pMapButtons[3] = pLevel4;
            pMapButtons[4] = pLevel5;
            pMapButtons[5] = pLevel6;
            pMapButtons[6] = pLevel7;
            pMapButtons[7] = pLevel8;

            updatelPlayerStats();
        }

        private void bAttack_Click(object sender, EventArgs e)
        {
            int i = player.getTargetIndex();

            if (i != -1 && enemy[i].getHp() > 0)
            {
                battle.castSkill(player, enemy[i], "Basic");
                if (player.getMana() < player.getMaxMana())
                {
                    player.setMana(player.getMana() + 1);
                    updatelPlayerMana();
                }
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

            if (i != -1 && enemy[i].getHp() > 0 && player.getMana() > 0)
            {
                if (lbSkills.GetItemText(lbSkills.Items[lbSkills.SelectedIndex]) == "Lightning")
                {
                    for (int j = 0; j < 3; j++)
                        if (enemy[j].getHp() > 0)
                            battle.castSkill(player, enemy[j], lbSkills.GetItemText(lbSkills.Items[lbSkills.SelectedIndex]));
                }
                else
                {
                    battle.castSkill(player, enemy[i], lbSkills.GetItemText(lbSkills.Items[lbSkills.SelectedIndex]));
                }
                player.setMana(player.getMana() - 1);
                updatelPlayerMana();
                endTurn();
                lbSkills.Visible = false;
                enemyTurn();
            }
        }

        private void endTurn()
        {
            int i = player.getTargetIndex();

            updatelPlayerStats();
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
                updatelEndBattle();
                pEndBattle.Visible = true;
            }
        }

        private void enemyTurn()
        {
            for (int i = 0; i < 3; i++)
            {
                if (battle.getInProgress() == true && enemy[i].getHp() > 0)
                {
                    battle.enemyTurn(enemy[i], player);
                    endTurn();
                }
            }
        }
        
        private void updatelPlayerHp()
        {
            lPlayerHp.Text = player.getHp() + " / " + player.getMaxHp();
        }

        private void updatelPlayerMana()
        {
            lPlayerMana.Text = player.getMana() + " / " + player.getMaxMana();
        }

        private void updatelEnemyHp()
        {
            for (int i = 0; i < 3; i++)
            {
                lEnemiesHp[i].Text = enemy[i].getHp() + " / " + enemy[i].getMaxHp();

                if (enemy[i].getHp() <= 0)
                {
                    pbEnemies[i].Visible = false;
                    lEnemiesHp[i].Visible = false;
                }
                else
                {
                    pbEnemies[i].Visible = true;
                    lEnemiesHp[i].Visible = true;
                }
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

        private void updateMap()
        {
            for (int i = 0; i < 8; i++)
            {
                if (i == player.getLevel() % 8)
                    pMapButtons[i].Visible = true;
                else
                    pMapButtons[i].Visible = false;
            }
        }

        private void updatelPlayerStats()
        {
            if(pMap.Visible == true)
                lPlayerStats.Parent = pMap;

            else if (pBattle.Visible == true)
                lPlayerStats.Parent = pBattle;

            else if (pShop.Visible == true)
                lPlayerStats.Parent = pShop;

            lPlayerStats.Text = $"Health: {player.getHp()}/{player.getMaxHp()}\nStrength: {player.getStrength()}\nDefense {player.getDefense()}\nGold: {player.getGold()}";
        }

        private void updatelEndBattle()
        {
            int gold = 0;
            for (int i = 0; i < 3; i++)
            {
                gold += enemy[i].getValue();
            }

            player.setGold(player.getGold() + gold);

            if (player.getHp() > 0)
                lEndBattle.Text = "Victory!\n You earned " + gold + " gold.";
            else
                lEndBattle.Text = "Defeat.";
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (player.getHp() <= 0)
                Close();

            player.setLevel(player.getLevel() + 1);
            updateMap();

            pBattle.Visible = false;
            pMap.Visible = true;
            updatelPlayerStats();
        }

        private void pbEnemyA_Click(object sender, EventArgs e)
        {
            if (enemy[0].getHp() > 0)
            {
                player.setTargetIndex(0);
                updatelTarget();
            }
        }

        private void pbEnemyB_Click(object sender, EventArgs e)
        {
            if (enemy[1].getHp() > 0)
            {
                player.setTargetIndex(1);
                updatelTarget();
            }
        }

        private void pbEnemyC_Click(object sender, EventArgs e)
        {
            if (enemy[2].getHp() > 0)
            {
                player.setTargetIndex(2);
                updatelTarget();
            }
        }

        //Alex
        private void addSkill(string name, string verb, int mult, bool heals)
        {
            lbSkills.Items.Add(name);
            battle.addSkill(new Skill(name, verb, mult, heals));
        }
        //End Alex

        private void bFight_Click(object sender, EventArgs e)
        {
            newBattleEncounter();
            pMap.Visible = false;
            pBattle.Visible = true;
            updatelPlayerStats();
        }

        private void bRest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You approach a campfire, would you like to rest? If not, you may train instead.", "Campfire", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                player.setHp(player.getMaxHp());
                MessageBox.Show("You rest. Your health is restored.", "Campfire");
                updatelPlayerStats();
            }
            else if (result == DialogResult.No)
            {
                player.setStrength(player.getStrength() + 1);
                player.setDefense(player.getDefense() + 1);
                MessageBox.Show("You train. Your Strength and Defense were increased by 1.", "Campfire");
                updatelPlayerStats();
            }
            player.setLevel(player.getLevel() + 1);
            updateMap();
        }

        private void bShop_Click(object sender, EventArgs e)
        {
            pMap.Visible = false;
            pShop.Visible = true;
            updatelPlayerStats();
        }

        private void bShopExit_Click(object sender, EventArgs e)
        {
            player.setLevel(player.getLevel() + 1);
            updateMap();

            pShop.Visible = false;
            pMap.Visible = true;
            updatelPlayerStats();
        }

        private void bMystery_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int encounter = r.Next(0, 4);

            switch (encounter)
            {
                case 0:
                    MessageBox.Show("You find a red potion. Heal 20% of your health.", "???");
                    player.setHp(player.getHp() + (player.getMaxHp() / 5));
                    if (player.getHp() > player.getMaxHp())
                        player.setHp(player.getMaxHp());
                    break;
                case 1:
                    MessageBox.Show("You step in a bear trap. Lose 20% of your current health.", "???");
                    player.setHp(player.getHp() * 4 / 5);
                    if (player.getHp() <= 0)
                        player.setHp(1);
                    break;
                case 2:
                    MessageBox.Show("You find a blue potion. Gain 1 strength and defense.", "???");
                    player.setStrength(player.getStrength() + 1);
                    player.setDefense(player.getDefense() + 1);
                    break;
                case 3:
                    MessageBox.Show("You find a treasure chest. Gain 15 gold.", "???");
                    player.setGold(player.getGold() + 15);
                    break;
            }
            updatelPlayerStats();
            player.setLevel(player.getLevel() + 1);
            updateMap();
        }

        private void newBattleEncounter()
        {
            int enemyAmount = ((player.getLevel() % 8) + (player.getLevel() / 8 * 2)) / 5 + 1;
            int enemyType;
            Random r = new Random();

            if (enemyAmount > 3)
                enemyAmount = 3;

            if (player.getLevel() % 8 != 7)
            {
                for (int i = 0; i < 3; i++)
                {
                    enemyType = r.Next(0, 4);

                    if (i < enemyAmount)
                    {
                        switch (enemyType)
                        {
                            case 0:
                                enemy[i].initiateEnemy("Slime");
                                pbEnemies[i].Image = Properties.Resources.slime;
                                break;
                            case 1:
                                enemy[i].initiateEnemy("Goblin");
                                pbEnemies[i].Image = Properties.Resources.goblin;
                                break;
                            case 2:
                                enemy[i].initiateEnemy("Bat");
                                pbEnemies[i].Image = Properties.Resources.bat;
                                break;
                            case 3:
                                enemy[i].initiateEnemy("Skeleton");
                                pbEnemies[i].Image = Properties.Resources.skeleton;
                                break;
                        }
                    }
                    else
                        enemy[i].initiateEnemy("");
                }
            }
            else
            {
                enemy[0].initiateEnemy("");
                enemy[1].initiateEnemy("Hydra");
                pbEnemies[1].Image = Properties.Resources.hydra;
                enemy[2].initiateEnemy("");
            }

            updatelPlayerHp();
            updatelPlayerMana();
            updatelEnemyHp();
            battle.setInProgress(true);
            pBattleActions.Visible = true;
            pEndBattle.Visible = false;
        }




        //Shop Buttons
        private void bShop1_Click(object sender, EventArgs e)
        {
            int cost = 5;
            if (player.getGold() >= cost)
            {
                player.setStrength(player.getStrength() + 2);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop1.Visible = false;
                pbShop1.Visible = false;
            }
        }

        private void bShop2_Click(object sender, EventArgs e)
        {
            int cost = 10;
            if (player.getGold() >= cost)
            {
                player.setStrength(player.getStrength() + 3);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop2.Visible = false;
                pbShop2.Visible = false;
            }
        }

        private void bShop3_Click(object sender, EventArgs e)
        {
            int cost = 15;
            if (player.getGold() >= cost)
            {
                player.setStrength(player.getStrength() + 4);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop3.Visible = false;
                pbShop3.Visible = false;
            }
        }

        private void bShop4_Click(object sender, EventArgs e)
        {
            int cost = 20;
            if (player.getGold() >= cost)
            {
                player.setStrength(player.getStrength() + 5);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop4.Visible = false;
                pbShop4.Visible = false;
            }
        }

        private void bShop5_Click(object sender, EventArgs e)
        {
            int cost = 5;
            if (player.getGold() >= cost)
            {
                player.setHp(player.getHp() + 5);
                player.setMaxHp(player.getMaxHp() + 5);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop5.Visible = false;
                pbShop5.Visible = false;
            }
        }

        private void bShop6_Click(object sender, EventArgs e)
        {
            int cost = 10;
            if (player.getGold() >= cost)
            {
                player.setHp(player.getHp() + 10);
                player.setMaxHp(player.getMaxHp() + 10);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop6.Visible = false;
                pbShop6.Visible = false;
            }
        }

        private void bShop7_Click(object sender, EventArgs e)
        {
            int cost = 15;
            if (player.getGold() >= cost)
            {
                player.setHp(player.getHp() + 15);
                player.setMaxHp(player.getMaxHp() + 15);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop7.Visible = false;
                pbShop7.Visible = false;
            }
        }

        private void bShop8_Click(object sender, EventArgs e)
        {
            int cost = 20;
            if (player.getGold() >= cost)
            {
                player.setHp(player.getHp() + 20);
                player.setMaxHp(player.getMaxHp() + 20);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop8.Visible = false;
                pbShop8.Visible = false;
            }
        }

        private void bShop9_Click(object sender, EventArgs e)
        {
            int cost = 5;
            if (player.getGold() >= cost)
            {
                lbSkills.Items.Add("Fireball");
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop9.Visible = false;
                pbShop9.Visible = false;
            }
        }

        private void bShop10_Click(object sender, EventArgs e)
        {
            int cost = 10;
            if (player.getGold() >= cost)
            {
                lbSkills.Items.Add("Heal");
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop10.Visible = false;
                pbShop10.Visible = false;
            }
        }

        private void bShop11_Click(object sender, EventArgs e)
        {
            int cost = 15;
            if (player.getGold() >= cost)
            {
                lbSkills.Items.Add("Lightning");
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
                bShop11.Visible = false;
                pbShop11.Visible = false;
            }
        }

        private void bShop12_Click(object sender, EventArgs e)
        {
            int cost = 20;
            if (player.getGold() >= cost)
            {
                player.setStrength(player.getStrength() + 1);
                player.setDefense(player.getDefense() + 1);
                player.setHp(player.getHp() + 5);
                player.setMaxHp(player.getMaxHp() + 5);
                player.setGold(player.getGold() - cost);
                updatelPlayerStats();
            }
        }
        //End Shop Buttons
    }
}
