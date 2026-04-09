using UnityEngine;

public class CollectorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            Debug.Log("Object Collected!");

            // destroy object
            Destroy(other.gameObject);
        }
    }
}