
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Generated on: 13.01.2019 18:14.26
public class InputMapping
{

    public enum InputMappingKeyName
    {
		Horizontal,
		Vertical,
		Fire1,
		Fire2,
		Fire3,
		Jump,
		MouseX,
		MouseY,
		MouseScrollWheel,
		Submit,
		Cancel,

    }

    private static InputMapping instance;
    public static InputMapping Instance
    {
        get
        {
            if( instance == null )
            {
                instance = new InputMapping();
            }

            return instance;
        }
    }

    public List<InputMappingKey> GetActualButtons(InputMappingKeyName name)
    {
        List<InputMappingKey> keys;

        if ( KeysMapping.TryGetValue(name, out keys) )
        {
            return keys;
        }
        else
        {
            throw new System.Exception($"Specified key is not in Input settings:{ name}");
        }
    }

    public Dictionary<InputMappingKeyName, List<InputMappingKey>> KeysMapping { private set; get; } = new Dictionary<InputMappingKeyName, List<InputMappingKey>>();

    public InputMapping()
    {
		KeysMapping.Add(InputMappingKeyName.Horizontal, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Horizontal", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "left", PositiveButton = "right", AltNegativeButton = "a", AltPositiveButton = "d"
			}
			,
			new InputMappingKey(){
			 Name = "Horizontal", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.Vertical, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Vertical", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "down", PositiveButton = "up", AltNegativeButton = "s", AltPositiveButton = "w"
			}
			,
			new InputMappingKey(){
			 Name = "Vertical", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.Fire1, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Fire1", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "left ctrl", AltNegativeButton = "", AltPositiveButton = "mouse 0"
			}
			,
			new InputMappingKey(){
			 Name = "Fire1", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "joystick button 0", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.Fire2, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Fire2", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "left alt", AltNegativeButton = "", AltPositiveButton = "mouse 1"
			}
			,
			new InputMappingKey(){
			 Name = "Fire2", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "joystick button 1", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.Fire3, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Fire3", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "left shift", AltNegativeButton = "", AltPositiveButton = "mouse 2"
			}
			,
			new InputMappingKey(){
			 Name = "Fire3", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "joystick button 2", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.Jump, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Jump", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "space", AltNegativeButton = "", AltPositiveButton = ""
			}
			,
			new InputMappingKey(){
			 Name = "Jump", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "joystick button 3", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.MouseX, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Mouse X", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.MouseY, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Mouse Y", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.MouseScrollWheel, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Mouse ScrollWheel", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "", AltNegativeButton = "", AltPositiveButton = ""
			}
		});
		KeysMapping.Add(InputMappingKeyName.Submit, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Submit", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "return", AltNegativeButton = "", AltPositiveButton = "joystick button 0"
			}
			,
			new InputMappingKey(){
			 Name = "Submit", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "enter", AltNegativeButton = "", AltPositiveButton = "space"
			}
		});
		KeysMapping.Add(InputMappingKeyName.Cancel, new List<InputMappingKey>()
		{
			new InputMappingKey(){
			 Name = "Cancel", DescriptiveName = "", DescriptiveNegativeName = "", NegativeButton = "", PositiveButton = "escape", AltNegativeButton = "", AltPositiveButton = "joystick button 1"
			}
		});

    }
}


/// <summary>
/// Wrapper to define a key and find actual buttons
/// </summary>
[System.Serializable]
public class InputButton
{
    //Key to use for the input
    public InputMapping.InputMappingKeyName InputKey;

    //Get name from the first key
    public string KeyName
    {
        get
        {
            return Keys[0].Name;
        }
    }

    /// <summary>
    /// Returns all button names that have been set
    /// </summary>
    public List<string> ButtonNames
    {
        get
        {
            List<string> buttonNames = new List<string>();

            foreach(InputMappingKey key in Keys)
            {
                var buttons = new []{ key.PositiveButton, key.NegativeButton, key.AltPositiveButton, key.AltNegativeButton };

                foreach(string button in buttons)
                {
                    if (!string.IsNullOrEmpty(button))
                    {
                        buttonNames.Add(button);
                    }
                }
            }

            return buttonNames;
        }
    }

    public string ButtonNamesCombined
    {
        get
        {
            return string.Join(", ", ButtonNames);
        }
    }

    //Keys that would actually be used
    private List<InputMappingKey> keys;
    public List<InputMappingKey> Keys
    {
        get
        {
            if (keys == null)
            {
                keys = InputMapping.Instance.GetActualButtons(InputKey);
            }

            return keys;
        }
    }   
}

