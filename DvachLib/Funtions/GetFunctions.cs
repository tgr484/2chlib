using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DvachLib.Funtions
{
    public class GetFunctions
    {
        public static Board GetBoardByName(string boardName)
        {
            return Helpers.RequestHelper.MakeRequest<Board>($@"http://2ch.hk/{boardName}/threads.json");         
        }

        public static ThreadInfo GetThreadByBoardNameAndId(string boardName, int threadId)
        {
            return Helpers.RequestHelper.MakeRequest<ThreadInfo>($@"http://2ch.hk/{boardName}/res/{threadId}.json");
        }
    }
}
