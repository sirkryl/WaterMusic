using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class Record : MonoBehaviour 
{

	//The maximum and minimum available recording frequencies
	private int minFreq;
	private int maxFreq;

	//A handle to the attached AudioSource
	private AudioSource goAudioSource;

	private GUIStyle buttonRed;
	private GUIStyle buttonGreen;
	
	//Use this for initialization
	void Start() 
	{
	
		
	}
	
	
	void OnGUI() 
	{
		if(buttonRed == null)
		{
			buttonRed = new GUIStyle(GUI.skin.button);
			buttonRed.normal.textColor = Color.red;
			buttonRed.fontStyle = FontStyle.Bold;
			buttonRed.fontSize = 15;
			buttonRed.alignment = TextAnchor.MiddleCenter;
		}
		if(buttonGreen == null)
		{
			buttonGreen = new GUIStyle(GUI.skin.button);
			buttonGreen.normal.textColor = Color.green;
			buttonGreen.fontStyle = FontStyle.Bold;
			buttonGreen.fontSize = 15;
			buttonGreen.alignment = TextAnchor.MiddleCenter;
		}
		if(gameObject.GetComponent<rippleSharp>().mode.Equals ("synthesizer"))
		{
			if(GUI.Button(new Rect(Screen.width-110, 120, 100, 50), "Synthesizer", buttonGreen))
			{
					gameObject.GetComponent<rippleSharp>().mode = "none";
			}
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width-110, 120, 100, 50), "Synthesizer", buttonRed))
			{
					gameObject.GetComponent<rippleSharp>().mode = "synthesizer";
				
					
			}

		}	
		
		if(GUI.Button(new Rect(Screen.width-110, 170, 100, 50), "Reset Synth"))
		{
				gameObject.GetComponent<rippleSharp>().resetSynth();
		}
		if(gameObject.GetComponent<rippleSharp>().mode.Equals ("guitar"))
		{
			if(GUI.Button(new Rect(Screen.width-110, 220, 100, 50), "Guitar", buttonGreen))
			{
					gameObject.GetComponent<rippleSharp>().mode = "none";
			}
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width-110, 220, 100, 50), "Guitar", buttonRed))
			{
					gameObject.GetComponent<rippleSharp>().mode = "guitar";
				
					
			}

		}
		if(gameObject.GetComponent<rippleSharp>().mode.Equals ("keyboard"))
		{
			if(GUI.Button(new Rect(Screen.width-110, 270, 100, 50), "Keyboard", buttonGreen))
			{
					gameObject.GetComponent<rippleSharp>().mode = "none";
			}
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width-110, 270, 100, 50), "Keyboard", buttonRed))
			{
					gameObject.GetComponent<rippleSharp>().mode = "keyboard";
				
					
			}

		}
		if(gameObject.GetComponent<rippleSharp>().mode.Equals ("musicbox"))
		{
			if(GUI.Button(new Rect(Screen.width-110, 320, 100, 50), "Musicbox", buttonGreen))
			{
					gameObject.GetComponent<rippleSharp>().mode = "none";
			}
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width-110, 320, 100, 50), "Musicbox", buttonRed))
			{
					gameObject.GetComponent<rippleSharp>().mode = "musicbox";
				
					
			}

		}
		if(gameObject.GetComponent<rippleSharp>().mode.Equals ("glassharp"))
		{
			if(GUI.Button(new Rect(Screen.width-110, 370, 100, 50), "Glassharp", buttonGreen))
			{
					gameObject.GetComponent<rippleSharp>().mode = "none";
			}
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width-110, 370, 100, 50), "Glassharp", buttonRed))
			{
					gameObject.GetComponent<rippleSharp>().mode = "glassharp";
				
					
			}

		}

		if(GUI.Button(new Rect(0, Screen.height-30, 60, 30), "Reset"))
		{
				gameObject.GetComponent<rippleSharp>().resetSynth();
				gameObject.GetComponent<rippleSharp>().mode = "none";
				GameObject guiInstruments = GameObject.Find("gui_instruments");
				Component[] instrumentLayers = guiInstruments.GetComponentsInChildren<MovePoint2>();
				foreach (MovePoint2 mP in instrumentLayers)
				{
					((MovePoint2)mP).ResetPosition();
				}
		}
		
		

	}
}