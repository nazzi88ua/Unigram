// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLNotifyChats : TLNotifyPeerBase 
	{
		public TLNotifyChats() { }
		public TLNotifyChats(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.NotifyChats; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xC007CEC3);
		}
	}
}