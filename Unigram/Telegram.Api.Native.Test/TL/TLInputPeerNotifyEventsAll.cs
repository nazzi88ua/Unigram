// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputPeerNotifyEventsAll : TLInputPeerNotifyEventsBase 
	{
		public TLInputPeerNotifyEventsAll() { }
		public TLInputPeerNotifyEventsAll(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPeerNotifyEventsAll; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xE86A2C74);
		}
	}
}