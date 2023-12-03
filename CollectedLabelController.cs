using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectedLabelController : MonoBehaviour
{
    private TMP_Text Lable;
    // Start is called before the first frame update
    void Start()
    {
        Lable = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Lable.text = Collect.amount_mushrooms.ToString();
    }
}
