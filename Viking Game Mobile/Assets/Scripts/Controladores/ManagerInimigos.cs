using UnityEngine;
using System.Collections;

public class ManagerInimigos : MonoBehaviour {
	//posiçao de onde os inimigos iram sair

	Desafios invocarDesafio;

	// Use this for initialization
	void Start () {
		invocarDesafio = GetComponent<Desafios>();
			}
	
	// Update is called once per frame	
	void Update () {
		invocarDesafio.Randomicos ();

	}



}
