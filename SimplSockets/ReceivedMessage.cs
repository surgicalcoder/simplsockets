using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SimplSockets
{
    /// <summary>
    /// A received message.
    /// </summary>
    public class ReceivedMessage
    {
        public Socket Socket;
        public int ThreadId;
        public Guid Guid { get; set; }
        /// <summary>
        /// The message bytes.
        /// </summary>
        public byte[] Message;
    }
}
