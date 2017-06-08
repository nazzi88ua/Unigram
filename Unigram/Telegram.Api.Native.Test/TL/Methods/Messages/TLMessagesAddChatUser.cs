// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.addChatUser.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesAddChatUser : TLObject
	{
		public Int32 ChatId { get; set; }
		public TLInputUserBase UserId { get; set; }
		public Int32 FwdLimit { get; set; }

		public TLMessagesAddChatUser() { }
		public TLMessagesAddChatUser(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesAddChatUser; } }

		public override void Read(TLBinaryReader from)
		{
			ChatId = from.ReadInt32();
			UserId = TLFactory.Read<TLInputUserBase>(from);
			FwdLimit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(ChatId);
			to.WriteObject(UserId);
			to.WriteInt32(FwdLimit);
		}
	}
}