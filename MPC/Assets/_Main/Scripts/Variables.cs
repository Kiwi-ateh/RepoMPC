
using UnityEngine;
using TMPro;
public class Variables: MonoBehaviour
{

    //declarar variables

    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _Hey;


    public int edad = 17;
    public string myName;




    // Start is called before the first frame update
    void Start()
    { myName= _inputField.text;

        _Hey.text = "Hola ";
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola mundo");
    }
}
