// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getArchivedStickers.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesArchivedStickers"/>
	/// </summary>
	public partial class TLMessagesGetArchivedStickers : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Masks = (1 << 0),
		}

		public bool IsMasks { get { return Flags.HasFlag(Flag.Masks); } set { Flags = value ? (Flags | Flag.Masks) : (Flags & ~Flag.Masks); } }

		public Flag Flags { get; set; }
		public Int64 OffsetId { get; set; }
		public Int32 Limit { get; set; }

		public TLMessagesGetArchivedStickers() { }
		public TLMessagesGetArchivedStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetArchivedStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			OffsetId = from.ReadInt64();
			Limit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteInt64(OffsetId);
			to.WriteInt32(Limit);
		}
	}
}