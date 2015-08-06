using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public int vidaPlayer;
	public int powerPlayer,power;
	private int levelPlayer;
	
	public Slider sliderVida;
	public Slider sliderPower;

	// Use this for initialization
	void Start () {
		power = 0;
		vidaPlayer = 10;
		sliderVida.maxValue = vidaPlayer;
		sliderPower.maxValue = 10;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
			{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
			
			if ( hit.collider != null )
				{
				if (hit.collider.gameObject.tag == "Power")
					{
					Power pegarValorPower = hit.collider.gameObject.GetComponent<Power>();
					power = pegarValorPower.ValorPower();
					hit.collider.gameObject.SendMessage("MoverPower");
					
					PlayerPegarPower(power);

					}
				}
			}

	}
	

	public void PlayerPerderVida(int perder){

		vidaPlayer -= perder;
		sliderVida.value = vidaPlayer;

	}
	void PlayerPegarPower(int pegar){
		powerPlayer += pegar;
		sliderPower.value = powerPlayer;		
	}

}
