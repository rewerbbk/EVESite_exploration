using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PlayerSkill
    {
        String Name { get; set; }
        int Level { get { return GetLevel(); } }
        int[] LevelBreaks { get; set; }
        int Experience { get; set; }
        bool RequirementsMet { get; }
        Tuple<PlayerSkill, int>[] Dependencies { get; set; }
        Tuple<PlayerSkill, int>[] RequiredFor { get; set; }

        //TODO push this to data or db layer
        private int GetLevel()
        {
            for(int i = 0; i < LevelBreaks.Count(); i ++)
            {
                if (Experience > LevelBreaks[i])
                    return i + 1;
            }
            return 0;
        }
    }
}
