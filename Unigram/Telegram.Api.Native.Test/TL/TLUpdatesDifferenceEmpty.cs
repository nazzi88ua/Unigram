// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesDifferenceEmpty : TLUpdatesDifferenceBase 
	{
		public Int32 Date { get; set; }
		public Int32 Seq { get; set; }

		public TLUpdatesDifferenceEmpty() { }
		public TLUpdatesDifferenceEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdatesDifferenceEmpty; } }

		public override void Read(TLBinaryReader from)
		{
			Date = from.ReadInt32();
			Seq = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Date);
			to.WriteInt32(Seq);
		}
	}
}