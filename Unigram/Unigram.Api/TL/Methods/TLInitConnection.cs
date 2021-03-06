// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method initConnection.
	/// Returns <see cref="Telegram.Api.TL.TLObject"/>
	/// </summary>
	public partial class TLInitConnection : TLObject
	{
		public Int32 ApiId { get; set; }
		public String DeviceModel { get; set; }
		public String SystemVersion { get; set; }
		public String AppVersion { get; set; }
		public String SystemLangCode { get; set; }
		public String LangPack { get; set; }
		public String LangCode { get; set; }
		public TLObject Query { get; set; }

		public TLInitConnection() { }
		public TLInitConnection(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InitConnection; } }

		public override void Read(TLBinaryReader from)
		{
			ApiId = from.ReadInt32();
			DeviceModel = from.ReadString();
			SystemVersion = from.ReadString();
			AppVersion = from.ReadString();
			SystemLangCode = from.ReadString();
			LangPack = from.ReadString();
			LangCode = from.ReadString();
			Query = TLFactory.Read<TLObject>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC7481DA6);
			to.Write(ApiId);
			to.Write(DeviceModel);
			to.Write(SystemVersion);
			to.Write(AppVersion);
			to.Write(SystemLangCode);
			to.Write(LangPack);
			to.Write(LangCode);
			to.WriteObject(Query);
		}
	}
}