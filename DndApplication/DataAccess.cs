using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndApplication
{
    static class DataAccess
    {
        
        static internal void InsertToDatabase(Combat combat)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DnD")))
            {
                List<Combat> combats = new List<Combat>();

                combats.Add(combat);

                connection.Execute("dbo.Combat_Insert @EncounterRound, @PlayerName, @PlayerHealth, " +
                   "@ActionTaken, @TargetedPlayer, @TargetedPlayerHealth, @DamageDoneToTarget, @HealingDoneToTarget", combats);
            }
        }

        static public List<Enemy> GetEnemiesDamage()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DnD")))
            {
                var output = connection.Query<Enemy>($"dbo.Combat_GetDamageDoneToEnemy").ToList();
                return output;
            }
        }

        static public List<Player> GetFriendlyHealing()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DnD")))
            {
                var output = connection.Query<Player>($"dbo.Combat_GetHealingDone").ToList();
                return output;
            }
        }

        static public List<Player> GetDamageDoneByCharacter()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DnD")))
            {
                var output = connection.Query<Player>($"dbo.Combat_GetDamageDoneByPlayer").ToList();
                return output;
            }
        }
    }
}
