using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;//Yatay hareket için horizontalInput adında float değişken belirledik.
    public float speed = 30.0f;//Çiftçinin sağa sola gitme hızı.
    public float xRange = 10.0f;//X düzlemindeki aralık. -10 ile 10 aralığının dışına çıkamayacak.
    private Vector3 offset = new Vector3(0, 2, 0);//Steak 2 birim havada spawnlansın diye koyduk.
    public GameObject projectilePrefab;//Spawnlayacağımız Steak için GameObject tanıttık. Sürükle bırak ile Steak'i ekledik.
    private void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");//horizontalInput değişkenine işlevini tanıttık ve horizontal çıkış aldık.
     transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);//Bu hızda sağa sola hareket edecek.
     if(transform.position.x < -xRange)//Eğer x'in değeri -10'dan küçük ise (-10.1 gibi.)
     {
      transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);//Pozisyonunu -10'da tut.
     }
     if(transform.position.x > xRange)//Eğer x'in değeri 10'dan büyük ise (10.1 gibi.)
     {
      transform.position = new Vector3(xRange, transform.position.y, transform.position.z);//Pozisyonunu 10'da tut.
     }
     if(Input.GetKeyDown(KeyCode.Space))//Space tuşuna basılırsa
     {
      Instantiate(projectilePrefab, transform.position + offset, projectilePrefab.transform.rotation);
      //Üret(Steak prefabından, Çiftçinin o anki pozisyonunda + offset(2 birim yukarıda), Steak'in sabit açısında.)
     }
    }
}
