using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapCreator : MonoBehaviour {

	public static MapCreator Instance = null;

	public MapModel mapModel;

	public List<RoomModel> roomList = new List<RoomModel>();

	public int curRoomCount = 0;
	public int curAreaWidth = 4;
	public int curMinSize = 4;

	public int spaceLength = 4;
	public Vector3 curPos = Vector3.zero;
	public int nextZ = 0;

	// Use this for initialization
	void Start () {

		Init();

		CreateMap();
	
	}

	public void Init() {

		Instance = this;
		curRoomCount = Random.Range(mapModel.minRoomCount, mapModel.maxRoomCount);
		curAreaWidth = Random.Range(mapModel.minAreaWidth, mapModel.maxAreaWidth);
		curMinSize = mapModel.minSize;

	}

	public void CreateMap() {
	
		for(int i = 0; i < curRoomCount; i++) {
		
			RoomModel tempRoomModel = new RoomModel();
			tempRoomModel.size.x = ResetSize(Random.Range(mapModel.minRoomLength, mapModel.maxRoomLength));
			tempRoomModel.size.y = 1;
			tempRoomModel.size.z = ResetSize(Random.Range(mapModel.minRoomWidth, mapModel.maxRoomWidth));
			tempRoomModel.pos = curPos;

			if(nextZ < tempRoomModel.size.z + tempRoomModel.pos.z) 
				nextZ = (int)(tempRoomModel.size.z + tempRoomModel.pos.z);

			if(curPos.x > curAreaWidth) {
			
				//Next height
				ResetSpace();
				curPos.z = nextZ + spaceLength;
				curPos.x = 0;
			
			}
			
			ResetSpace();
			curPos.x += tempRoomModel.size.x + spaceLength;
			roomList.Add(tempRoomModel);
			tempRoomModel.CreateView(this.transform);
			//create view
			//CreateRoomView(tempRoomModel);
		
		}

	}

	public void ResetSpace() { spaceLength = ResetSize(Random.Range(mapModel.minSize, mapModel.minSize * 3)); }

	public int ResetSize(int size) { return size/curMinSize * curMinSize; }

}
