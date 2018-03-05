using UnityEngine;

public class ControllerVFXDroneExplode : MonoBehaviour {

	public GameObject currentEffect;
	public GameObject referenceObject;
	void Start ()
	{
		currentEffect.SetActive (false);
	}

	void VFXDroneExplodePlay ()
	{
		currentEffect.transform.position = referenceObject.transform.position;
		currentEffect.SetActive (false);
		currentEffect.SetActive (true);
	}
}
