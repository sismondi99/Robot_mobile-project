using System.Collections;
using UnityEngine;
using System.IO;
using System;

public class MyFileLogHandler : ILogHandler 
{

	private FileStream m_FileStream;
	private StreamWriter m_StreamWriter;
	private ILogHandler m_DefaultLogHandler = Debug.unityLogger.logHandler;

	public MyFileLogHandler()
	{
		string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string filePath = dir + "/log.dat";

		m_FileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
		m_StreamWriter = new StreamWriter(m_FileStream);

		// Replace the default debug log handler
		Debug.unityLogger.logHandler = this;
	}

	public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
	{
		m_StreamWriter.WriteLine(String.Format(format, args));
		m_StreamWriter.Flush();
		m_DefaultLogHandler.LogFormat(logType, context, format, args);
	}

	public void LogException(Exception exception, UnityEngine.Object context)
	{
		m_DefaultLogHandler.LogException(exception, context);
	}
}
