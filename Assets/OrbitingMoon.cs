using UnityEngine;

public class OrbitingMoon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float degreesPerSecond = 45.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f);
    }
}
