using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourisScript : MonoBehaviour 
{
    public MaterielScript materiel_increment;

	
	// Start is called before the first frame update
	void Start () 
	{
       
    }
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			if (materiel_increment.B1 == true) 
			{
				materiel_increment.B1 = false;
				Debug.Log("[SOURIS] Fire1 DESACTIVE");
			} else 
			{
				materiel_increment.B1 = true;
				Debug.Log("[SOURIS] Fire1 ACTIVE");
			}
            

        }
       
		if (Input.GetButtonDown("Fire2"))
        {
			
			materiel_increment.B2 = true;
        }

		if (materiel_increment.B3 == false) {
			if (Input.GetButtonUp("Fire3"))
			{
				materiel_increment.B3 = true;
				Debug.Log("[SOURIS] Fire3 ACTIVE");


			}
		} else {
			if (Input.GetButtonUp("Fire3"))
			{
				materiel_increment.B3 = false;
				Debug.Log("[SOURIS] Fire3 DOWN");


			}
		}
       
        
    }
}
