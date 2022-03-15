﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Serilog;
using Serilog.Core;
using System.Linq;

namespace WebZen.Network
{
    public class PacketEncrypt
    {
        private static readonly ILogger Logger = Log.ForContext(Constants.SourceContextPropertyName, nameof(WZServer));

        public static void Encrypt(MemoryStream dest, MemoryStream src, WZClient client)
        {
            var destPos = dest.Position;
            var dataLen = (src.Length - src.Position);
            var r = (byte)(dataLen % 16);
            byte paddingSize = 0;
            if(r != 0)
            {
                paddingSize = (byte)(16 - r);
            }

            var tmp = new byte[dataLen + paddingSize];
            src.Read(tmp, 0, (int)dataLen);

            dest.Seek(destPos, SeekOrigin.Begin);
            var cs = new CryptoStream(dest, client.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(tmp, 0, tmp.Length);
            dest.WriteByte(paddingSize);
            dest.Seek(0, SeekOrigin.Begin);
        }

        public static byte[] Decrypt(byte[] src, WZClient client)
        {
            byte[] ret = Array.Empty<byte>();
            var bsize = client.BlockSize / 8;

            if (src.Length % bsize == 1)
            {
                var paddingSize = src[src.Length - 1];
                var outLength = src.Length - paddingSize - 1;

                using (var ms = new MemoryStream(src, 0, src.Length - 1))
                {
                    var cs = new CryptoStream(ms, client.CreateDecryptor(), CryptoStreamMode.Read);
                    using (var br = new BinaryReader(cs))
                    {
                        ret = br.ReadBytes(outLength);
                    }
                }

                //Logger.Debug("Input Buffer {0}, Output Buffer {1}", string.Join("",src.Select(x => x.ToString("X2"))), string.Join("", ret.Select(x => x.ToString("X2"))));
            }else
            {
                Logger.Error("Can't decode stream, data size:{1} remainder:{0}", src.Length % bsize, src.Length);
            }

            return ret;
        }
    }
}
