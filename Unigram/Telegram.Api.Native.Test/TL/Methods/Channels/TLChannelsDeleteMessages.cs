// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.deleteMessages.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesAffectedMessages"/>
	/// </summary>
	public partial class TLChannelsDeleteMessages : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public TLVector<Int32> Id { get; set; }

		public TLChannelsDeleteMessages() { }
		public TLChannelsDeleteMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsDeleteMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Id = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteObject(Id);
		}
	}
}