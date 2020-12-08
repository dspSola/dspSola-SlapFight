using UnityEngine;

public class SlapDectionBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("un objet entre dans le cube");
        }
    }
}
