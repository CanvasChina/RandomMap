using UnityEngine;
using System.Collections;

public class CameraScale : MonoBehaviour {

	public Camera camera;

	// Use this for initialization
	void Start () {
	
		camera = Camera.main;

	}
	
	// Update is called once per frame
	void Update () {
	
		camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, 100, Time.deltaTime * 0.1f);


	}
}
