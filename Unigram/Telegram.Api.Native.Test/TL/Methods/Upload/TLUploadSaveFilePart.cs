// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Upload
{
	/// <summary>
	/// RCP method upload.saveFilePart.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLUploadSaveFilePart : TLObject
	{
		public Int64 FileId { get; set; }
		public Int32 FilePart { get; set; }
		public Byte[] Bytes { get; set; }

		public TLUploadSaveFilePart() { }
		public TLUploadSaveFilePart(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadSaveFilePart; } }

		public override void Read(TLBinaryReader from)
		{
			FileId = from.ReadInt64();
			FilePart = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(FileId);
			to.WriteInt32(FilePart);
			to.WriteByteArray(Bytes);
		}
	}
}