using UnityEngine;
using System.Collections;

public class Mesh10 : MonoBehaviour
{

	public GameObject mes10;
	public GameObject mes1010;



	// Use this for initialization
	void Start ()
	{
		mes10.SetActive (true);
		mes1010.SetActive (false);
	
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
		mes10.SetActive (false);
		mes1010.SetActive (true);
	

	}
}

