using UnityEngine;
using System.Collections;

public class MainCameraScript : MonoBehaviour
{
	public float smooth = 3f;		// a public variable to adjust smoothing of camera motion
	public Transform camPos;			// the usual position for the camera, specified by a transform in the game
	void Start()
	{

	}
	
	void FixedUpdate ()
	{		
		transform.position = Vector3.Lerp(transform.position, camPos.position, Time.deltaTime * smooth);	
		transform.forward = Vector3.Lerp(transform.forward, camPos.forward, Time.deltaTime * smooth);
	}
}
