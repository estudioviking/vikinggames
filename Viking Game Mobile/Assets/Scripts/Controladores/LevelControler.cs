using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelControler : MonoBehaviour {
	public static int pontos;
	int lvl,uparlvl;
	Text text;
	
	
	void Awake ()
	{
		text = GetComponent <Text> ();
		lvl = 0;
		pontos = 0;
		uparlvl = 100;

	}
	
	
	void Update ()
	{

		if(pontos > uparlvl){
			lvl +=1;
			uparlvl += pontos; 
			pontos = 0;

		}
		text.text = "lvl: " + lvl;
	}
}
