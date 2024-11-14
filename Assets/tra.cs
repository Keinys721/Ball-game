using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float H_Postumis = Input.GetAxis("Horizontal");
        float V_Postumis = 0f; // Nustatome pradžioje vertikalų postūmį kaip 0.

        // Tikriname, ar spaudžiamas Space (kyla į viršų) arba Ctrl (leidžiasi žemyn)
        if (Input.GetKey(KeyCode.Space))
        {
            V_Postumis = 0.05f; // Judėjimas aukštyn
        }
        else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            V_Postumis = -0.05f; // Judėjimas žemyn
        }

        // Pritaikome judėjimą pagal horizontalią įvestį ir vertikalią klavišų įvestį
        transform.Translate(H_Postumis * 0.05f, V_Postumis, 0);
    }

    void FixedUpdate()
    {

    }
}
