using UnityEngine;
using System.Collections;

public class Mesh19 : MonoBehaviour
{

	public GameObject mes19;
	public GameObject mes1919;


	// Use this for initialization
	void Start ()
	{
		mes19.SetActive (true);
		mes1919.SetActive (false);
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
		mes19.SetActive (false);
		mes1919.SetActive (true);

	}
}

