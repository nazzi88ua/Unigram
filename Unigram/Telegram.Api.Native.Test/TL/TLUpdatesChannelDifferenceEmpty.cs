// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesChannelDifferenceEmpty : TLUpdatesChannelDifferenceBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Final = (1 << 0),
			Timeout = (1 << 1),
		}

		public override bool IsFinal { get { return Flags.HasFlag(Flag.Final); } set { Flags = value ? (Flags | Flag.Final) : (Flags & ~Flag.Final); } }
		public bool HasTimeout { get { return Flags.HasFlag(Flag.Timeout); } set { Flags = value ? (Flags | Flag.Timeout) : (Flags & ~Flag.Timeout); } }

		public Flag Flags { get; set; }

		public TLUpdatesChannelDifferenceEmpty() { }
		public TLUpdatesChannelDifferenceEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdatesChannelDifferenceEmpty; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Pts = from.ReadInt32();
			if (HasTimeout) Timeout = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt32(Pts);
			if (HasTimeout) to.WriteInt32(Timeout.Value);
		}

		private void UpdateFlags()
		{
			HasTimeout = Timeout != null;
		}
	}
}