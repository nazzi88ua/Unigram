// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.updateUsername.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLChannelsUpdateUsername : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public String Username { get; set; }

		public TLChannelsUpdateUsername() { }
		public TLChannelsUpdateUsername(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsUpdateUsername; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Username = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteString(Username ?? string.Empty);
		}
	}
}