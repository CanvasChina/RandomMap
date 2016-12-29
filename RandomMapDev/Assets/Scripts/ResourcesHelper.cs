using UnityEngine;
using System.Collections;

public class ResourcesHelper {

	public static GameObject Create(string path, Vector3 pos) {
	
		return GameObject.Instantiate(Resources.Load(path), pos, Quaternion.identity) as GameObject;
	
	}

	public static GameObject Create(string path, int posX, int posZ, Transform tranRoot = null) {

		GameObject obj = Create(path, new Vector3(posX, -0.5f, posZ));

		obj.transform.SetParent(tranRoot);

		return obj;
	
	}

}
