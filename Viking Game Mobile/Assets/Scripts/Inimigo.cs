using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	private int vidaInimigo;
	private int dano;

	public float speed;

	// Use this for initialization
	void Start () {
		vidaInimigo = 10;
		dano = 1;
		speed = 2f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.transform.Translate(Vector3.left*speed*Time.deltaTime);
		if (this.transform.position.x <= -8f) {
			speed = 0f;
		}
	
	}
}
