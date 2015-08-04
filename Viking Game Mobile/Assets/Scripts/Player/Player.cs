using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public int vidaPlayer;
	private int levelPlayer;




	public Slider sliderVida;


	// Use this for initialization
	void Start () {
		vidaPlayer = 10;
		sliderVida.maxValue = vidaPlayer;
	

	}
	
	// Update is called once per frame
	void Update () {
			
	}
	

	public void PlayerPerderVida(int perder){

		vidaPlayer -= perder;
		sliderVida.value = vidaPlayer;

	}

}
