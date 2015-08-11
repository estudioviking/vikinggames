using UnityEngine;
using System.Collections;

public class InimigoMovimentaçao1 : MonoBehaviour {


	public float speed;
	int controleVelocidade;

	float timer;
	bool direita, esquerda;
	// Use this for initialization
	void Start () {
		timer = 0;
		direita = true;
		esquerda = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime;
		if(LevelControler.lvl > controleVelocidade){
			speed +=1;
			controleVelocidade +=10;
		}

		if(direita){
			this.transform.Translate((Vector2.right+Vector2.down)*speed*Time.deltaTime);
			if(timer >= 1f){
				direita = false;
				timer = 0;
				esquerda=true;
			}

		}
		if(esquerda){
			this.transform.Translate((Vector2.left+Vector2.down)*speed*Time.deltaTime);
			if(timer >= 1f){

				direita = true;
				timer = 0;
				esquerda=false;
			}

		}

		}


	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == "Direita") {
			esquerda = true;
			direita = false;
			timer =0;
		}
		if (coll.gameObject.tag == "Esquerda") {

			esquerda = false;
			direita = true;
			timer=0;
		}
	}

}





