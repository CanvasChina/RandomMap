using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class RoomModel {

	public Vector3 pos;
	public Vector3 size;

	public List<CellModel> roomCellList = new List<CellModel>();

	public void CreateView(Transform tranParent) {

		int countX = (int)(size.x + pos.x);
		int countZ = (int)(size.z + pos.z);

		GameObject objRoom = new GameObject();
		objRoom.name = System.String.Format("x:{0} z:{1}", pos.x, pos.z);
		Transform tranRoom = objRoom.transform;
		tranRoom.position = pos;
		tranRoom.SetParent(tranParent);

		for(int i = (int)pos.z; i < countZ; i += MapCreator.Instance.curMinSize) {

			for(int j = (int)pos.x; j < countX; j += MapCreator.Instance.curMinSize) {

				CellModel cell = new CellModel();
				cell.cellPos.x = j;
				cell.cellPos.z = i;
				cell.cellEnum = CellEnum.ground;
				GameObject objCell = ResourcesHelper.Create("ground", i, j, tranRoom);
				cell.SetCell(CellEnum.ground, objCell);
				roomCellList.Add(cell);

			}

		}

	}

}