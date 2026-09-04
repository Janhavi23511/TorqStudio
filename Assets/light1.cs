using UnityEngine;
using System.Collections;

public class light1 : MonoBehaviour
{
    [Header("Light Settings")]
    public Light targetLight;
    public float minIntensity = 0.5f;
    public float maxIntensity = 2.0f;

    [Header("Flicker Timing")]
    public float minDelay = 0.01f;
    public float maxDelay = 0.1f;

    void Start()
    {
        // Agar light manually assign nahi ki gayi hai, toh usi object se component fetch karein
        if (targetLight == null)
        {
            targetLight = GetComponent<Light>();
        }

        // Flicker routine start karein
        StartCoroutine(FlickerSystem());
    }

    IEnumerator FlickerSystem()
    {
        while (true)
        {
            // Intensity ko ek random value par set karein
            targetLight.intensity = Random.Range(minIntensity, maxIntensity);

            // Next flicker ke liye random time interval tak wait karein
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
        }
    }
}