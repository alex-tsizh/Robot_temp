using UnityEngine;
//using UnityEditor;

public class ControllerVFXDroneSpark : MonoBehaviour {

	public GameObject currentEffect;

	void Start ()
	{
		currentEffect.SetActive (false);
	}

	public void VFXDroneSparkPlay ()
	{
		currentEffect.SetActive (false);
		currentEffect.SetActive (true);
	}

}
