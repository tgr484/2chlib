using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvachLib.Objects
{
    public class Thread
    {
        private ThreadDto _dto;
        internal Thread(ThreadDto dto)
        {
            _dto = dto;
        }
    }
}
