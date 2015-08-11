using UnityEngine;  
using System.Collections;

public class InimigoMovimentaçao2: MonoBehaviour {


	public float speed;
	int controleVelocidade;
	int limity,direcao;
	Rigidbody2D inimigoBody;
	bool cair;

	// Use this for initialization
	void Start () {
		inimigoBody = GetComponent<Rigidbody2D>();
		speed = 2;
		limity = 0;
		cair = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(LevelControler.lvl > controleVelocidade){
			speed +=1;
			controleVelocidade +=10;
		}
	
		this.transform.Translate (Vector2.down * speed * Time.deltaTime);
	
		if (limity >= transform.position.y && !cair ) {
			inimigoBody.gravityScale = 0.5f;
			direcao=Random.Range(0,10);
			if(direcao>5){			
				inimigoBody.AddForce(new Vector2(1,4)*100);
				}
			else{
				inimigoBody.AddForce(new Vector2(-1,4)*100);
			}
			cair =true;

		}
			

	}


}
