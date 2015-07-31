using UnityEngine;
using System.Collections;

public class ManagerInimigos : MonoBehaviour {
	//posiçao de onde os inimigos iram sair

	private float posicaoInicialY;
	//listar inimigos
	public GameObject inimigo1;
	public GameObject inimigo2;

	// Use this for initialization
	void Start () {

		Invoke ("Inimigo", 2f);

	}
	
	// Update is called once per frame	
	void Update () {

	}
	void Inimigo(){

		posicaoInicialY = Random.Range (-6.0f,6.0f);
		Instantiate (inimigo1,new Vector3(this.transform.position.x,posicaoInicialY,this.transform.position.z),Quaternion.identity);
		Invoke ("Inimigo", Random.Range(2f,5f));
	
	}






}
