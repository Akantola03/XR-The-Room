using UnityEngine; 

public class LightSwitch : MonoBehaviour 
{ 
	private Light lightSource; 

	void Start() 
	{ 
		lightSource = GetComponent<Light>(); 
	} 
	
	void Update() 
	{
	    if (Input.GetKeyDown(KeyCode.Space)) 
		{ 
        lightSource.color = Color.blue; 
        } 
    } 
}
