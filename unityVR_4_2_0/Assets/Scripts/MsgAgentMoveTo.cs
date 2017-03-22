using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace SimpleNetwork
{
    [Serializable, ProtoContract]
    public class MsgAgentMoveTo
    {
        [ProtoMember(1, IsRequired = true)]
        public Int32 actionID;

        [ProtoMember(2, IsRequired = true)]
        public float x;

        [ProtoMember(3, IsRequired = true)]
        public float y;

        [ProtoMember(4, IsRequired = true)]
        public float z;
    }
}
