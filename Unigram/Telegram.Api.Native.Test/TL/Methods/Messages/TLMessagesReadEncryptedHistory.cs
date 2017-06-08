// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.readEncryptedHistory.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesReadEncryptedHistory : TLObject
	{
		public TLInputEncryptedChat Peer { get; set; }
		public Int32 MaxDate { get; set; }

		public TLMessagesReadEncryptedHistory() { }
		public TLMessagesReadEncryptedHistory(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesReadEncryptedHistory; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputEncryptedChat>(from);
			MaxDate = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteInt32(MaxDate);
		}
	}
}