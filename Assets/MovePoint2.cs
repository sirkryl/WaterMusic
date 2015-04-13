using UnityEngine;
 
using System.Collections;
 
[RequireComponent(typeof(BoxCollider))]
 
public class MovePoint2 : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
	private Vector3 startingPosition;
	public Color ownColor;
	public Color waterColor;
	private string storedMode;
	
	void Start()
	{
		startingPosition = gameObject.transform.localPosition;
	}
 
	public void ResetPosition()
	{
		gameObject.transform.localPosition = startingPosition;
		
		gameObject.guiTexture.color = new Color(0.5f,0.5f,0.5f,0.5f);
		if(gameObject.GetComponents<SwimInPool>().Length != 0 && gameObject.GetComponent<SwimInPool>().active)
		{
			waterColor = GameObject.Find ("128xplane").GetComponent<rippleSharp>().RemoveColor (ownColor);
			gameObject.GetComponent<SwimInPool>().active = false;
			audio.volume = 0.0f;
		}
		
	}
    void OnMouseDown() 
    { 
		gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 1);
		gameObject.guiTexture.color = new Color(0.5f,0.5f,0.5f,0.5f);

       screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
 		storedMode = GameObject.Find ("128xplane").GetComponent<rippleSharp>().mode;
		GameObject.Find ("128xplane").GetComponent<rippleSharp>().mode = "none";
		//Vector3 test = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		//Debug.Log ("x: "+test.x+", y: "+test.y+", z: "+test.z);
       offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
 	   if(gameObject.GetComponents<SwimInPool>().Length != 0 && gameObject.GetComponent<SwimInPool>().active)
		{
			waterColor = GameObject.Find ("128xplane").GetComponent<rippleSharp>().RemoveColor (ownColor);
			gameObject.GetComponent<SwimInPool>().active = false;
			audio.volume = 0.0f;
		}
       Screen.showCursor = false;
    }
 
    void OnMouseDrag() 
    { 
       Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
 
       Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
 
       transform.position = curPosition;
 
    }
 
    void OnMouseUp()
    {
		if (gameObject.name.Equals ("vocal") || gameObject.name.Equals ("rainy"))
		{
			if (gameObject.transform.localPosition.x >= 0.38 && gameObject.transform.localPosition.x <= 0.95 && gameObject.transform.localPosition.y <= -3.3 && gameObject.transform.localPosition.y >= -4.05)
			{
				if(gameObject.GetComponents<SwimInPool>().Length == 0)
				{
					gameObject.AddComponent("SwimInPool");
				}
				GameObject.Find ("128xplane").GetComponent<rippleSharp>().mode = storedMode;
				gameObject.GetComponent<SwimInPool>().dropped = true;
				gameObject.GetComponent<SwimInPool>().active = true;
				
				//gameObject.guiTexture.color = new Color(0.3f,0.8f,0.3f,0.5f);
				audio.volume = 1.0f;
				waterColor = GameObject.Find ("128xplane").GetComponent<rippleSharp>().AddColor (ownColor);
				//gameObject.guiTexture.color = new Color(waterColor.r, waterColor.g, waterColor.b, 0.5f);
				gameObject.guiTexture.color += ownColor;
				//gameObject.guiTexture.color = new Color(ownColor.r, ownColor.g, ownColor.b, 0.5f);
			}
		}
		else
		{
			if (gameObject.transform.localPosition.x >= 0.47 && gameObject.transform.localPosition.x <= 1.03 && gameObject.transform.localPosition.y <= -3.3 && gameObject.transform.localPosition.y >= -4.05)
			{
				if(gameObject.GetComponents<SwimInPool>().Length == 0)
				{
					gameObject.AddComponent("SwimInPool");
				}
				GameObject.Find ("128xplane").GetComponent<rippleSharp>().mode = storedMode;
				gameObject.GetComponent<SwimInPool>().dropped = true;
				gameObject.GetComponent<SwimInPool>().active = true;
				
				//gameObject.guiTexture.color = new Color(0.3f,0.8f,0.3f,0.5f);
				audio.volume = 1.0f;
				waterColor = GameObject.Find ("128xplane").GetComponent<rippleSharp>().AddColor (ownColor);
				//gameObject.guiTexture.color = new Color(waterColor.r, waterColor.g, waterColor.b, 0.5f);
				gameObject.guiTexture.color += ownColor;
				//gameObject.guiTexture.color = new Color(ownColor.r, ownColor.g, ownColor.b, 0.5f);
			}
		}
       Screen.showCursor = true;
    }
}