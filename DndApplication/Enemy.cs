using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndApplication
{
    public class Enemy
    {
        public string TargetedPlayer { get; set; }
        public int DamageDoneToTarget { get; set; }
        public string DamageDoneToEveryone
        {
            get
            {
                return $"Name:{TargetedPlayer}, Damage Received: {DamageDoneToTarget}";
            }
        }
    }
}
