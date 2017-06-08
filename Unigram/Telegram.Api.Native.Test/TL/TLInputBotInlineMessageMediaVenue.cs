// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineMessageMediaVenue : TLInputBotInlineMessageBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ReplyMarkup = (1 << 2),
		}

		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }

		public Flag Flags { get; set; }
		public TLInputGeoPointBase GeoPoint { get; set; }
		public String Title { get; set; }
		public String Address { get; set; }
		public String Provider { get; set; }
		public String VenueId { get; set; }

		public TLInputBotInlineMessageMediaVenue() { }
		public TLInputBotInlineMessageMediaVenue(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageMediaVenue; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			GeoPoint = TLFactory.Read<TLInputGeoPointBase>(from);
			Title = from.ReadString();
			Address = from.ReadString();
			Provider = from.ReadString();
			VenueId = from.ReadString();
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteObject(GeoPoint);
			to.WriteString(Title ?? string.Empty);
			to.WriteString(Address ?? string.Empty);
			to.WriteString(Provider ?? string.Empty);
			to.WriteString(VenueId ?? string.Empty);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}

		private void UpdateFlags()
		{
			HasReplyMarkup = ReplyMarkup != null;
		}
	}
}