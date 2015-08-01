using UnityEngine;
using System.Collections;

public class InimigoAtaque : MonoBehaviour {

	public int dano;

	GameObject playerObjeto;
	Player player;
	InimigoMovimentaçao inimigo;

	float temporizador;
	public float tempoEntreAtaques;

	void Awake (){
		//Definindo que apenas o player e utilizado, nao e necessario mas e o correto.
		temporizador = 0;
		playerObjeto = GameObject.FindGameObjectWithTag ("Player");
		player = playerObjeto.GetComponent<Player> ();

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
		player.PlayerPerderVida (dano);
	}
}
