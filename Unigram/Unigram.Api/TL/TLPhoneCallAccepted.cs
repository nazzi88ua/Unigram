// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPhoneCallAccepted : TLPhoneCallBase 
	{
		public Int64 AccessHash { get; set; }
		public Int32 Date { get; set; }
		public Int32 AdminId { get; set; }
		public Int32 ParticipantId { get; set; }
		public Byte[] GB { get; set; }
		public TLPhoneCallProtocol Protocol { get; set; }

		public TLPhoneCallAccepted() { }
		public TLPhoneCallAccepted(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhoneCallAccepted; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
			GB = from.ReadByteArray();
			Protocol = TLFactory.Read<TLPhoneCallProtocol>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6D003D3F);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Date);
			to.Write(AdminId);
			to.Write(ParticipantId);
			to.WriteByteArray(GB);
			to.WriteObject(Protocol);
		}
	}
}