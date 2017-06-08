// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.toggleInvites.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsToggleInvites : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public Boolean Enabled { get; set; }

		public TLChannelsToggleInvites() { }
		public TLChannelsToggleInvites(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsToggleInvites; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Enabled = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteBoolean(Enabled);
		}
	}
}