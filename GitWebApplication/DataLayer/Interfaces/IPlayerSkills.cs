using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IPlayerSkills
    {
        void Select(Guid apiKey);
        void InsertUpdate(Guid apiKey, int num);
        void Delete(Guid apiKey);
    }
}
