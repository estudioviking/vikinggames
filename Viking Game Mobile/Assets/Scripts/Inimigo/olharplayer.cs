using UnityEngine;
using System.Collections;

public class OlharPlayer : MonoBehaviour {

	Vector3 posicaoPlayer;
	// Use this for initialization
	void Start () {
		olharPlayer ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void olharPlayer(){
				
		posicaoPlayer = new Vector3 (GameObject.FindWithTag("Player").transform.position.x, 1, 1);
		transform.LookAt (posicaoPlayer);
	}
	
}
