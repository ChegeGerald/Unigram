// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageEntityTextUrl : TLMessageEntityBase 
	{
		public String Url { get; set; }

		public TLMessageEntityTextUrl() { }
		public TLMessageEntityTextUrl(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageEntityTextUrl; } }

		public override void Read(TLBinaryReader from)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
			Url = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x76A6D327);
			to.Write(Offset);
			to.Write(Length);
			to.Write(Url);
		}
	}
}