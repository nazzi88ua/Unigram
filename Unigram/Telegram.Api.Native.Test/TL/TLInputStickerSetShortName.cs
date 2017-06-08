// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputStickerSetShortName : TLInputStickerSetBase 
	{
		public String ShortName { get; set; }

		public TLInputStickerSetShortName() { }
		public TLInputStickerSetShortName(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputStickerSetShortName; } }

		public override void Read(TLBinaryReader from)
		{
			ShortName = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(ShortName ?? string.Empty);
		}
	}
}