using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject button; // Asigna el bot�n en el Inspector

    private void Start()
    {
        // Aseg�rate de que el bot�n est� asignado
        if (button != null)
        {
            // Obt�n el componente Button y agrega un listener para el clic
            UnityEngine.UI.Button btn = button.GetComponent<UnityEngine.UI.Button>();
            if (btn != null)
            {
                btn.onClick.AddListener(CreateCube);
            }
        }
    }

    void CreateCube()
    {
        // Crea un cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Establece la posici�n del cubo
        cube.transform.position = new Vector3(0, 0, 0);

        // Cambia el color del cubo a azul
        Renderer renderer = cube.GetComponent<Renderer>();
        renderer.material.color = Color.blue;
    }
}
