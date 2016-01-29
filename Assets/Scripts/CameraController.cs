using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private static GameObject manager;

	private Vector3 delta, lastPos;

//	public float limiteCamara = 2;
	public Vector2 startPos;
    public Vector2 direction, lastDirection, check_se_ha_movido;
    public bool directionChosen;
	
	float distanciaFingers, distanciaFingersAnterior,xdim,ydim;

	public void Start() {
		manager = GameObject.FindWithTag ("GameManager");
	}	

	void Update() 
	{
		if (Input.GetMouseButtonDown (1))
		{ //the frame we press right click down, we must update the last position
			lastPos = Input.mousePosition;
		} 
		else if (Input.GetMouseButton (1))
		{ //while we hold right click, we move the camera, in case it stays in the map.
			delta = (- Input.mousePosition + lastPos) / 64; //update variation. I am not sure if this is the right way to do it, but it seems realistic.

			if (transform.position.x + (delta.x) >= 0 && transform.position.x + (delta.x) <= manager.GetComponent<GameManager>().getMap().getDimX())
				transform.position = new Vector3 (transform.position.x + (delta.x), transform.position.y, transform.position.z);
			if (transform.position.y + (delta.y) >= 0 && transform.position.y + (delta.y) <= manager.GetComponent<GameManager>().getMap().getDimY())
				transform.position = new Vector3 (transform.position.x, transform.position.y + (delta.y), transform.position.z);
			
			lastPos = Input.mousePosition; //update lastPos
		}
	
	}	
}
