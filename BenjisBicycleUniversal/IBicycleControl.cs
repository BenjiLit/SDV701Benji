using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenjisBicycleUniversal
{
    interface IBicycleControl
    {
        void PushData(clsBicycle prBicycle);

        void UpdateControl(clsBicycle prBicycle);
    }
}
