using UnityEngine;
using System.Collections;

public class InimigoMovimentaçao3 : MonoBehaviour {


	public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		 
		this.transform.Translate(Vector2.down*speed*Time.deltaTime);
	
			
	}




}
