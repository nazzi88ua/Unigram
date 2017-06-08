// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.setBotUpdatesStatus.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLHelpSetBotUpdatesStatus : TLObject
	{
		public Int32 PendingUpdatesCount { get; set; }
		public String Message { get; set; }

		public TLHelpSetBotUpdatesStatus() { }
		public TLHelpSetBotUpdatesStatus(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpSetBotUpdatesStatus; } }

		public override void Read(TLBinaryReader from)
		{
			PendingUpdatesCount = from.ReadInt32();
			Message = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(PendingUpdatesCount);
			to.WriteString(Message ?? string.Empty);
		}
	}
}