using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceData : MonoBehaviour 
{
	private static string Tag = "MyGameTag";
	private static ILogger logger = Debug.unityLogger;
	
	private MyFileLogHandler myFileLogHandler;

	void Start()
	{ 
		Debug.Log(Application.persistentDataPath);
		myFileLogHandler = new MyFileLogHandler();

		logger.Log(Tag, "MyGameClass Start.");
	}
}
