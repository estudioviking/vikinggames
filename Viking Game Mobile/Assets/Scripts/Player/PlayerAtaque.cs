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
	InimigoVida matarInimigo;
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
			
			if ( (hit.collider == null && worldPoint.x >=7.4 && arco) || (hit.collider.gameObject.tag == "Arqueiro" && arco))
				{
			//	float angle = Vector3.Angle(worldPoint,GameObject.FindWithTag("Player").transform.position);
				float angle = Mathf.DeltaAngle(Mathf.Atan2(GameObject.FindWithTag("Player").transform.position.y, GameObject.FindWithTag("Player").transform.position.x) * Mathf.Rad2Deg,
				                               Mathf.Atan2(worldPoint.y, worldPoint.x) * Mathf.Rad2Deg);

				Instantiate(flechaPlayer, transform.position, Quaternion.AngleAxis(angle,Vector3.forward));
			}
				matarInimigo = hit.collider.gameObject.GetComponent<InimigoVida>();

			if (machado && hit.collider.gameObject.tag == "Inimigo" && worldPoint.x <=7.5 && arco)
				{
					Debug.Log("teste");
					matarInimigo.InimigoReceberDano(dano_total);
					machado=true;
				}
			
			}
		}




}
