using UnityEngine;
using System.Collections;

public class Mesh9 : MonoBehaviour
{

	public GameObject mes9;
	public GameObject mes99;


	// Use this for initialization
	void Start ()
	{
		mes9.SetActive (true);
		mes99.SetActive (false);
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
		mes9.SetActive (false);
		mes99.SetActive (true);

	}
}

