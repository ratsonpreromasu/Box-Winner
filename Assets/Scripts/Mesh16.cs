using UnityEngine;
using System.Collections;

public class Mesh16 : MonoBehaviour
{

	public GameObject mes16;
	public GameObject mes1616;


	// Use this for initialization
	void Start ()
	{
		mes16.SetActive (true);
		mes1616.SetActive (false);
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
		mes16.SetActive (false);
		mes1616.SetActive (true);

	}
}

