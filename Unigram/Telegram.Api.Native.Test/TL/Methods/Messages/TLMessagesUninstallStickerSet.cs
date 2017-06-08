// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.uninstallStickerSet.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesUninstallStickerSet : TLObject
	{
		public TLInputStickerSetBase StickerSet { get; set; }

		public TLMessagesUninstallStickerSet() { }
		public TLMessagesUninstallStickerSet(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesUninstallStickerSet; } }

		public override void Read(TLBinaryReader from)
		{
			StickerSet = TLFactory.Read<TLInputStickerSetBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(StickerSet);
		}
	}
}