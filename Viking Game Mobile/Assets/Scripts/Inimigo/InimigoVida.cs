using UnityEngine;
using System.Collections;

public class InimigoVida : MonoBehaviour {
	public int vidaInimigo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void InimigoReceberDano (int perder){
		vidaInimigo -= perder;
	}

}
