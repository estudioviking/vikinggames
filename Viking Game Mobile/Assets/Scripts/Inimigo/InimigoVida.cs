using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InimigoVida : MonoBehaviour {
	public int vidaInimigo;
	public GameObject moeda;
	public GameObject power;

	public int pontosInimigo;
	int drop;

	// Use this for initialization
	void Start () {
		pontosInimigo = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (vidaInimigo <= 0) {
			drop = Random.Range(1,100);
			if(drop<=30)
				Instantiate(moeda, this.transform.position,Quaternion.identity);
			
			if(drop>=70)
				Instantiate(power, this.transform.position,Quaternion.identity);

			LevelControler.pontos += pontosInimigo;

			Destroy(this.gameObject);
		}
	
	}
	public void InimigoReceberDano (int perder){
		vidaInimigo -= perder;
	}
	

}
