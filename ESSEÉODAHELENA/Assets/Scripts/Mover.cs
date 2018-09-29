using UnityEngine;
using System.Collections;


public class Mover : MonoBehaviour
{
    public Object objeto;
    Vector2 posicao;
    public float speed = 1f;
    bool vemDaDireita;

    void Start()
    {
        if (GetComponent<Transform>().position.x < 0)
            vemDaDireita = true;
        else
            vemDaDireita = false;
    }



    void Update()
    {
        if (vemDaDireita == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        else
        {
            transform.rotation = Quaternion.Euler(new Vector2(0, 180));
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (GetComponent<Transform>().position.x > 17 || GetComponent<Transform>().position.x < -17)
        {
            Destroy(objeto);
        }

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.transform.gameObject.tag == "Nave")
            Destroy(gameObject);
    }

}