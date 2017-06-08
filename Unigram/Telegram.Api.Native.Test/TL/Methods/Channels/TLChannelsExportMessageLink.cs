// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.exportMessageLink.
	/// Returns <see cref="Telegram.Api.TL.TLExportedMessageLink"/>
	/// </summary>
	public partial class TLChannelsExportMessageLink : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public Int32 Id { get; set; }

		public TLChannelsExportMessageLink() { }
		public TLChannelsExportMessageLink(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsExportMessageLink; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteInt32(Id);
		}
	}
}