using UnityEngine;

public class CollectorZone : MonoBehaviour
{
    [Header("Tag that can be collected")]
    public string collectableTag = "Collectable";

    private void OnTriggerEnter(Collider other)
    {
        // Only collect objects with the correct tag
        if (!other.CompareTag(collectableTag)) return;

        // Disable the object (makes it disappear)
        other.gameObject.SetActive(false);
    }
}