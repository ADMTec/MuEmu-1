﻿using System;
using System.Collections.Generic;
using System.Text;
using WebZen.Serialization;
using WebZen.Util;

namespace MuEmu.Network.ConnectServer
{
    [WZContract]
    public class CWelcome : ICSMessage
    { }

    [WZContract]
    public class CRegistryReq : ICSMessage
    {
        [WZMember(0)]
        public ushort Index { get; set; }

        [WZMember(1, 16)]
        public byte[] btAddress { get; set; }

        [WZMember(2)]
        public ushort Port { get; set; }

        [WZMember(3)]
        public byte Show { get; set; }

        [WZMember(4, 16)]
        public byte[] btToken { get; set; }

        [WZMember(5, 16)]
        public byte[] btName { get; set; }
        [WZMember(6)] public byte Type { get; internal set; }

        public string Address { get => btAddress.MakeString(); set => btAddress = value.GetBytes(); }
        public string Token { get => btToken.MakeString(); set => btToken = value.GetBytes(); }
        public string Name { get => btName.MakeString(); set => btName = value.GetBytes(); }
    }

    [WZContract]
    public class CKeepAlive : ICSMessage
    {
        [WZMember(0)]
        public ushort Index { get; set; }

        [WZMember(1)]
        public byte Load { get; set; }

        [WZMember(2, 16)]
        public byte[] btToken { get; set; }
        public string Token { get => btToken.MakeString(); set => btToken = value.GetBytes(); }
    }

    [WZContract]
    public class SCAdd : ICSMessage
    {
        [WZMember(0)]
        public byte Server { get; set; }

        [WZMember(1, 10)]
        public byte[] btName { get; set; }
    }

    [WZContract]
    public class SCServerList : ICSMessage
    {
    }
    
    [WZContract]
    public class ServerDto
    {
        [WZMember(0)]
        public ushort Index { get; set; }

        [WZMember(1)]
        public byte Load { get; set; }

        [WZMember(2)]
        public byte Type { get; set; }
    }

    [WZContract(LongMessage = true)]
    public class CSServerList : ICSMessage
    {
        [WZMember(0)]
        public byte CountH { get; set; }

        [WZMember(1)]
        public byte CountL { get; set; }

        [WZMember(2, SerializerType = typeof(ArraySerializer))]
        public ServerDto[] List { get; set; }

        public CSServerList()
        { }

        public CSServerList(ServerDto[] list)
        {
            CountH = (byte)(list.Length >> 8);
            CountL = (byte)(list.Length & 0xff);
            List = list;
        }
    }

    [WZContract]
    public class SCChat : ICSMessage
    {
        [WZMember(0)]
        public byte Server { get; set; }

        [WZMember(1, 10)]
        public byte[] btName { get; set; }

        [WZMember(2, 100)]
        public byte[] btChat { get; set; }
    }

    [WZContract]
    public class SCRem : ICSMessage
    {
        [WZMember(0)]
        public byte Server { get; set; }

        [WZMember(1, typeof(ArrayWithScalarSerializer<short>))]
        public CliRemDto[] List { get; set; }
    }

    [WZContract]
    public class CliRemDto : ICSMessage
    {
        [WZMember(0, 10)]
        public byte[] btName { get; set; }
    }
}
