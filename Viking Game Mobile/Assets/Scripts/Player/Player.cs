using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int vidaPlayer;
	private int powerPlayer;
	private int levelPlayer;


	private int dano_sem_arma;
	private int dano_especial;
	private int dano_arma;
	private int dano_total;


	//causar dano nos inimigos

	// Use this for initialization
	void Start () {
		vidaPlayer = 10;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PlayerPerderVida(int perder){
		Debug.Log (vidaPlayer);
		vidaPlayer -= perder;

	}


}
