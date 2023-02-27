using StardewModdingAPI;
using StardewValley;
using StardewValley.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace One_Hit_KO_Mod
{
    public  class Playerdead
    {
        private static void takeDamage_Postfix()
        {
            try
            { 
                takeDamage(int damage, bool overrideParry,"die", Monster damager)
            }
                catch (Exception ex)
                {
                  
                }
            
        }
    }
}
