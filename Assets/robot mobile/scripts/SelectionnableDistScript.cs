using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionnableDistScript : MonoBehaviour 
{
	public bool EstSelectionable;
	public gere_bras gere_bras;
	public GameObject gameObject;
	public ToColor toColor;

	// Start is called before the first frame update
	void Start () 
	{
		EstSelectionable = false;
		
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.name == "O7") 
		{
			EstSelectionable = true;
			toColor.toColor (Color.yellow);
		}
		if (other.name == "depot") 
		{
			
			toColor.toColor (Color.red);
		}
	}
	public void OnTriggerStay(Collider other)
	{
		if (other.name == "O7") 
		{
			EstSelectionable = true;
			toColor.toColor (Color.yellow);
		}
		if (other.name == "depot") 
		{

			toColor.toColor (Color.red);
		}
	}
	public void OnTriggerExit(Collider other)
	{
		if (other.name == "O7") 
		{
			EstSelectionable = false;
			toColor.toColor (Color.gray);
		}
		if (other.name == "depot") 
		{

			toColor.toColor (Color.red);
		}
	}
	// Update is called once per frame
	void Update () 
	{
	
	





	}
}
