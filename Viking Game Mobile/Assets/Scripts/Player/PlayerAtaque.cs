using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAtaque : MonoBehaviour {
	private int powerPlayer;
	private int dano_sem_arma;
	private int dano_especial;
	private int dano_arma;
	private int dano_total;

	public Slider sliderPower;

	// Use this for initialization
	void Start () {
		dano_total = 5;
		powerPlayer = 10;
		sliderPower.maxValue = powerPlayer;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay2D(Collider2D col) {

			if (Input.GetMouseButtonDown(0))
			{
				//Get the mouse position on the screen and send a raycast into the game world from that position.
				Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
				
				if ( hit.collider != null )
			{
				if(col.gameObject.tag == "Inimigo1"){
					InimigoVida matarInimigo = hit.collider.gameObject.GetComponent<InimigoVida>();
					matarInimigo.InimigoReceberDano(dano_total);
				}

			}
			}
		
	}
}
