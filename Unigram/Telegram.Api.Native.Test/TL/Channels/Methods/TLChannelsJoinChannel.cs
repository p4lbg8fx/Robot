// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.joinChannel.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsJoinChannel : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsJoinChannel() { }
		public TLChannelsJoinChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsJoinChannel; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
		}
	}
}