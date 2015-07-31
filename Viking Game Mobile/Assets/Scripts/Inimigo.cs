using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	public int vidaInimigo;
	public int dano;

	//controladores s
	GameObject playerObjeto;
	Player player;
	public float speed;

	float temporizador;
	public float tempoEntreAtaques;

	void Awake (){
		//Definindo que apenas o player e utilizado, nao e necessario mas e o correto.
		playerObjeto = GameObject.FindGameObjectWithTag ("Player");
		player = playerObjeto.GetComponent<Player> ();

	}

	// Use this for initialization
	void Start () {
		tempoEntreAtaques = 2f;
		temporizador = 0;
		vidaInimigo = 10;
		dano = 1;
		speed = 2f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		temporizador += Time.deltaTime;

		this.transform.Translate(Vector3.left*speed*Time.deltaTime);
	
		
		if (vidaInimigo <= 0) {
			Destroy(this);
		}
		if (this.transform.position.x <= -8f) {
			speed = 0f;
			if (temporizador >= tempoEntreAtaques ){
				BaterPlayer();
				temporizador = 0f;
			}
		}
			
	}
	void BaterPlayer(){
		player.PlayerPerderVida (dano);
	}

	public void InimigoReceberDano (int perder){
		vidaInimigo -= perder;
	}



}
