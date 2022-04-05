using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ09 : MonoBehaviour
{

    //Realizá un programa que resuelva el siguiente problema:  
    //Tres personas aportan diferente capital a una sociedad.
    //Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float monto1;
    public float monto2;
    public float monto3;
    float capitalTotal;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    void Start()
    {
        capitalTotal = monto1 + monto2 + monto3;
        porcentaje1 = (monto1 / capitalTotal) * 100;
        porcentaje2 = (monto2 / capitalTotal) * 100;
        porcentaje3 = (monto3 / capitalTotal) * 100;
        Debug.Log($"{nombre1}: Capital aportado: ${monto1}, Porcentaje del capital: %{porcentaje1}, Monto total aportado: ${capitalTotal}");
        Debug.Log($"{nombre2}: Capital aportado: ${monto2}, Porcentaje del capital: %{porcentaje2}, Monto total aportado: ${capitalTotal}");
        Debug.Log($"{nombre3}: Capital aportado: ${monto3}, Porcentaje del capital: %{porcentaje3}, Monto total aportado: ${capitalTotal}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
