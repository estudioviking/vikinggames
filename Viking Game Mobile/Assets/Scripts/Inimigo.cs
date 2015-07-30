using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	private float posicaoX;
	private float posicaoY;

	private int vidaInimigo;
	private int dano;

	public float speed;

	// Use this for initialization
	void Start () {
		speed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.left*speed*Time.deltaTime);
	}
}
