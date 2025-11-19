using UnityEngine;

public class Spotlight : MonoBehaviour
{

public Light FuckSpotlight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FuckSpotlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.F)){
            FuckSpotlight.enabled = !FuckSpotlight.enabled;
        }
    }
}
