// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getPasswordSettings.
	/// Returns <see cref="Telegram.Api.TL.TLAccountPasswordSettings"/>
	/// </summary>
	public partial class TLAccountGetPasswordSettings : TLObject
	{
		public Byte[] CurrentPasswordHash { get; set; }

		public TLAccountGetPasswordSettings() { }
		public TLAccountGetPasswordSettings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountGetPasswordSettings; } }

		public override void Read(TLBinaryReader from)
		{
			CurrentPasswordHash = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteByteArray(CurrentPasswordHash);
		}
	}
}