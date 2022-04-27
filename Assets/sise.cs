using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class sise : MonoBehaviour
{
    public Transform sise2;
    public TextMeshProUGUI canYazisi,bitisYazisi;
    public int can;
    public AudioSource siseDusurme;
    void Update()
    {
        canYazisi.text = "Can : " + can;
        if (can==0)
        {
            bitisYazisi.text = "Oyun Bitti \n Tekrar oynamak ýcýn býr tusa basýnýz";
            Time.timeScale = 0;
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D temas)   
    {
        float rastgele = Random.Range(-6f, 6f);
        if (temas.gameObject.tag == "Zemin")
        {
            sise2.position = new Vector3(rastgele, 6f, 0f);
            siseDusurme.Play();
            can--;
            
        }
    }
}
