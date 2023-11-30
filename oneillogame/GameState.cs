using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneillogame
{
    public class GameBoardState
    {
        public List<List<int>> BoardArray { get; set; }
        public int CurrentPlayer { get; set; }
        public int WhiteTokenCount { get; set; }
        public int BlackTokenCount { get; set; }
    }
}
