using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JS.APIChatRoom.ViewModels
{
    public class ChatViewModel
    {
        public List<int> Data { get; set; }
        public string Label { get; set; }

        public ChatViewModel()
        {
            Data = new List<int>();
        }
    }
}
