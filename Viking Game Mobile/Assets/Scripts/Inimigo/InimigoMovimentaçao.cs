using UnityEngine;
using System.Collections;

public class InimigoMovimentaçao : MonoBehaviour {


	public float speed;
	public float limitx, limity;
	public int controleVelocidade;



	// Use this for initialization

	void Start () {
		
		controleVelocidade = 10;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(LevelControler.lvl > controleVelocidade){
			speed +=1;
			controleVelocidade +=10;
		} 
		this.transform.Translate(Vector2.down*speed*Time.deltaTime);
		
		
		
		
	}




}
