using JS.APIChatRoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JS.APIChatRoom.HubConfig
{
    public static class DataManager
    {
        public static List<ChatViewModel> GetData()
        {
            var r = new Random();
            return new List<ChatViewModel>
            {
                new ChatViewModel {Data = new List<int> {r.Next(1,40)}, Label = "Data1"},
                new ChatViewModel {Data = new List<int> {r.Next(1,40)}, Label = "Data2"},
                new ChatViewModel {Data = new List<int> {r.Next(1,40)}, Label = "Data3"},
                new ChatViewModel {Data = new List<int> {r.Next(1,40)}, Label = "Data4"},
            };
        }
    }
}
