
using UnityEngine;
using TMPro;
public class Variables : MonoBehaviour
{


    //declaración variables


    public int edad = 17;
    public string myName;
    public bool isBool;


    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _Hey;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _boxCollider;

    void Start()
    {

        _boxCollider.isTrigger = false;

        _cubo.material.color = Color.magenta;
        myName = _inputField.text;

        

    }

    // Update is called once per frame
    void Update()
    {

        myName = _inputField.text;

        _Hey.text = "Hola " + myName;

    }
}
