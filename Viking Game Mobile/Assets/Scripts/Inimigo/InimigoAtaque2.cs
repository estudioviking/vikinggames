using UnityEngine;
using System.Collections;

public class InimigoAtaque2 : MonoBehaviour {

	public GameObject flechas;
	InimigoMovimentaçao2 inimigo2;
	
	float temporizador;
	public float tempoEntreAtaques;
	
	void Awake (){
		//Definindo que apenas o player e utilizado, nao e necessario mas e o correto.
		tempoEntreAtaques = 5.0f;
		temporizador = 0;
		inimigo2 = GetComponent<InimigoMovimentaçao2>();

	}
	

	
	// Update is called once per frame
	void FixedUpdate () {
		temporizador += Time.deltaTime;

	
		if (inimigo2.speed == 0){
			if (temporizador >= tempoEntreAtaques ){
				AtirarFlechas();
				temporizador = 0f;
			}
		}
		
	}
	void AtirarFlechas(){
		Instantiate (flechas,this.transform.position,Quaternion.identity);
	}
	

}
