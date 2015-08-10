using UnityEngine;
using System.Collections;

public class GameControler : MonoBehaviour {


	private int moeda, moedasColetadas, valorMoeda, valorPower;
	private int level;
	// Use this for initialization
	void Start () {
		moedasColetadas = PlayerPrefs.GetInt ("player_moedas", 0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
			
			if ( hit.collider != null )
			{
				if (hit.collider.gameObject.tag == "Moeda"){
					Moeda pegarValorMoeda = hit.collider.gameObject.GetComponent<Moeda>();
					valorMoeda = pegarValorMoeda.ValorMoeda();
					hit.collider.gameObject.SendMessage("MoverMoeda");

					PlayerPegarMoedas(valorMoeda);

				}
			}
		}
	}

	void PlayerPegarMoedas(int pegar){
		moeda += pegar;
	
		//if (moeda > moedasColetadas)
		//{
			
			moedasColetadas = moeda;
			ScoreManager.score += moeda;

			PlayerPrefs.SetInt("player_moedas", moedasColetadas);
			PlayerPrefs.Save();
		
		moeda = 0;
		
		//}

	}
}
