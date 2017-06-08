// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.reportPeer.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAccountReportPeer : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public TLReportReasonBase Reason { get; set; }

		public TLAccountReportPeer() { }
		public TLAccountReportPeer(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountReportPeer; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Reason = TLFactory.Read<TLReportReasonBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteObject(Reason);
		}
	}
}