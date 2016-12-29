using UnityEngine;
using System.Collections;

[System.Serializable]
public class CellModel {

	public Vector3 cellPos;
	public CellEnum cellEnum;
	public GameObject objGround;
	public GameObject objOther;

	public void SetCell(CellEnum cell, GameObject obj) {
	
		cellEnum = cell;
		objGround = obj;
	
	}

}

public enum CellEnum {

	ground,
	wall,
	corner,
	door,
	road,
	roadwall,
	roadcorner,

}