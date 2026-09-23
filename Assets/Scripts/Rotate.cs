using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
