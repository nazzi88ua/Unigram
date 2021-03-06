// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.saveDraft.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesSaveDraft : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			NoWebPage = (1 << 1),
			ReplyToMsgId = (1 << 0),
			Entities = (1 << 3),
		}

		public bool IsNoWebPage { get { return Flags.HasFlag(Flag.NoWebPage); } set { Flags = value ? (Flags | Flag.NoWebPage) : (Flags & ~Flag.NoWebPage); } }
		public bool HasReplyToMsgId { get { return Flags.HasFlag(Flag.ReplyToMsgId); } set { Flags = value ? (Flags | Flag.ReplyToMsgId) : (Flags & ~Flag.ReplyToMsgId); } }
		public bool HasEntities { get { return Flags.HasFlag(Flag.Entities); } set { Flags = value ? (Flags | Flag.Entities) : (Flags & ~Flag.Entities); } }

		public Flag Flags { get; set; }
		public Int32? ReplyToMsgId { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public String Message { get; set; }
		public TLVector<TLMessageEntityBase> Entities { get; set; }

		public TLMessagesSaveDraft() { }
		public TLMessagesSaveDraft(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSaveDraft; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			if (HasReplyToMsgId) ReplyToMsgId = from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Message = from.ReadString();
			if (HasEntities) Entities = TLFactory.Read<TLVector<TLMessageEntityBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			if (HasReplyToMsgId) to.WriteInt32(ReplyToMsgId.Value);
			to.WriteObject(Peer);
			to.WriteString(Message ?? string.Empty);
			if (HasEntities) to.WriteObject(Entities);
		}

		private void UpdateFlags()
		{
			HasReplyToMsgId = ReplyToMsgId != null;
			HasEntities = Entities != null;
		}
	}
}