﻿using UnityEngine;
using System.Collections;

public class InimigoVida : MonoBehaviour {
	public int vidaInimigo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (vidaInimigo == 0) {
			Destroy(this);
		}
	
	}
	public void InimigoReceberDano (int perder){
		vidaInimigo -= perder;
	}

}
