﻿using UnityEngine;
using System.Collections;

public class foreachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		string[] strings = new string[7];
		// array of 4 items
		strings[0] = "This is my grocery list";
		strings[1] = "Milk";
		strings[2] = "Navel Oranges";
		strings[3] = "Cocoa Puffs Cereal";
		strings[4] = "Can of Black Beans";
		strings[5] = "Donut";
		strings[6] = "Butter";
			
		foreach(string item in strings)
		{
			print (item);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
