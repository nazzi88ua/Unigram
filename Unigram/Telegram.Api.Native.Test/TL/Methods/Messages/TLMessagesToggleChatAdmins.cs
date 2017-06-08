// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.toggleChatAdmins.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesToggleChatAdmins : TLObject
	{
		public Int32 ChatId { get; set; }
		public Boolean Enabled { get; set; }

		public TLMessagesToggleChatAdmins() { }
		public TLMessagesToggleChatAdmins(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesToggleChatAdmins; } }

		public override void Read(TLBinaryReader from)
		{
			ChatId = from.ReadInt32();
			Enabled = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(ChatId);
			to.WriteBoolean(Enabled);
		}
	}
}