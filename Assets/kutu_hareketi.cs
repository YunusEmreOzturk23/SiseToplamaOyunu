using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kutu_hareketi : MonoBehaviour
{
    public float hiz;
    public Transform sise;
    int puan;
    public AudioSource siseAlma;
    public TextMeshProUGUI puanYazisi;
    void Update()
    {
        puanYazisi.text = "Skor: " + puan;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);
        }
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgele = Random.Range(-6f, 6f);
        if (temas.gameObject.tag == "Sise")
        {
            sise.position = new Vector3(rastgele, 6f, 0f);
            puan += 5;
            siseAlma.Play();
        }
        
    }
}
