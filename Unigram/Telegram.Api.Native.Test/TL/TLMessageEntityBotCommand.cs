// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageEntityBotCommand : TLMessageEntityBase 
	{
		public TLMessageEntityBotCommand() { }
		public TLMessageEntityBotCommand(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageEntityBotCommand; } }

		public override void Read(TLBinaryReader from)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Offset);
			to.WriteInt32(Length);
		}
	}
}