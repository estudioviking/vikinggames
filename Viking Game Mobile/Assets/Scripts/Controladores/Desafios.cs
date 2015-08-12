using UnityEngine;
using System.Collections;

public class Desafios : MonoBehaviour  {

	public GameObject inimigo,inimigo1,inimigo2;
	public GameObject guerreiro, aldeao;

	private float posicaoInicialX;

	private int invocar;
	private float tempoLevel;
	private float tempoLevelVariavel;
	// Use this for initialization
	void Start () {
		tempoLevel = Time.time;
		tempoLevelVariavel = 10f;

	}
	

	public void Randomicos(){
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
	public void Guerreiro(){
		
		posicaoInicialX = Random.Range (2f,21.5f);
		Instantiate (guerreiro,new Vector3(posicaoInicialX,this.transform.position.y,this.transform.position.z),Quaternion.identity);
		
		
	}


}
