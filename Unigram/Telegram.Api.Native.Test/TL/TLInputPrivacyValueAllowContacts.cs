// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputPrivacyValueAllowContacts : TLInputPrivacyRuleBase 
	{
		public TLInputPrivacyValueAllowContacts() { }
		public TLInputPrivacyValueAllowContacts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPrivacyValueAllowContacts; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xD09E07B);
		}
	}
}