using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cart_Capacity : MonoBehaviour
{
    double current_capacity;
   void refreshAmt() {
        if (gameObject.transform.parent.tag.Equals("stringResource")){
            gameObject.GetComponent<TextMeshPro>().text = '"' + Mathf.RoundToInt((float)current_capacity).ToString() + '"' + " / " + '"' + "20" + '"';
        } else if (gameObject.transform.parent.tag.Equals("intResource")){
            print("int resource");
            gameObject.GetComponent<TextMeshPro>().text = Mathf.RoundToInt((float)current_capacity).ToString()  + " / "  + "20";
        } else if (gameObject.transform.parent.tag.Equals("doubleResource")){
            gameObject.GetComponent<TextMeshPro>().text = string.Format("{0:0.00}", current_capacity)   + " / "  + "20.0";
        }
    }
    public void Supply() {
        while (current_capacity < 20) {
            current_capacity += 1;
        }
        if (current_capacity <= 20) {
            refreshAmt();
        } else {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
     // Update is called once per frame
}
