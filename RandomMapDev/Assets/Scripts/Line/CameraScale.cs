using UnityEngine;
using System.Collections;

public class CameraScale : MonoBehaviour {

	public Camera camera;

	public float scaleSpeed = 0.1f;

	public int deep = 100;

	// Use this for initialization
	void Start () {
	
		camera = Camera.main;

	}
	
	// Update is called once per frame
	void Update () {
	
		camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, deep, Time.deltaTime * scaleSpeed);


	}
}
