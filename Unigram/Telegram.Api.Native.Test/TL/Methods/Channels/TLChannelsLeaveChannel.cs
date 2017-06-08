// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.leaveChannel.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsLeaveChannel : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsLeaveChannel() { }
		public TLChannelsLeaveChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsLeaveChannel; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
		}
	}
}