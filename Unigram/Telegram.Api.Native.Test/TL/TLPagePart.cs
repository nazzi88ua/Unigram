// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPagePart : TLPageBase 
	{
		public TLPagePart() { }
		public TLPagePart(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PagePart; } }

		public override void Read(TLBinaryReader from)
		{
			Blocks = TLFactory.Read<TLVector<TLPageBlockBase>>(from);
			Photos = TLFactory.Read<TLVector<TLPhotoBase>>(from);
			Videos = TLFactory.Read<TLVector<TLDocumentBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Blocks);
			to.WriteObject(Photos);
			to.WriteObject(Videos);
		}
	}
}