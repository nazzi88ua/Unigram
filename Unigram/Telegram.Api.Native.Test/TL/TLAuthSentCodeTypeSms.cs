// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLAuthSentCodeTypeSms : TLAuthSentCodeTypeBase 
	{
		public Int32 Length { get; set; }

		public TLAuthSentCodeTypeSms() { }
		public TLAuthSentCodeTypeSms(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeSms; } }

		public override void Read(TLBinaryReader from)
		{
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Length);
		}
	}
}