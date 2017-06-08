// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageEntityPre : TLMessageEntityBase 
	{
		public String Language { get; set; }

		public TLMessageEntityPre() { }
		public TLMessageEntityPre(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageEntityPre; } }

		public override void Read(TLBinaryReader from)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
			Language = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Offset);
			to.WriteInt32(Length);
			to.WriteString(Language ?? string.Empty);
		}
	}
}