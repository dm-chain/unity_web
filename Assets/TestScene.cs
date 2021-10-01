using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Button>().onClick.AddListener(() => AlertBinding.Alert("Thaay gi khong?") );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
