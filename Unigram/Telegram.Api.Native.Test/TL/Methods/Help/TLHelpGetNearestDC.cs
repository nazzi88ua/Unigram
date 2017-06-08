// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getNearestDc.
	/// Returns <see cref="Telegram.Api.TL.TLNearestDC"/>
	/// </summary>
	public partial class TLHelpGetNearestDC : TLObject
	{
		public TLHelpGetNearestDC() { }
		public TLHelpGetNearestDC(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpGetNearestDC; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x1FB33026);
		}
	}
}