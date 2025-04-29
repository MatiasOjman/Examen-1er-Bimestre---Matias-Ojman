using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vtv : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kmRecorridos;
    public int vencimiento;
    public int hcPpm;
    int promedioKm;

    // Start is called before the first frame update
    void Start()
    {
        if (patente == "")
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (modelo < 1900 || modelo > 2025)
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (kmRecorridos < 0)
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (vencimiento < modelo || vencimiento > 2025)
        {
            Debug.Log("VTV no aprobada");
            return;
        }else if (hcPpm < 5 || hcPpm >100)
        {
            Debug.Log("VTV no aprobada");
            return;
        }
        promedioKm = kmRecorridos / modelo;
        if (promedioKm < 10000)
        {
            Debug.Log("VTV otorgada por 2 años");
        }
        else if (promedioKm >10000)
        {
            Debug.Log("VTV otorgada por 1 año");
        }

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
