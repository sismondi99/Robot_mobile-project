using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationScipt : MonoBehaviour 
{
	public gere_bras gere_bras = null;
	public Vector3 increment;
	// Start is called before the first frame update
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		gere_bras.increment = increment;
	}
}
