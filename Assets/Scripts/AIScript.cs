using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIScript : MonoBehaviour
{
	ScoreCube sc;
	public void Start(){
		sc = new ScoreCube ();

	}
	public void MakeAMove(){
//		int x = UnityEngine.Random.Range (0,sc.Objectlist.Count);
//
//		if (sc.Objectlist [x].activeInHierarchy) {
//			sc.Objectlist.RemoveAt (x);	
//			x = UnityEngine.Random.Range (0,sc.Objectlist.Count);
//		}
//
//		sc.Objectlist [x].SetActive (true);
//        PlayerPrefs.SetInt ("Turn",0);

		Debug.Log ("Entered");


	}
}

