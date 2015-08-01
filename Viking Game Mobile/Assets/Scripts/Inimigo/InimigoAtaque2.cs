using UnityEngine;
using System.Collections;

public class InimigoAtaque2 : MonoBehaviour {


	public int dano;

	GameObject flechas;

	
	float temporizador;
	public float tempoEntreAtaques;
	
	void Awake (){
		//Definindo que apenas o player e utilizado, nao e necessario mas e o correto.
	}
	
	// Use this for initialization
	void Start () {
		tempoEntreAtaques = 2f;
		temporizador = 0;
		dano = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		temporizador += Time.deltaTime;

	
		if (this.transform.position.x <= Random.Range(-1f,9)) {
			if (temporizador >= tempoEntreAtaques ){
				AtirarFlechas();
				temporizador = 0f;
			}
		}
		
	}
	void AtirarFlechas(){
		//Criar flechas
	}
	

}
