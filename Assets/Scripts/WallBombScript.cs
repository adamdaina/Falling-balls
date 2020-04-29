using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WallBombScript : MonoBehaviour
{
   // public int index_win;

    private void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Planet")
        {
            Destroy(target.gameObject);
            StartCoroutine(Expl());
           
            IEnumerator Expl()
            {
                yield return new WaitForSecondsRealtime(8f);

                 Destroy(target.gameObject);

            }
        }
    }

   /* IEnumerator Expl()
    {
        yield return new WaitForSecondsRealtime(9f);

          //  Destroy(target.gameObject);

    }*/


}