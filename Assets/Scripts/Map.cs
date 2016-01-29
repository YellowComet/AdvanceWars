using UnityEngine;
using System.Collections;
using System.IO;

public class Map {

	public GameObject plain = (GameObject) Resources.Load ("Plain");
	public GameObject OScity = (GameObject) Resources.Load ("OSCity");

	private static GameObject manager = GameObject.FindWithTag("GameManager");

	private int dimX, dimY;
	private int[,] terrain; //It will contain the type of terrain of each maptile

	public void LoadMap () {
        string[] mapContent = File.ReadAllLines(Application.persistentDataPath + "/test.txt")[0].Split(':');

        string[] metainfo, terraininfo, unitsinfo;

		metainfo = mapContent [0].Split (',');
		terraininfo = mapContent [1].Split (',');
		unitsinfo = mapContent [2].Split (',');

		dimX = int.Parse ( metainfo [0].Split ('-') [0] );
		dimY = int.Parse ( metainfo [0].Split ('-') [1] );

		terrain = new int[dimX, dimY];

		string type;

		for (int i = 0; i < dimX; i++) {
			string[] tiles = terraininfo [i].Split ('-');
			for (int j = 0; j < dimY; j++) {
				string[] tile = tiles[j].Split('.'); 

				terrain[i,j] = int.Parse ( tile[0] ); //We store the type of terrain of each tile in terrain. Now we instantiate the GameObject

				if (terrain[i,j] == 1) { //plain
					type = "plain";
					if (i > 0)
						if (terrain[i-1,j] == 11) //TODO
							type = "shadowplain";
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity); //j in last coordinate to get it in the background
				}
				else if (terrain[i,j] == 2) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 3) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 4) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 5) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 6) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 7) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 8) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 9) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 10) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 11) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 12) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 13) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 14) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
				else if (terrain[i,j] == 15) {
					type = ""; 
					Object.Instantiate ((GameObject) Resources.Load ("Prefabs/Terrain/" + type), new Vector3(i, j, j), Quaternion.identity);
				}
			}
		}
	}

	public int getDimX () {
		return this.dimX;
	}

	public int getDimY () {
		return this.dimY;
	}
}
