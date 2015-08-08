using UnityEngine;
using System.Collections;

public class InimigoAtaque : MonoBehaviour {

	public int dano;


	InimigoMovimentaçao inimigo;



	void Awake (){
		//Definindo que apenas o player e utilizado, nao e necessario mas e o correto.
		inimigo = GetComponent<InimigoMovimentaçao>();

	}

	// Update is called once per frame
	void Update () {


		if (inimigo.speed == 0){
				BaterPlayer();
				Destroy(this.gameObject);

		}
	}

	public void BaterPlayer(){	
		Player play = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		play.PlayerPerderVida (dano);
	}
}
