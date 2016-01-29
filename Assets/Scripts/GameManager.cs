using UnityEngine;
using System.Collections;
using System.IO;

public class GameManager : MonoBehaviour {

	private Map map;

	// Use this for initialization
	void Start () {
		//Debug.Log (Application.persistentDataPath); C:/Users/Guillermo/AppData/LocalLow/DefaultCompany/Advance Wars 2
		map = new Map ();
		map.LoadMap ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Map getMap() {
		return this.map;
	}
}
