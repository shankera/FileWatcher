using System;

namespace FileWatcher
{
    public class EventObject
    {
        public EventType Type { get; private set; }
        public EventObject(object sender, EventArgs e, EventType type)
        {
            Sender = sender;
            E = e;
            Type = type;
        }
        public object Sender { get; private set; }
        public EventArgs E { get; private set; }
    }
}
