using UnityEngine;
using System.Collections;

public class InimigoMovimentaçao : MonoBehaviour {


	public float speed;
	public float limitx;




	// Use this for initialization
	void Start () {
		limitx = 3.5f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		 
		this.transform.Translate(Vector3.left*speed*Time.deltaTime);
	

		if (this.transform.position.x <= limitx) {
			speed = 0f;

		}
			
	}




}
