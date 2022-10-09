using UnityEngine;
public class MoveForward : MonoBehaviour
{
    public float speed;//Spawnlanan Steak ve Hayvanların hızları.
    private void Update()
    {
     transform.Translate(Vector3.forward * Time.deltaTime * speed);//Bu koordinat ve açıda ilerleyecek.
    }
}
