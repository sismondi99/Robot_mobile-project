using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigation1 : MonoBehaviour
{
	public grabbingtheair gb;
	public MaterielScript materielSCript=null;
	public MVS mvs;
	public Vector3 increment_IR;
	public Vector3 increment_VR;

	// Start is called before the first frame update
	void Start () 
	{

		increment_IR = new Vector3(0.0F, 0.0F, 0.0F);
		increment_VR = new Vector3(0.0F, 0.0F, 0.0F);
	}

	// Update is called once per frame
	void Update () 
	{
		increment_IR = materielSCript.increment_IR;
		if (materielSCript.B1 == true) 
		{

			gb.increment = increment_IR;
			
		}else
		{
			mvs.increment_rot_VR=increment_IR;
			mvs.increment_trans_VR = increment_IR;
		}
	}
}
