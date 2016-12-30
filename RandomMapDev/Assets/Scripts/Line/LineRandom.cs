using UnityEngine;
using System.Collections;

public class LineRandom : MonoBehaviour {

	public Transform tran;

	public Vector3 direction;

	public float speed = 1;

	public float angleSpeed = 10;

	public Vector3 angleVec3;

	public bool isRandomAngle = false;

	public float changeTime = 3;

	public TrailRenderer trailRender;

	// Use this for initialization
	void Start () {

		tran = this.transform;
	
		angleVec3.y = 1;

		speed = Random.Range(1, 10);

		angleSpeed = Random.Range(1, 30);

		isRandomAngle = Random.value > 0.5f;

		trailRender = this.GetComponent<TrailRenderer>();

		trailRender.time = Random.Range(5, 30);

	}
	
	// Update is called once per frame
	void Update () {


		direction.z = 1;

		//Mathf.PingPong(Time.time, 2) - 1;

		//angleVec3.y = Mathf.PingPong(Time.time, 360);

		//tran.eulerAngles = angleVec3;

		tran.Translate(direction * speed * Time.deltaTime);

		tran.Rotate(angleVec3 * angleSpeed * Time.deltaTime);

		changeTime -= Time.deltaTime;

		if(changeTime < 0) {
		
			changeTime = Random.Range(3.0f, 10.0f);

			trailRender.time = Random.Range(5, 30);

			if(isRandomAngle) {

				angleSpeed = Random.Range(1, 30);

				ResourcesHelper.Create("darkhole", tran.position);
			
			}
		
		}

	}
}
