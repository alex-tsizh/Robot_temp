using UnityEngine;

public class ControllerVFXDroneSmokeLittle : MonoBehaviour {

	public GameObject currentEffect;

	void Start ()
	{
		currentEffect.SetActive (false);
	}

	void VFXDroneSmokeLittlePlay ()
	{
		currentEffect.SetActive (false);
		currentEffect.SetActive (true);
	}
}
