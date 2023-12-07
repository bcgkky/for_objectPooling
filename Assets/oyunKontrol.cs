using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    public GameObject[] olusacakObje;
    public GameObject olusacakNokta;
    int siraNo=0;
    void Start()
    {
        /*olusacakObje[0].SetActive(true);
        olusacakObje[0].transform.position = olusacakNokta.transform.position;*/
        StartCoroutine(objeOlusturma());
    }
    IEnumerator objeOlusturma()
    {
        while (true)
        {
            if (siraNo <= 8)
            {
                olusacakObje[siraNo].SetActive(true);
                olusacakObje[siraNo].transform.position = olusacakNokta.transform.position;
                siraNo++;
            }
            else
            {
                siraNo = 0;
                olusacakObje[siraNo].SetActive(true);
                olusacakObje[siraNo].transform.position = olusacakNokta.transform.position;
            }

            /*foreach (GameObject objem in olusacakObje)
            {
                objem.SetActive(true);
                objem.transform.position = olusacakNokta.transform.position;
            }*/

            yield return new WaitForSeconds(.5f);
        }
    }
}
