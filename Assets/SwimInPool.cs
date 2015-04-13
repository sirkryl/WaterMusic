using UnityEngine;
 
using System.Collections;
 
public class SwimInPool : MonoBehaviour
{
    private float xSpeed = 0.0014f;
    private float ySpeed = 0.0004f;
	public float xFactor = 1.0f;
	private Vector3 currentPosition;
	private Vector3 startingPosition;
	public bool dropped = false;
	public bool active = true;
	
 	
	void Update()
	{
		if(active)
		{
			if (dropped) 
			{
				startingPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 0);
				dropped = false;
			}
			
			currentPosition = gameObject.transform.localPosition;
			
			if (gameObject.name.Equals ("vocal") || gameObject.name.Equals ("rainy"))
			{
				if (gameObject.transform.localPosition.x >= 0.33)
				{
					//Debug.Log ("x "+gameObject.transform.position.x);
					gameObject.transform.localPosition = new Vector3(currentPosition.x -= (xSpeed*xFactor), currentPosition.y, 0);
					if (gameObject.transform.localPosition.y >= -4.05)
					{
					//Debug.Log ("y "+gameObject.transform.position.y);
					gameObject.transform.localPosition = new Vector3(currentPosition.x, currentPosition.y -= (ySpeed*xFactor), 0);
					}
				}
				else gameObject.transform.localPosition = new Vector3(0.95f, startingPosition.y, 0);
			}
			else
			{
				if (gameObject.transform.localPosition.x >= 0.43)
				{
					//Debug.Log ("x "+gameObject.transform.position.x);
					gameObject.transform.localPosition = new Vector3(currentPosition.x -= (xSpeed*xFactor), currentPosition.y, 0);
					if (gameObject.transform.localPosition.y >= -4.05)
					{
					//Debug.Log ("y "+gameObject.transform.position.y);
					gameObject.transform.localPosition = new Vector3(currentPosition.x, currentPosition.y -= (ySpeed*xFactor), 0);
					}
				}
				else gameObject.transform.localPosition = new Vector3(1.03f, startingPosition.y, 0);
			}
		}
		
	}
}