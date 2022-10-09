using UnityEngine;
public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider animals)
    {
     Destroy(gameObject);//Bifteği yok ediyor.
     Destroy(animals.gameObject);//Hayvanları yok ediyor.
    }
}
