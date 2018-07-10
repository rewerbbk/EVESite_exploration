using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CallEveApi
    {
        IPlayerSkills playerSkills;
        public CallEveApi(IPlayerSkills playerSkills)
        {
            this.playerSkills = playerSkills;
        }
        public void GetPlayerSkills(Guid apiKey)
        {
            //Get
            int skills = GetAPI(apiKey);

            //set
            playerSkills.InsertUpdate(apiKey, skills);
        }

        private int GetAPI(Guid apiKey)
        {
            return 0;
        }
    }
}
