// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPhoneCallDiscardReasonBusy : TLPhoneCallDiscardReasonBase 
	{
		public TLPhoneCallDiscardReasonBusy() { }
		public TLPhoneCallDiscardReasonBusy(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhoneCallDiscardReasonBusy; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xFAF7E8C9);
		}
	}
}