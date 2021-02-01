using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndApplication
{    
    public class Combat
    {
        public int EncounterRound { get; set; }
        public string PlayerName { get; set; }
        public int PlayerHealth { get; set; }
        public string ActionTaken { get; set; }
        public string TargetedPlayer { get; set; }
        public int TargetedPlayerHealth { get; set; }
        public int DamageDoneToTarget { get; set; }
        public int HealingDoneToTarget { get; set; }

        public void initiateCombat()
        {
            CalculateDamage();
            CalculateHealing();
        }
        public void ConvertAndSetProperties(string encounterRound, string playerName, string playerHealth, string actionTaken, string targetedPlayer, 
            string targetedPlayerHealth, string damageDoneToTarget, string healingDoneToTarget)
        {
            EncounterRound = Convert.ToInt32(encounterRound);
            PlayerName = playerName;
            PlayerHealth = Convert.ToInt32(playerHealth);
            ActionTaken = actionTaken;
            TargetedPlayer = targetedPlayer;
            TargetedPlayerHealth = Convert.ToInt32(targetedPlayerHealth);
            DamageDoneToTarget = Convert.ToInt32(damageDoneToTarget);
            HealingDoneToTarget = Convert.ToInt32(healingDoneToTarget);
        }
        public void CalculateDamage()
        {
            TargetedPlayerHealth = TargetedPlayerHealth - DamageDoneToTarget;
        }
        public void CalculateHealing()
        {
            TargetedPlayerHealth = TargetedPlayerHealth + HealingDoneToTarget;
        }
        public string UpdateHealthAfterDamage()
        {
            string newHealth = Convert.ToString(TargetedPlayerHealth);
            return newHealth;
        }
        public string UpdateHealthAfterHealing()
        {
            string newHealth = Convert.ToString(TargetedPlayerHealth);
            return newHealth;
        }
    }
}
