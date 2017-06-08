// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessagesBotResults : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Gallery = (1 << 0),
			NextOffset = (1 << 1),
			SwitchPM = (1 << 2),
		}

		public bool IsGallery { get { return Flags.HasFlag(Flag.Gallery); } set { Flags = value ? (Flags | Flag.Gallery) : (Flags & ~Flag.Gallery); } }
		public bool HasNextOffset { get { return Flags.HasFlag(Flag.NextOffset); } set { Flags = value ? (Flags | Flag.NextOffset) : (Flags & ~Flag.NextOffset); } }
		public bool HasSwitchPM { get { return Flags.HasFlag(Flag.SwitchPM); } set { Flags = value ? (Flags | Flag.SwitchPM) : (Flags & ~Flag.SwitchPM); } }

		public Flag Flags { get; set; }
		public Int64 QueryId { get; set; }
		public String NextOffset { get; set; }
		public TLInlineBotSwitchPM SwitchPM { get; set; }
		public TLVector<TLBotInlineResultBase> Results { get; set; }
		public Int32 CacheTime { get; set; }

		public TLMessagesBotResults() { }
		public TLMessagesBotResults(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesBotResults; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			QueryId = from.ReadInt64();
			if (HasNextOffset) NextOffset = from.ReadString();
			if (HasSwitchPM) SwitchPM = TLFactory.Read<TLInlineBotSwitchPM>(from);
			Results = TLFactory.Read<TLVector<TLBotInlineResultBase>>(from);
			CacheTime = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt64(QueryId);
			if (HasNextOffset) to.WriteString(NextOffset ?? string.Empty);
			if (HasSwitchPM) to.WriteObject(SwitchPM);
			to.WriteObject(Results);
			to.WriteInt32(CacheTime);
		}

		private void UpdateFlags()
		{
			HasNextOffset = NextOffset != null;
			HasSwitchPM = SwitchPM != null;
		}
	}
}