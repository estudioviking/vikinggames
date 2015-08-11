using UnityEngine;
using System.Collections;

public class InimigoAtaque : MonoBehaviour {

	public int dano;
	
//	void Awake (){

//	}

	// Update is called once per frame
	void Update () {


	}

	public void BaterPlayer(){	
		Player play = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		play.PlayerPerderVida (dano);
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Limite") {
			BaterPlayer ();
			Destroy (this.gameObject);
		}
	}
}
