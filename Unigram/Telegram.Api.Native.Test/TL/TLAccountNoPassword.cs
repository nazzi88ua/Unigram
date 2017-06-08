// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLAccountNoPassword : TLAccountPasswordBase 
	{
		public TLAccountNoPassword() { }
		public TLAccountNoPassword(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountNoPassword; } }

		public override void Read(TLBinaryReader from)
		{
			NewSalt = from.ReadByteArray();
			EmailUnconfirmedPattern = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteByteArray(NewSalt);
			to.WriteString(EmailUnconfirmedPattern ?? string.Empty);
		}
	}
}