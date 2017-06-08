// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.changePhone.
	/// Returns <see cref="Telegram.Api.TL.TLUserBase"/>
	/// </summary>
	public partial class TLAccountChangePhone : TLObject
	{
		public String PhoneNumber { get; set; }
		public String PhoneCodeHash { get; set; }
		public String PhoneCode { get; set; }

		public TLAccountChangePhone() { }
		public TLAccountChangePhone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountChangePhone; } }

		public override void Read(TLBinaryReader from)
		{
			PhoneNumber = from.ReadString();
			PhoneCodeHash = from.ReadString();
			PhoneCode = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(PhoneNumber ?? string.Empty);
			to.WriteString(PhoneCodeHash ?? string.Empty);
			to.WriteString(PhoneCode ?? string.Empty);
		}
	}
}