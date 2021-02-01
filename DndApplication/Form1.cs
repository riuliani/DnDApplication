using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void playerNameTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerNameTxt.Text == "Larie")
            {
                playerHealthTxt.Text = lariesHealthTxt.Text;
            }
            else if (playerNameTxt.Text == "Baubles")
            {
                playerHealthTxt.Text = baublesHealthTxt.Text;
            }
            else if (playerNameTxt.Text == "Drayden")
            {
                playerHealthTxt.Text = draydensHealthTxt.Text;
            }
            else if (playerNameTxt.Text == "Phao")
            {
                playerHealthTxt.Text = phaosHealthTxt.Text;
            }
            else if (playerNameTxt.Text == "Rage-ar")
            {
                playerHealthTxt.Text = ragearsHelathTxt.Text;
            }
            else if(playerNameTxt.Text == "Luna")
            {
                playerHealthTxt.Text = lunasHealthTxt.Text;
            }
            else
            {
                playerHealthTxt.Text = "0";
            }
        }

        private void targetedPlayerTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (targetedPlayerTxt.Text == "Larie")
            {
                targetedPlayerHealthTxt.Text = lariesHealthTxt.Text;
            }
            else if(targetedPlayerTxt.Text == "Baubles")
            {
                targetedPlayerHealthTxt.Text = baublesHealthTxt.Text;
            }
            else if (targetedPlayerTxt.Text == "Drayden")
            {
                targetedPlayerHealthTxt.Text = draydensHealthTxt.Text;
            }
            else if (targetedPlayerTxt.Text == "Phao")
            {
                targetedPlayerHealthTxt.Text = phaosHealthTxt.Text;
            }
            else if (targetedPlayerTxt.Text == "Rage-ar")
            {
                targetedPlayerHealthTxt.Text = ragearsHelathTxt.Text;
            }
            else
            {
                targetedPlayerHealthTxt.Text = "0";
            }
        }

        List<Enemy> enemies = new List<Enemy>();
        List<Player> healing= new List<Player>();
        List<Player> damage= new List<Player>();

        private void calculateAndInset_Click(object sender, EventArgs e)
        {          
                Combat combat = new Combat();

            combat.ConvertAndSetProperties(encounterRoundTxt.Text, playerNameTxt.Text, playerHealthTxt.Text, actionTakenTxt.Text,
                targetedPlayerTxt.Text, targetedPlayerHealthTxt.Text, damageDoneToTargetTxt.Text, healingDoneToTargetTxt.Text);            

            List<string> names = new List<string>();
            names.Add("Larie");
            names.Add("Baubles");
            names.Add("Phao");
            names.Add("Rage-ar");
            names.Add("Drayden");
            names.Add("Luna");

            if (names.Contains(playerNameTxt.Text) && names.Contains(targetedPlayerTxt.Text) && actionTakenTxt.Text == "Attack")
            {
                errorBox.Text = "You can not attack a friendly player!";
            }
            else
            {
                combat.initiateCombat();

                if (targetedPlayerTxt.Text == "Larie")
                {
                    lariesHealthTxt.Text = combat.UpdateHealthAfterDamage();
                    lariesHealthTxt.Text = combat.UpdateHealthAfterHealing();
                }
                else if (targetedPlayerTxt.Text == "Baubles")
                {
                    baublesHealthTxt.Text = combat.UpdateHealthAfterDamage();
                    baublesHealthTxt.Text = combat.UpdateHealthAfterHealing();
                }
                else if (targetedPlayerTxt.Text == "Phao")
                {
                    phaosHealthTxt.Text = combat.UpdateHealthAfterDamage();
                    phaosHealthTxt.Text = combat.UpdateHealthAfterHealing();
                }
                else if (targetedPlayerTxt.Text == "Drayden")
                {
                    draydensHealthTxt.Text = combat.UpdateHealthAfterDamage();
                    draydensHealthTxt.Text = combat.UpdateHealthAfterHealing();
                }
                else if (targetedPlayerTxt.Text == "Rage-ar")
                {
                    ragearsHelathTxt.Text = combat.UpdateHealthAfterDamage();
                    ragearsHelathTxt.Text = combat.UpdateHealthAfterHealing();
                }
                else if(targetedPlayerTxt.Text == "Luna")
                {
                    lunasHealthTxt.Text = combat.UpdateHealthAfterDamage();
                    lunasHealthTxt.Text = combat.UpdateHealthAfterHealing();
                }
                else
                {
                    dmgDoneToEveryoneTxt.Text = targetedPlayerTxt.Text;
                }

                DataAccess.InsertToDatabase(combat);               
            }

            enemies = DataAccess.GetEnemiesDamage();
            healing = DataAccess.GetFriendlyHealing();
            damage = DataAccess.GetDamageDoneByCharacter();

            UpdateBinding();
        }

        private void clearCombatColumn_Click(object sender, EventArgs e)
        {
            encounterRoundTxt.Text = "";
            playerNameTxt.Text = "";
            playerHealthTxt.Text = "";
            actionTakenTxt.Text = "";
            targetedPlayerTxt.Text = "";
            targetedPlayerHealthTxt.Text = "";
            damageDoneToTargetTxt.Text = "";
            healingDoneToTargetTxt.Text = "";
        }

        private void longRestButton_Click(object sender, EventArgs e)
        {
            lariesHealthTxt.Text = "64";
            ragearsHelathTxt.Text = "127";
            baublesHealthTxt.Text = "73";
            phaosHealthTxt.Text = "78";
            draydensHealthTxt.Text = "78";
            lunasHealthTxt.Text = "36";
        }

        private void UpdateBinding()
        {
            dmgDoneToEveryoneTxt.DataSource = enemies;
            dmgDoneToEveryoneTxt.DisplayMember = "DamageDoneToEveryone";

            healingDoneToFriendlyTxt.DataSource = healing;
            healingDoneToFriendlyTxt.DisplayMember = "HealingDoneToFriendly";

            dmgDoneByPartyMembersTxt.DataSource = damage;
            dmgDoneByPartyMembersTxt.DisplayMember = "DamageDone";
        }
        
        //Update Dashobard Button
        private void updateDashoBoard_Click(object sender, EventArgs e)
        {           

            enemies = DataAccess.GetEnemiesDamage();
            healing = DataAccess.GetFriendlyHealing();
            damage = DataAccess.GetDamageDoneByCharacter();

            UpdateBinding();
        }

        //Labels

        private void roundLabel_Click(object sender, EventArgs e)
        {

        }

        private void playerHealthLabel_Click(object sender, EventArgs e)
        {

        }

        private void actionTakenLabel_Click(object sender, EventArgs e)
        {

        }

        private void targetedPlayerLabel_Click(object sender, EventArgs e)
        {

        }

        private void targetedPlayerHealthLabel_Click(object sender, EventArgs e)
        {

        }

        private void playerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void damageDoneToTargetLabel_Click(object sender, EventArgs e)
        {

        }

        private void healingDoneToTargetLabel_Click(object sender, EventArgs e)
        {

        }

        private void lariesHpLabel_Click(object sender, EventArgs e)
        {

        }

        private void ragearsHpLabel_Click(object sender, EventArgs e)
        {

        }

        private void baublesHpLabel_Click(object sender, EventArgs e)
        {

        }

        private void phaosHpLabel_Click(object sender, EventArgs e)
        {

        }

        private void draydenHpLabel_Click(object sender, EventArgs e)
        {

        }        
    }
}
