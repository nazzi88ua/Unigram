// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessagesAllStickersNotModified : TLMessagesAllStickersBase 
	{
		public TLMessagesAllStickersNotModified() { }
		public TLMessagesAllStickersNotModified(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesAllStickersNotModified; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xE86602C3);
		}
	}
}