// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getPassword.
	/// Returns <see cref="Telegram.Api.TL.TLAccountPasswordBase"/>
	/// </summary>
	public partial class TLAccountGetPassword : TLObject
	{
		public TLAccountGetPassword() { }
		public TLAccountGetPassword(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountGetPassword; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x548A30F5);
		}
	}
}