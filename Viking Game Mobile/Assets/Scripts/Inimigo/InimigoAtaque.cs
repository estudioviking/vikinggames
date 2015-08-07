using UnityEngine;
using System.Collections;

public class InimigoAtaque : MonoBehaviour {

	public int dano;


	InimigoMovimentaçao inimigo;

	float temporizador;
	public float tempoEntreAtaques;

	void Awake (){
		//Definindo que apenas o player e utilizado, nao e necessario mas e o correto.
		temporizador = 0;
		inimigo = GetComponent<InimigoMovimentaçao>();

	}

	// Update is called once per frame
	void Update () {
		temporizador += Time.deltaTime;

		if (inimigo.speed == 0){

			if (temporizador >= tempoEntreAtaques ){
				BaterPlayer();
				temporizador = 0f;
			}

		}
	}

	public void BaterPlayer(){	
		Player play = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		play.PlayerPerderVida (dano);
	}
}
