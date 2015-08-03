using UnityEngine;
using System.Collections;

public class olharplayer : MonoBehaviour {
	GameObject player;

	Vector3 posicaoPlayer;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");

		posicaoPlayer = new Vector3 (player.transform.position.x, 1, 1);
		transform.LookAt (posicaoPlayer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
