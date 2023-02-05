// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct Player_id7_UnityEngine__char_46_Transform_4503379051863377800 : ICoherenceComponentData
	{
		public Vector3 position;
		public Quaternion rotation;
		public Vector3 localScale;

		public override string ToString()
		{
			return $"Player_id7_UnityEngine__char_46_Transform_4503379051863377800(position: {position}, rotation: {rotation}, localScale: {localScale})";
		}

		public uint GetComponentType() => Definition.InternalPlayer_id7_UnityEngine__char_46_Transform_4503379051863377800;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (Player_id7_UnityEngine__char_46_Transform_4503379051863377800)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				position = other.position;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				rotation = other.rotation;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				localScale = other.localScale;
			}
			mask >>= 1;
			return this;
		}

		public static void Serialize(Player_id7_UnityEngine__char_46_Transform_4503379051863377800 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteVector3((data.position.ToCoreVector3()), FloatMeta.NoCompression());
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteQuaternion((data.rotation.ToCoreQuaternion()), 32);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteVector3((data.localScale.ToCoreVector3()), FloatMeta.NoCompression());
			}
			mask >>= 1;
		}

		public static (Player_id7_UnityEngine__char_46_Transform_4503379051863377800, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Player_id7_UnityEngine__char_46_Transform_4503379051863377800();
	
			if (bitStream.ReadMask())
			{
				val.position = (bitStream.ReadVector3(FloatMeta.NoCompression())).ToUnityVector3();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.rotation = (bitStream.ReadQuaternion(32)).ToUnityQuaternion();
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.localScale = (bitStream.ReadVector3(FloatMeta.NoCompression())).ToUnityVector3();
				mask |= 0b00000000000000000000000000000100;
			}
			return (val, mask, null);
		}
		public static (Player_id7_UnityEngine__char_46_Transform_4503379051863377800, uint, uint?) DeserializeArchetypePlayer_ce16ea156b0434b469594785f889bc58_Player_id7_UnityEngine__char_46_Transform_4503379051863377800_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Player_id7_UnityEngine__char_46_Transform_4503379051863377800();
			if (bitStream.ReadMask())
			{
				val.position = (bitStream.ReadVector3(FloatMeta.NoCompression())).ToUnityVector3();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.rotation = (bitStream.ReadQuaternion(32)).ToUnityQuaternion();
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.localScale = (bitStream.ReadVector3(FloatMeta.NoCompression())).ToUnityVector3();
				mask |= 0b00000000000000000000000000000100;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as Player_id7_UnityEngine__char_46_Transform_4503379051863377800?;
	
		}
	}
}