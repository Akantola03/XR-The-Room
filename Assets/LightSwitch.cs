using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();

        if (Input.GetKeyDown("SPACE"))
        {
            light.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
