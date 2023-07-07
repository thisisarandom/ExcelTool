/*
 * auto generated by tools(注意:千万不要手动修改本文件)
 * official_room
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UnityEngine;

[Serializable]
public partial class official_room : IBinarySerializable
{
	/// <summary>
	/// 序号
	/// </summary>
	public int Id;
	/// <summary>
	/// 
	/// </summary>
	public string RoomOwner;
	/// <summary>
	/// 注释(产品用来自己备注的)
	/// </summary>
	public string Notes;
	/// <summary>
	/// 默认名称(该场景的默认显示的名称)
	/// </summary>
	public string RoomName;
	/// <summary>
	/// 默认场景简述(该场景默认显示的简要描述信息，显示在官方房间入口上)
	/// </summary>
	public string RoomBriefly;
	/// <summary>
	/// 场景详情(该场景的详细描述信息，显示在详情页中)
	/// </summary>
	public string RoomDetails;
	/// <summary>
	/// 背景图(对应显示在详情界面上的图片pathID或路径，希望能支持填写为一个表，即填多张，以支持轮播显示)
	/// </summary>
	public string BgPathId;
	/// <summary>
	/// 对应场景ID(对应场景注册表中的场景ID)
	/// </summary>
	public string ScenesId;
	/// <summary>
	/// 对应地图地址(对应高德上的地图地址，填对应点的经纬度，是否要同时把POI点名称填上，由程序确认)
	/// </summary>
	public string Address;
	/// <summary>
	/// 初始推荐排序（房间生成时的推荐优先级，确定初始显示位置，数字越低，优先级越高，后续会随着房间推荐算法变化）
	/// </summary>
	public int Recommend;
	/// <summary>
	/// 分线启用人数（达到多少人启用分线，不填或为0为不分线）
	/// </summary>
	public int SubLine;
	/// <summary>
	/// 客人是否可使用背包（在该房间中，客人不可以使用背包）
	/// </summary>
	public int IsCanPackage;
	/// <summary>
	/// 进入默认静音
	/// </summary>
	public int IsMute;
	/// <summary>
	/// 出生点坐标
	/// </summary>
	public List<float> BirthPosition;
	/// <summary>
	/// 
	/// </summary>
	public List<float> Offset;
	/// <summary>
	/// Int数组测试
	/// </summary>
	public List<int> IntListAttr;
	/// <summary>
	/// float数组测试
	/// </summary>
	public List<float> FloatListAttr;

	public void DeSerialize(BinaryReader reader)
	{
		Id = reader.ReadInt32();
		RoomOwner = reader.ReadString();
		Notes = reader.ReadString();
		RoomName = reader.ReadString();
		RoomBriefly = reader.ReadString();
		RoomDetails = reader.ReadString();
		BgPathId = reader.ReadString();
		ScenesId = reader.ReadString();
		Address = reader.ReadString();
		Recommend = reader.ReadInt32();
		SubLine = reader.ReadInt32();
		IsCanPackage = reader.ReadInt32();
		IsMute = reader.ReadInt32();
		var BirthPositionCount = reader.ReadInt32();
		if (BirthPositionCount > 0)
		{
			BirthPosition = new List<float>();
			for (int i = 0; i < BirthPositionCount; i++)
			{
				BirthPosition.Add(reader.ReadSingle());
			}
		}
		else
		{
			BirthPosition = null;
		}
		var OffsetCount = reader.ReadInt32();
		if (OffsetCount > 0)
		{
			Offset = new List<float>();
			for (int i = 0; i < OffsetCount; i++)
			{
				Offset.Add(reader.ReadSingle());
			}
		}
		else
		{
			Offset = null;
		}
		var IntListAttrCount = reader.ReadInt32();
		if (IntListAttrCount > 0)
		{
			IntListAttr = new List<int>();
			for (int i = 0; i < IntListAttrCount; i++)
			{
				IntListAttr.Add(reader.ReadInt32());
			}
		}
		else
		{
			IntListAttr = null;
		}
		var FloatListAttrCount = reader.ReadInt32();
		if (FloatListAttrCount > 0)
		{
			FloatListAttr = new List<float>();
			for (int i = 0; i < FloatListAttrCount; i++)
			{
				FloatListAttr.Add(reader.ReadSingle());
			}
		}
		else
		{
			FloatListAttr = null;
		}
	}

	public void Serialize(BinaryWriter writer)
	{
		writer.Write(Id);
		writer.Write(RoomOwner);
		writer.Write(Notes);
		writer.Write(RoomName);
		writer.Write(RoomBriefly);
		writer.Write(RoomDetails);
		writer.Write(BgPathId);
		writer.Write(ScenesId);
		writer.Write(Address);
		writer.Write(Recommend);
		writer.Write(SubLine);
		writer.Write(IsCanPackage);
		writer.Write(IsMute);
		if (BirthPosition == null || BirthPosition.Count == 0)
		{
			writer.Write(0);
		}
		else
		{
			writer.Write(BirthPosition.Count);
			for (int i = 0; i < BirthPosition.Count; i++)
			{
				writer.Write(BirthPosition[i]);
			}
		}
		if (Offset == null || Offset.Count == 0)
		{
			writer.Write(0);
		}
		else
		{
			writer.Write(Offset.Count);
			for (int i = 0; i < Offset.Count; i++)
			{
				writer.Write(Offset[i]);
			}
		}
		if (IntListAttr == null || IntListAttr.Count == 0)
		{
			writer.Write(0);
		}
		else
		{
			writer.Write(IntListAttr.Count);
			for (int i = 0; i < IntListAttr.Count; i++)
			{
				writer.Write(IntListAttr[i]);
			}
		}
		if (FloatListAttr == null || FloatListAttr.Count == 0)
		{
			writer.Write(0);
		}
		else
		{
			writer.Write(FloatListAttr.Count);
			for (int i = 0; i < FloatListAttr.Count; i++)
			{
				writer.Write(FloatListAttr[i]);
			}
		}
	}
}

[Serializable]
public partial class official_roomConfig : ScriptableObject,IBinarySerializable
{
	public official_room[] official_roomInfos;
	public void DeSerialize(BinaryReader reader)
	{
		int count = reader.ReadInt32();
		official_roomInfos = new official_room[count];
		for (int i = 0;i < count; i++)
		{
			official_room tempData = new official_room();
			tempData.DeSerialize(reader);
			official_roomInfos[i] = tempData;
		}
	}

	public void Serialize(BinaryWriter writer)
	{
		writer.Write(official_roomInfos.Length);
		for (int i = 0; i < official_roomInfos.Length; i++)
		{
			official_roomInfos[i].Serialize(writer);
		}
	}

	public official_room QueryById(int id)
	{
		var datas = official_roomInfos.FirstOrDefault(x => x.Id == id);
		return datas;
	}
}
