using UnityEngine;
using System.Collections;

public class Mesh24 : MonoBehaviour
{

	public GameObject mes24;
	public GameObject mes2424;


	// Use this for initialization
	void Start ()
	{
		mes24.SetActive (true);
		mes2424.SetActive (false);
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
		mes24.SetActive (false);
		mes2424.SetActive (true);

	}
}

