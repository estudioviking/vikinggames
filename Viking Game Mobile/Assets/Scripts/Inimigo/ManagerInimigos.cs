using UnityEngine;
using System.Collections;

public class ManagerInimigos : MonoBehaviour {
	//posiçao de onde os inimigos iram sair

	private float posicaoInicialY;
	//listar inimigos
	public GameObject guerreiro;
	public GameObject arqueiro;

	// Use this for initialization
	void Start () {

		Invoke ("Guerreiro", 2f);
		Invoke ("Arqueiro", 2f);

	}
	
	// Update is called once per frame	
	void Update () {

	}
	void Guerreiro(){

		posicaoInicialY = Random.Range (-6.0f,6.0f);
		Instantiate (guerreiro,new Vector3(this.transform.position.x,posicaoInicialY,this.transform.position.z),Quaternion.identity);
		Invoke ("Guerreiro", Random.Range(2f,5f));
	
	}
	void Arqueiro(){
		
		posicaoInicialY = Random.Range (-6.0f,6.0f);
		Instantiate (arqueiro,new Vector3(this.transform.position.x,posicaoInicialY,this.transform.position.z),Quaternion.identity);
		Invoke ("Arqueiro", Random.Range(3f,8f));
		
	}





}
