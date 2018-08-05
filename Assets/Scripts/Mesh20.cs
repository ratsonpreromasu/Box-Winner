using UnityEngine;
using System.Collections;

public class Mesh20 : MonoBehaviour
{

	public GameObject mes20;
	public GameObject mes2020;


	// Use this for initialization
	void Start ()
	{
		mes20.SetActive (true);
		mes2020.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void OnMouseDown(){
		PlayerPrefs.SetInt ("clicked",1);
//		if(PlayerPrefs.GetInt("Turn")==0){
//			PlayerPrefs.SetInt ("Turn",1);
//		}
//		else if(PlayerPrefs.GetInt("Turn")==1){
//			PlayerPrefs.SetInt ("Turn",0);
//		}
		mes20.SetActive (false);
		mes2020.SetActive (true);

	}
}

