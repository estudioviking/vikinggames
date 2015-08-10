using UnityEngine;
using System.Collections;

public class ManagerInimigos : MonoBehaviour {
	//posiçao de onde os inimigos iram sair

	private float posicaoInicialX;
	//listar inimigos
	public GameObject guerreiro;


	private float tempoLevel;
	private float tempoLevelVariavel;

	private int invocar;

	// Use this for initialization
	void Start () {

		Invoke ("Guerreiro", 2f);


		tempoLevel = Time.time;
		tempoLevelVariavel = 10f;


	}
	
	// Update is called once per frame	
	void Update () {
		invocar = Random.Range (1, 100);

		if (invocar > 25) {
			if (Time.time >= tempoLevel + tempoLevelVariavel) {
				Invoke ("Guerreiro", 1f);
				tempoLevel = Time.time;
				tempoLevelVariavel -= 0.5f;

			}
			if (tempoLevelVariavel <= 1) {
				tempoLevelVariavel = 2f;
			}
		}

		if(invocar <= 30)
			if (Time.time >= tempoLevel + tempoLevelVariavel) {
				Invoke ("Guerreiro", 1f);
				tempoLevel = Time.time;
				tempoLevelVariavel -= 0.5f;
				
			}
			if (tempoLevelVariavel <= 1) {
				tempoLevelVariavel = 2f;
			}

	}
	void Guerreiro(){

		posicaoInicialX = Random.Range (2f,21.5f);
		Instantiate (guerreiro,new Vector3(posicaoInicialX,this.transform.position.y,this.transform.position.z),Quaternion.identity);

	
	}






}
