﻿namespace iproto.Data.Packets
{
    public class GreetingsPacket
    {
        public GreetingsPacket(string message, byte[] salt)
        {
            Message = message;
            Salt = salt;
        }

        public string Message { get; }

        public byte[] Salt { get; }
    }
}