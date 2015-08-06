using UnityEngine;
using System.Collections;

public class FlechaPlayer : MonoBehaviour {
	public int dano=5;
	public float velocidade = 5f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Inimigo" || coll.gameObject.tag == "Arqueiro" ) {
			coll.gameObject.GetComponent<InimigoVida>().InimigoReceberDano(dano);
			Destroy(this.gameObject);
		}
}
}