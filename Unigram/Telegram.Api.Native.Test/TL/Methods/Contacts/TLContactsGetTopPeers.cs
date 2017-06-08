// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.getTopPeers.
	/// Returns <see cref="Telegram.Api.TL.TLContactsTopPeersBase"/>
	/// </summary>
	public partial class TLContactsGetTopPeers : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Correspondents = (1 << 0),
			BotsPm = (1 << 1),
			BotsInline = (1 << 2),
			Groups = (1 << 10),
			Channels = (1 << 15),
		}

		public bool IsCorrespondents { get { return Flags.HasFlag(Flag.Correspondents); } set { Flags = value ? (Flags | Flag.Correspondents) : (Flags & ~Flag.Correspondents); } }
		public bool IsBotsPm { get { return Flags.HasFlag(Flag.BotsPm); } set { Flags = value ? (Flags | Flag.BotsPm) : (Flags & ~Flag.BotsPm); } }
		public bool IsBotsInline { get { return Flags.HasFlag(Flag.BotsInline); } set { Flags = value ? (Flags | Flag.BotsInline) : (Flags & ~Flag.BotsInline); } }
		public bool IsGroups { get { return Flags.HasFlag(Flag.Groups); } set { Flags = value ? (Flags | Flag.Groups) : (Flags & ~Flag.Groups); } }
		public bool IsChannels { get { return Flags.HasFlag(Flag.Channels); } set { Flags = value ? (Flags | Flag.Channels) : (Flags & ~Flag.Channels); } }

		public Flag Flags { get; set; }
		public Int32 Offset { get; set; }
		public Int32 Limit { get; set; }
		public Int32 Hash { get; set; }

		public TLContactsGetTopPeers() { }
		public TLContactsGetTopPeers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsGetTopPeers; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Offset = from.ReadInt32();
			Limit = from.ReadInt32();
			Hash = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteInt32(Offset);
			to.WriteInt32(Limit);
			to.WriteInt32(Hash);
		}
	}
}