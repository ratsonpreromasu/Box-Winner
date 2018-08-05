using UnityEngine;
using System.Collections;

public class Mesh8 : MonoBehaviour
{

	public GameObject mes8;
	public GameObject mes88;


	// Use this for initialization
	void Start ()
	{
		mes8.SetActive (true);
		mes88.SetActive (false);
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
		mes8.SetActive (false);
		mes88.SetActive (true);

	}
}

