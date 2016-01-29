using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {

	private static GameObject manager;

	// Use this for initialization
	void Start () {
		manager = GameObject.FindWithTag("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Metodo de Unity. Es llamado cada vez que haces click sobre un collider.
	void OnMouseDown() {
		GetComponent<Animator> ().SetTrigger ("ChangeAnim");
	}
}
