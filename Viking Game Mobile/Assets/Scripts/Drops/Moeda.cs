using UnityEngine;
using System.Collections;

public class Moeda : MonoBehaviour {
	public int valorMoedaMaximo,valorMoedaMinimo;
	private int valorMoeda;
	private bool mover;
	// Use this for initialization
	void Start () {
		mover = false;
		valorMoedaMinimo = 1;
		valorMoedaMaximo = 5;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (mover) {
			transform.position = Vector2.Lerp (transform.position, GameObject.FindGameObjectWithTag ("Player").transform.position, Time.deltaTime * 2);
		}
	
	}
	public int ValorMoeda(){
		valorMoeda = Random.Range (valorMoedaMinimo,valorMoedaMaximo);
		return valorMoeda;
	}
	void MoverMoeda(){
		mover = true;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			Destroy(this.gameObject);
		}
	}
}
