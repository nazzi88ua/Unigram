// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateStickerSets : TLUpdateBase 
	{
		public TLUpdateStickerSets() { }
		public TLUpdateStickerSets(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateStickerSets; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x43AE3DEC);
		}
	}
}