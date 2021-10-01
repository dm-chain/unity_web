
using System.Runtime.InteropServices;
using UnityEngine;

public class AlertBinding : MonoBehaviour {
    [DllImport("__Internal")]
    public static extern void Alert(string message);    
}