using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnZoneDepot : MonoBehaviour 
{
	public bool EstEnZoneDepot;
	public GameObject cube;
	public GenereObjetsScript glist;
	// Use this for initialization
	void Start () 
	{
		EstEnZoneDepot = false;
	}
	public void OnTriggerEnter(Collider collider)
	{
		Debug.Log (collider.name);
	
		foreach (GameObject g0 in glist.cubes)
		{
			if (collider.name == g0.name)
			{
				EstEnZoneDepot = true;
			}
		}

	}

	public void OnTriggerExit(Collider collider)
	{
		foreach (GameObject g0 in glist.cubes) 
		{
			if (collider.name == g0.name)
			{
				EstEnZoneDepot = false;
			}
		}
	}
	public void OnTriggerStay(Collider collider)
	{
		foreach (GameObject g0 in glist.cubes) 
		{
			if (collider.name == g0.name) 
			{
				EstEnZoneDepot = true;
			}
		}
		
	}
	// Update is called once per frame
	void Update () {
		
		

	}
}
