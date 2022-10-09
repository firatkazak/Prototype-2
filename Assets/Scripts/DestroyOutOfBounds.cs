using UnityEngine;
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;//Ekrandaki üst sınır.
    private float lowerBound = -10.0f;//Ekrandaki alt sınır.
    private void Update()
    {
     if (transform.position.z > topBound)//Eğer Z, üst sınırı geçerse; (30.1 olduğunda)
     {
      Destroy(gameObject);//Game objesini yok et.(Spawnladığımız Steak'ları yok eder.)
     }
     else if (transform.position.z < lowerBound)//Eğer Z, alt sınırı geçerse; (-10.1 olduğunda)
     {
      Debug.Log("Game Over!");//Konsola Game Over! yazdır.
      Destroy(gameObject);//Game objesini yok et.(Spawnlanan hayvanları yok eder.)
     }
    }
}
