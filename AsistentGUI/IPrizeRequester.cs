using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel;

namespace AsistentGUI
{
    public interface IPrizeRequester
    {
        void PrizeComplete(NagradaModel model);
    }
}
