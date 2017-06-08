// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getGameHighScores.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesHighScores"/>
	/// </summary>
	public partial class TLMessagesGetGameHighScores : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public Int32 Id { get; set; }
		public TLInputUserBase UserId { get; set; }

		public TLMessagesGetGameHighScores() { }
		public TLMessagesGetGameHighScores(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetGameHighScores; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = from.ReadInt32();
			UserId = TLFactory.Read<TLInputUserBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteInt32(Id);
			to.WriteObject(UserId);
		}
	}
}