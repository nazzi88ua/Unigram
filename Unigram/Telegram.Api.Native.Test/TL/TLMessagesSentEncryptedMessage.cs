// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessagesSentEncryptedMessage : TLMessagesSentEncryptedMessageBase 
	{
		public TLMessagesSentEncryptedMessage() { }
		public TLMessagesSentEncryptedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSentEncryptedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Date);
		}
	}
}