using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{

   /* function OnTriggerEnter2D(other : Collider)
    {
        if (other.gameObject.tag == "Nave")
            Destroy(other.gameObject);
    }

    void OnTriggerEnter(Collider other)
      {
          if (other.tag == "Boundary")
          {
              return;
          }
          Instantiate(explosion, transform.position, transform.rotation);
          if (other.tag == "Nave")
          {
              Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
              gameController.GameOver ();
          }
          Destroy(other.gameObject);
          Destroy(gameObject);
      }*/
}