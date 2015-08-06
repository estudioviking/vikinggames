using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAtaque : MonoBehaviour {
	private int dano_sem_arma;
	private int dano_especial;
	private int dano_arma;
	private int dano_total;

	public GameObject flechaPlayer;

	bool arco;
	bool machado;
	
	// Use this for initialization
	void Start () {
		arco = true;
		machado = true;
		dano_total = 5;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
			
			if ( (hit.collider == null && worldPoint.x >=-3 && arco) || (hit.collider.gameObject.tag == "Arqueiro" && arco))
				{
			//	float angle = Vector3.Angle(worldPoint,GameObject.FindWithTag("Player").transform.position);
				float angle = Mathf.DeltaAngle(Mathf.Atan2(GameObject.FindWithTag("Player").transform.position.y, GameObject.FindWithTag("Player").transform.position.x) * Mathf.Rad2Deg,
				                               Mathf.Atan2(worldPoint.y, worldPoint.x) * Mathf.Rad2Deg);

				Instantiate(flechaPlayer, transform.position, Quaternion.AngleAxis(angle,Vector3.forward));
				}
			}
		}


	void OnTriggerStay2D(Collider2D col) 
			{

				if (Input.GetMouseButtonDown(0))
				{
				//Get the mouse position on the screen and send a raycast into the game world from that position.
					Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
				
					if ( hit.collider != null )
						{

						if(col.gameObject.tag == "Inimigo")
							{
						
							InimigoVida matarInimigo = hit.collider.gameObject.GetComponent<InimigoVida>();
						
							if (7.3f >= hit.collider.gameObject.transform.position.x)
								{
								matarInimigo.InimigoReceberDano(dano_total);
								}
							}

						}
					}
		
			}

}
