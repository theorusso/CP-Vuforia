using UnityEngine;

public class DestruirObjetoAR : MonoBehaviour
{
    [SerializeField] private float rayDistance = 100f;

    void Update()
    {
        // Celular
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;

            Ray ray = Camera.main.ScreenPointToRay(touchPosition);

            
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red, 2f);

            if (Physics.Raycast(ray, out RaycastHit hit, rayDistance))
            {
                Debug.Log("Objeto atingido: " + hit.transform.name);

                if (hit.transform == transform && hit.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy destruído: " + gameObject.name);
                    Destroy(gameObject);
                }
            }
        }

        // Mouse 
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

           
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green, 2f);

            if (Physics.Raycast(ray, out RaycastHit hit, rayDistance))
            {
                Debug.Log("Objeto atingido: " + hit.transform.name);

                if (hit.transform == transform && hit.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy destruído: " + gameObject.name);
                    Destroy(gameObject);
                }
            }
        }
    }
}
