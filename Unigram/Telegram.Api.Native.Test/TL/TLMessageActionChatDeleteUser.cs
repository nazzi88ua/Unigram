// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChatDeleteUser : TLMessageActionBase 
	{
		public Int32 UserId { get; set; }

		public TLMessageActionChatDeleteUser() { }
		public TLMessageActionChatDeleteUser(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChatDeleteUser; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(UserId);
		}
	}
}