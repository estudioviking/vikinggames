using UnityEngine;
using System.Collections;

public class Flecha : MonoBehaviour {
	public int dano;
	public float velocidade;
    GameObject player;
	Player perdervida;

	// Use this for initialization

	void Awake (){

		player = GameObject.FindWithTag("Player");
		perdervida = player.GetComponent<Player> ();


	}
	void Start(){


	}
	
	// Update is called once per frame   player.transform.position
	void Update () {
		float step = velocidade * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position,step);

	}
	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Player") {
			perdervida.PlayerPerderVida(dano);
			Destroy(this.gameObject);
		}


	}

}
