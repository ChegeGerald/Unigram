// <auto-generated/>
using System;

namespace Telegram.Api.TL.Storage
{
	public partial class TLStorageFileMp3 : TLStorageFileTypeBase 
	{
		public TLStorageFileMp3() { }
		public TLStorageFileMp3(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.StorageFileMp3; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x528A0677);
		}
	}
}