using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour 
{
	public ClavierScript cs;
	public gere_bras gere_bras;
	public GameObject gameObject;
	// Start is called before the first frame update
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		float dis = Vector3.Distance (gere_bras.Opince.transform.position,this.transform.position);
		if (dis < 0.2) 
		{
			cs.followme = 0.3F;
		} else 
		{
			cs.followme = 1F;
		}

	}
}
