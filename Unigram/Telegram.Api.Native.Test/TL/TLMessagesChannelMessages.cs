// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessagesChannelMessages : TLMessagesMessagesBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			None = 0
		}

		public Flag Flags { get; set; }
		public Int32 Pts { get; set; }
		public Int32 Count { get; set; }

		public TLMessagesChannelMessages() { }
		public TLMessagesChannelMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesChannelMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Pts = from.ReadInt32();
			Count = from.ReadInt32();
			Messages = TLFactory.Read<TLVector<TLMessageBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteInt32(Pts);
			to.WriteInt32(Count);
			to.WriteObject(Messages);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}
}