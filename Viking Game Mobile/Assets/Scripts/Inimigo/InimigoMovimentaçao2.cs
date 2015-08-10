using UnityEngine;
using System.Collections;

public class InimigoMovimentaçao2: MonoBehaviour {


	public float speed;
	public float limitx, limity;




	// Use this for initialization
	void Start () {
		limitx = 3.5f;
		limity = -7.5f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		 
		this.transform.Translate(Vector2.down*speed*Time.deltaTime);
	

		if (this.transform.position.y <= limity) {
			speed = 0f;

		}
			
	}




}
