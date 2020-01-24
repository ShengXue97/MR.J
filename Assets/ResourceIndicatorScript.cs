using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceIndicatorScript : MonoBehaviour
{
    double number;
    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(7,10);
        refreshAmt();
    }

    void refreshAmt() {
        if (gameObject.transform.parent.tag.Equals("stringResource")){
            gameObject.GetComponent<TextMeshPro>().text = '"' + Mathf.RoundToInt((float)number).ToString() + '"';
        } else if (gameObject.transform.parent.tag.Equals("intResource")){
            print("int resource");
            gameObject.GetComponent<TextMeshPro>().text = Mathf.RoundToInt((float)number).ToString();
        } else if (gameObject.transform.parent.tag.Equals("doubleResource")){
            gameObject.GetComponent<TextMeshPro>().text = string.Format("{0:0.00}", number) ;
        }
    }
    public void deplete() {
        number -= 1;
        if (number > 0) {
            refreshAmt();
        } else {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
