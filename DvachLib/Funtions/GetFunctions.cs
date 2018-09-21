using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DvachLib.Objects;

namespace DvachLib.Funtions
{
    public class GetFunctions
    {
        /// <summary>
        /// Получает списко тредов по борде
        /// </summary>
        /// <param name="boardName">Название борды, например b</param>
        /// <returns>Board</returns>
        public static Board GetBoardByName(string boardName)
        {
            return new Board(Helpers.RequestHelper.MakeRequest<BoardDto>($@"http://2ch.hk/{boardName}/threads.json"));         
        }

        public static Thread GetThreadByBoardNameAndId(string boardName, int threadId)
        {
            return new Thread(Helpers.RequestHelper.MakeRequest<ThreadDto>($@"http://2ch.hk/{boardName}/res/{threadId}.json"));
        }
    }
}
