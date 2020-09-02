using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelTrivia
{
    public class DataItem
    {
        private int id;
        private string content, topic;

        public DataItem(int id, string topic, string content)
        {
            this.id = id;
            this.content = content;
            this.topic = topic;
        }

        public int Id
        {
            get => id;
        }
        public string Content
        {
            get => content;
        }
        public string Topic
        {
            get => topic;
        }
    }
}
