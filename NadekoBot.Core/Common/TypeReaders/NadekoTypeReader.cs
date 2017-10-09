﻿using Discord.Commands;
using Discord.WebSocket;

namespace NadekoBot.Core.Common.TypeReaders
{
    public abstract class NadekoTypeReader : TypeReader
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandService _cmds;

        private NadekoTypeReader() { }
        public NadekoTypeReader(DiscordSocketClient client, CommandService cmds)
        {
            _client = client;
            _cmds = cmds;
        }
    }
}
