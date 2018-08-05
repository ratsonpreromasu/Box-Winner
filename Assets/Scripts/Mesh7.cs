using UnityEngine;
using System.Collections;

public class Mesh7 : MonoBehaviour
{

	public GameObject mes7;
	public GameObject mes77;


	// Use this for initialization
	void Start ()
	{
		mes7.SetActive (true);
		mes77.SetActive (false);
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
		mes7.SetActive (false);
		mes77.SetActive (true);

	}
}

