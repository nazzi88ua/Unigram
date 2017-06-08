// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.forwardMessage.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesForwardMessage : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public Int32 Id { get; set; }
		public Int64 RandomId { get; set; }

		public TLMessagesForwardMessage() { }
		public TLMessagesForwardMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesForwardMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = from.ReadInt32();
			RandomId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteInt32(Id);
			to.WriteInt64(RandomId);
		}
	}
}