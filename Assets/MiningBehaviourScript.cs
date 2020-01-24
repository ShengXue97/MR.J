using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiningBehaviourScript : MonoBehaviour
{
    public string resourceSelected = "none";
    public Text stringLabel;
    private double string_val;
    public double String_val
    {
        get
        {
            return string_val;
        }
        set
        {
            string_val = value;
            stringLabel.GetComponent<Text>().text = "String: " + string_val.ToString();
        }
    }
    public Text intLabel;
    private double int_val;
    public double Int_val
    {
        get
        {
            return int_val;
        }
        set
        {
            int_val = value;
            intLabel.GetComponent<Text>().text = "int: " + int_val.ToString();
        }
    }

    public Text doubleLabel;
    private int double_val;
    public int Double_val
    {
        get
        {
            return double_val;
        }
        set
        {
            double_val = value;
            doubleLabel.GetComponent<Text>().text = "double: " + double_val.ToString();
        }
    }

    
    void Start()
    {
        String_val = 0;
        Double_val = 2;
        Int_val = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Application.LoadLevel(3);
        }
    }

    


}

