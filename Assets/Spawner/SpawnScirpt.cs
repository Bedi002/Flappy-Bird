using UnityEngine;

// Catatan: Pastikan nama file script kamu juga bernama "SpawnScript" (saya perbaiki ejaannya dari Scirpt)
public class SpawnScript : MonoBehaviour 
{
    // FIX 1: Ubah nama variabel 'Time' menjadi 'currentTime'
    float currentTime = 0; 
    
    // FIX 2: Jadikan public agar durasi spawn bisa diatur dari luar (Inspector)
    public float timer = 1; 

    // FIX 3: Tambahkan 'public' agar kamu bisa memasukkan prefab Pipa ke dalam kotak script di Inspector!
    public GameObject pipa; 
    
    void Update()
    {
        if (currentTime <= 0)
        {
            // FIX 4: Quaternion harus diawali huruf kapital 'Q'
            Instantiate(pipa, transform.position, Quaternion.identity);
            currentTime = timer;
        }
        else
        {
            // FIX 5: Sekarang Time.deltaTime akan membaca sistem waktu Unity dengan benar
            currentTime -= Time.deltaTime; 
        }
    }
}