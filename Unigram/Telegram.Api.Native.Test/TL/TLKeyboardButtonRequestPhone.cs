// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonRequestPhone : TLKeyboardButtonBase 
	{
		public TLKeyboardButtonRequestPhone() { }
		public TLKeyboardButtonRequestPhone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonRequestPhone; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Text ?? string.Empty);
		}
	}
}