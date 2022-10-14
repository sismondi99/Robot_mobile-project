using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prism : MonoBehaviour 
{

	public float sensitivityX = 0.0001f;
	public float sensitivityY = 0.0001f;
	public float sensitivityZ = 2f;
	public float sensitivityMove = 2f;
	public float sensitivityMouseWheel = 2f;
	public gere_bras gb;
	public NavigationScript bb;
	public Vector3 increment;
	// Start is called before the first frame update
	void Start () 
	{
		increment = new Vector3 (0.0f,0.0f,0.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		float rotationX = (float)0.01*Input.GetAxis ("Mouse X") ;
		float rotationY = (float)0.01*Input.GetAxis ("Mouse Y") ;
		Vector3 increment2=new Vector3(rotationX,rotationY,0);
		increment = increment2;
		float distanceParFrame = (float)System.Math.Sqrt (rotationX*rotationX+rotationY*rotationY);
		//if (distanceParFrame > 0.05) {
	

		Vector3 gauche = new Vector3(0,-0.01F,0);
		Vector3 droite = new Vector3(0,0.01F,0);
		Vector3 go = new Vector3(0.01F,0,0);
		Vector3 back = new Vector3(-0.01F,0,0);

		if (distanceParFrame > 0.014) 
		{
			//First quadrant第一
			if (rotationX > 0 && rotationY > 0 && rotationX > rotationY) 
			{
				bb.increment_rot_VR = droite;
				bb.increment_trans_VR = new Vector3 (0, 0, 0);
			}
			if (rotationX > 0 && rotationY > 0 && rotationX < rotationY)
			{
				bb.increment_trans_VR = 2*go;
				bb.increment_rot_VR = new Vector3 (0, 0, 0);
			}
			//Second quadrant
			if (rotationX < 0 && rotationY > 0 && -rotationX > rotationY)
			{
				bb.increment_rot_VR = gauche;
				bb.increment_trans_VR = new Vector3(0, 0, 0);
			}
			if (rotationX < 0 && rotationY > 0 && -rotationX < rotationY)
			{
				bb.increment_trans_VR = 2 * go;
				bb.increment_rot_VR = new Vector3(0, 0, 0);
			}
			//Third quadrant
			if (rotationX < 0 && rotationY < 0 && -rotationX > -rotationY)
			{
				bb.increment_trans_VR = 2*back;
				bb.increment_rot_VR = new Vector3 (0, 0, 0);
			}
			if (rotationX < 0 && rotationY < 0 && -rotationX < -rotationY) 
			{
				bb.increment_rot_VR = gauche;
				bb.increment_trans_VR = new Vector3 (0, 0, 0);
			}
			//Fourth quadrant
			if (rotationX > 0 && rotationY < 0 && rotationX > -rotationY)
			{
				bb.increment_rot_VR = droite;
				bb.increment_trans_VR = new Vector3 (0, 0, 0);
			}
			if (rotationX > 0 && rotationY < 0 && rotationX < -rotationY) 
			{
				bb.increment_trans_VR = 2*back;
				bb.increment_rot_VR = new Vector3 (0, 0, 0);
			}
			gb.increment= new Vector3 (0, 0, 0);
		} else 
		{
			gb.increment = increment;
			bb.increment_trans_VR = new Vector3 (0, 0, 0);
			bb.increment_rot_VR = new Vector3 (0, 0, 0);
		}
		

	}
}
