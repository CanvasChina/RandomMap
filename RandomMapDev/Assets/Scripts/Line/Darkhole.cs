using UnityEngine;
using System.Collections;

public class Darkhole : MonoBehaviour {

	public LTVisual ltVisual;

	// Use this for initialization
	void Start () {

		ltVisual.toVecValue *= Random.Range(0.3f, 5);
		ltVisual.toTime *= Random.Range(1, 7.7f);
		ltVisual.DoTween();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
