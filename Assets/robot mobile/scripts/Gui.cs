using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gui : MonoBehaviour 
{
	public MaterielScript ma;
	public EnZoneDepot en;
	// Use this for initialization
	void Start () 
	{
		
	}
	void OnGUI(){
		GUI.Box (new Rect (10, 10, 100, 140), "robot etat");
		if (ma.B1 == false) {
			GUI.Button(new Rect(20,40,80,20),"move mode");
		}
		if (ma.B1 == true) {
			GUI.Button(new Rect(20,40,80,20),"bras mode");
		}
		if (ma.B3 == true) {
			GUI.Button(new Rect(20,70,80,20),"catching");
		}
		if (en.EstEnZoneDepot == true) {
			GUI.Button(new Rect(20,110,80,20),"en zone");
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
