using UnityEngine;
using System.Collections;

public class InimigoMovimentaçao2 : MonoBehaviour {


	public float speed;




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		 
		this.transform.Translate(Vector3.left*speed*Time.deltaTime);
	

		if (this.transform.position.x <= Random.Range(7f,20f) ) {
			speed = 0f;

		}
			
	}




}
