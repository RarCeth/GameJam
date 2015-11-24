using UnityEngine;
using System.Collections;

public class EnemySpawning : MonoBehaviour {
	public int totalWaveValue, currentWaveValue, nE1, nE2, nE3, eH1, eH2, eH3, eD1, eD2, eD3, rI;
	public GameObject e1, e2, e3;

	void Start () {
		//Time.timeScale = 0.1F;
		totalWaveValue = 30;
		currentWaveValue = 0;
		nE1 = 0;
		nE2 = 0;
		nE3 = 0;
		eH1 = 1;
		eH2 = 2;
		eH3 = 3;
		eD1 = 1;
		eD2 = 2;
		eD3 = 3;
		rI = 0;
	}
	

	void Update () {
		CheckWorking ();
		CheckWaveValue ();
		if (currentWaveValue <= totalWaveValue) {
			SpawnEnemy ();
		} else {
			return;
		}
	}

	public void CheckWorking(){
		Debug.Log ("nE1 = " + nE1);
		Debug.Log ("nE2 = " + nE2);
		Debug.Log ("nE3 = " + nE3);
		Debug.Log ("WaveValue = " + currentWaveValue);
	}

	public void CheckWaveValue(){
		currentWaveValue = ( (nE1 * (eH1 + eD1)) + (nE2 * (eH2 + eD2)) + (nE3 * (eH3 + eD3)) );
	}

	public void SpawnEnemy(){
		rI = Random.Range (1, 4);

		if (rI == 1 && currentWaveValue + (eH1 + eD1) < totalWaveValue) {
			nE1 ++;
			Instantiate (e1, new Vector3 (0,0,0), Quaternion.identity);
			CheckWaveValue();
		} else if (rI == 2 && currentWaveValue + (eH2 + eD2) < totalWaveValue) {
			nE2 ++;
			Instantiate (e2, new Vector3 (0,0,0), Quaternion.identity);
			CheckWaveValue();
		} else if (rI == 3 && currentWaveValue + (eH3 + eD3) < totalWaveValue) {
			nE3 ++;
			Instantiate (e3, new Vector3 (0,0,0), Quaternion.identity);
			CheckWaveValue();
		}
	}
}
