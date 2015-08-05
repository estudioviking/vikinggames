using UnityEngine;
using System.Collections;

public class Power : MonoBehaviour {
	public int valorPowerMaximo,valorPowerMinimo;
	private int valorPower;
	private bool mover;
	// Use this for initialization
	void Start () {
		mover = false;
		valorPowerMinimo = 1;
		valorPowerMaximo = 5;
	}

	// Update is called once per frame
	void Update () {
		if (mover) {
			transform.position = Vector2.Lerp (transform.position, GameObject.FindGameObjectWithTag ("Player").transform.position, Time.deltaTime * 2);
		}
	}
	public int ValorPower(){
		valorPower = Random.Range (valorPowerMinimo,valorPowerMaximo);
		return valorPower;
	}
	void MoverPower(){
		mover = true;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			Destroy(this.gameObject);
		}
	}
}
