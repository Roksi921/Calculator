using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public Text Text1;
    public string calc1;
    public string x1;

    public void On_Click_buttom()
    {
        Text1.text += calc1;
    }

    public void On_Click_C()
    {
        Text1.text = "";
    }

    public void On_Click_Ravno()
    {
        DataTable dt = new DataTable();
        x1 = (dt.Compute(Text1.text, "")).ToString();
        Text1.text = x1;
    }
}
