// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.logOut.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAuthLogOut : TLObject
	{
		public TLAuthLogOut() { }
		public TLAuthLogOut(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthLogOut; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x5717DA40);
		}
	}
}