using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAtaque : MonoBehaviour {
	private int dano_sem_arma;
	private int dano_especial;
	private int dano_arma;
	private int dano_total;

 	InimigoVida matarInimigo;
	// Use this for initialization
	void Start () {
	
		dano_total = 5;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
			
		
				matarInimigo = hit.collider.gameObject.GetComponent<InimigoVida>();

			if ( hit.collider.gameObject.tag == "Inimigo")
				{

					matarInimigo.InimigoReceberDano(dano_total);

				}
			
			}
		}




}
