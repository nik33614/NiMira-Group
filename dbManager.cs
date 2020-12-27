using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class dbManager : MonoBehaviour
{


    public string money;
    public string phone;

    void Start()
    {

        StartCoroutine(Vovod());
    }
   
    private IEnumerator Vovod()
    {
        WWWForm form = new WWWForm();
        form.AddField("money", money);
        form.AddField("phone", phone);

        WWW www = new WWW("http://nik33614.ru/Checker/index2.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("Произошла ошибка: " + www.error);
            yield break;


        }

        else
        {

            Debug.Log(www.text);

        }
    }
}
