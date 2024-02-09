using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{

    public TextMeshProUGUI Label;
    public float prevInput = 0.0f;
    public bool clearPrevInput = false;

 
    private EquationType equationType;

    private void Start()
    {
        Clear();
    }

    public void AddInput(string input)
    {
        //      Check the clearPrevInput variable you created
        //      and if true then set the current value of the text label to be string.Empty
        //      and set the clearPrevInput value to false

        if (clearPrevInput == true)
        {
            
            Label.text = string.Empty;
            clearPrevInput = false;
            
        }

        //prevInput = float.Parse(input);

        //Label.text = (float.Parse(Label.text) + float.Parse(input)).ToString();
        Label.text += input;
    }

    //next four methods triggered dependant on which button is pushed, sets equation
    public void SetEquationAsAdd()
    {
        prevInput = float.Parse(Label.text);
        equationType = EquationType.ADD;
        clearPrevInput = true;
    }
 
    public void SetEquationAsSubtract()
    {
        prevInput = float.Parse(Label.text);
        equationType = EquationType.SUBTRACT;
        clearPrevInput = true;
    }

    
    public void SetEquationAsMultiply()
    {
        prevInput = float.Parse(Label.text);
        equationType = EquationType.MULTIPLY;
        clearPrevInput = true;
    }

 
    public void SetEquationAsDivide()
    {
        prevInput = float.Parse(Label.text);
        equationType = EquationType.DIVIDE;
        clearPrevInput = true;
    }


    public void Add()
    {
        Label.text = (float.Parse(Label.text) + prevInput).ToString();

    }

    public void Subtract()
    {
        Label.text = (float.Parse(Label.text) - prevInput).ToString();

    }


    public void Multiply()
    {

        Label.text = (float.Parse(Label.text) * prevInput).ToString();

    }

   
    public void Divide()
    {

        Label.text = (float.Parse(Label.text) / prevInput).ToString();

    }

    public void Clear()
    {
       
        prevInput = 0.0f;
        Label.text = "0";
        clearPrevInput = true;


        equationType = EquationType.None;        
    }

    //is called when the equal button is hit, runs calculation
    public void Calculate()
    {
        
        if (equationType == EquationType.ADD) Add();
        if (equationType == EquationType.SUBTRACT) Subtract();
        if (equationType == EquationType.MULTIPLY) Multiply();
        if (equationType == EquationType.DIVIDE) Divide();
    }

    
    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}
