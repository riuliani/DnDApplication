using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndApplication
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int DamageDoneToTarget { get; set; }
        public string  TargetedPlayer { get; set; }
        public int HealingDoneToTarget { get; set; }

        public string HealingDoneToFriendly
        {
            get
            {
                return $"Name: {TargetedPlayer}, Healing Received: {HealingDoneToTarget}";
            }
        }

        public string DamageDone
        {
            get
            {
                return $"Name: {PlayerName}  Damage Done: {DamageDoneToTarget}";
            }
        }
    }
}
