// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputMessagesFilterPhotoVideoDocuments : TLMessagesFilterBase 
	{
		public TLInputMessagesFilterPhotoVideoDocuments() { }
		public TLInputMessagesFilterPhotoVideoDocuments(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMessagesFilterPhotoVideoDocuments; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xD95E73BB);
		}
	}
}