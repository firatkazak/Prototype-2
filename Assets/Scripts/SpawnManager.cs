using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;//Hayvan Spawnlamak için Liste Yarattık.
    private float spawnRangeX = 10.0f;//Hayvanların X düzleminde Spawn aralığı sol -10, sağ 10 kadar.
    private float spawnPosZ = 20.0f;//Z düzleminde 20'de Spawnlanacak hayvanlar.
    private float startDelay = 2.0f;//İlk spawnlanan hayvan oyun başladıktan 2 saniye sonra spawnlanacak.
    private float spawnInterval = 1.5f;//1.5 saniye aralıklarla yeni hayvan spawnlanacak.
    private void Start()
    {
     InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
     //Tekrarla(SpawnRandomAnimal fonksiyonunu, 2 saniye gecikme ile, 1.5 saniye aralıklarla)
    }
    private void SpawnRandomAnimal()
    {
     Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
     //Spawn Pozisyonu = X'de -10 ile 10 arası, Y'de 0, Z'de 20'de.
     int animalIndex = Random.Range(0, animalPrefabs.Length);
     //animalPrefabs'ın Uzunluğunda, yani 3 hayvan arasından(Geyik,At,İnek) Rastgele hayvan yaratacak.
     Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
     //Yarat(3 hayvandan herhangi 1 tane, Yukarıda tanıttığımız SpawnPos'ta, Prefabların standart açılarında.)
    }
}
