﻿namespace Dot42.DebuggerLib.Events.Jdwp
{
    /// <summary>
    /// Notification of a completed thread in the target VM. The notification is generated by the dying thread before it terminates. Because of this timing, 
    /// it is possible for {@link VirtualMachine#allThreads} to return this thread after this event is received.
    /// Note that this event gives no information about the lifetime of the thread object. It may or may not be collected soon depending on 
    /// what references exist in the target VM.  
    /// </summary>
    public sealed class ThreadDeath : BaseEvent
    {
        public ThreadDeath(JdwpPacket.DataReaderWriter reader)
            : base(reader)
        {
        }

        /// <summary>
        /// Accept a visit by the given visitor.
        /// </summary>
        public override TResult Accept<TResult, TData>(EventVisitor<TResult, TData> visitor, TData data)
        {
            return visitor.Visit(this, data);
        }
    }
}
