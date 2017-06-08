// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getWallPapers.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLWallPaper>"/>
	/// </summary>
	public partial class TLAccountGetWallPapers : TLObject
	{
		public TLAccountGetWallPapers() { }
		public TLAccountGetWallPapers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountGetWallPapers; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xC04CFAC2);
		}
	}
}