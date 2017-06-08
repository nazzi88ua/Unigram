// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessagesChats : TLMessagesChatsBase 
	{
		public TLMessagesChats() { }
		public TLMessagesChats(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesChats; } }

		public override void Read(TLBinaryReader from)
		{
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Chats);
		}
	}
}