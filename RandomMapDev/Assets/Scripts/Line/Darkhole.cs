using UnityEngine;
using System.Collections;

public class Darkhole : MonoBehaviour {

	public LTVisual ltVisual;

	public float size = 1;

	public float removetime = 1;

	// Use this for initialization
	void Start () {}

	public void Init(float _remove) {
	
		size = Time.time;

		ltVisual.toVecValue *= Random.Range(0.3f, 5);
		ltVisual.toTime *= Random.Range(1, 7.7f);
		ltVisual.DoTween();

		removetime = _remove;

		LeanTween.delayedCall(removetime, OnEnd);
	
	}

	public void OnEnd() {
	
		LeanTween.scale(this.gameObject, Vector3.zero, 0.7f).setOnComplete(()=> {
		
			this.gameObject.SetActive(false);
		
		});
	
	}

}
