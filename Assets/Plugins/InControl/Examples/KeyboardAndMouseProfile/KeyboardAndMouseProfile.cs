using System;
using System.Collections;
using UnityEngine;
using InControl;

// WARNING: "Custom profiles" will soon be deprecated in favor of the new user bindings API
// (see the PlayerAction and PlayerActionSet classes) which accomplishes the same goal
// much more elegantly and supports runtime remapping.
// http://www.gallantgames.com/pages/incontrol-binding-actions-to-controls
//
// This custom profile is enabled by adding it to the Custom Profiles list
// on the InControlManager component, or you can attach it yourself like so:
// InputManager.AttachDevice( new UnityInputDevice( new KeyboardAndMouseProfile() ) );
//
public class KeyboardAndMouseProfile : CustomInputDeviceProfile
{
	public KeyboardAndMouseProfile()
	{
		Name = "Keyboard/Mouse";
		Meta = "A keyboard and mouse combination profile appropriate for FPS.";

		ButtonMappings = new[] 
		{
			new InputControlMapping 
			{
				Handle = "Interact",
				Target = InputControlType.Action3,
				Source = KeyCodeButton( KeyCode.E )
			},
			new InputControlMapping 
			{
				Handle = "Jump",
				Target = InputControlType.Action1,
				// KeyCodeButton fires when any of the provided KeyCode params are down.
				Source = KeyCodeButton( KeyCode.Space )
			},
			new InputControlMapping 
			{
				Handle = "Flop",
				Target = InputControlType.Action2,
				Source = MouseButton2
			},
			new InputControlMapping 
			{
				Handle = "??? - No Use For This Yet",
				Target = InputControlType.Action4,
				Source = KeyCodeButton( KeyCode.P )
			},
			new InputControlMapping 
			{
				Handle = "??? - No Use For This Yet",
				Target = InputControlType.LeftBumper,
				// KeyCodeComboButton requires that all KeyCode params are down simultaneously.
				Source = KeyCodeComboButton( KeyCode.LeftAlt, KeyCode.Alpha1 )
			},
		};

		AnalogMappings = new[] 
		{
			new InputControlMapping 
			{
				Handle = "Move Up",
				Target = InputControlType.LeftStickUp,
				Source = KeyCodeButton( KeyCode.W )
			},
			new InputControlMapping 
			{
				Handle = "Move Down",
				Target = InputControlType.LeftStickDown,
				Source = KeyCodeButton( KeyCode.S )
			},
			new InputControlMapping 
			{
				Handle = "Move Left",
				Target = InputControlType.LeftStickLeft,
				Source = KeyCodeButton( KeyCode.A )
			},
			new InputControlMapping 
			{
				Handle = "Move Right",
				Target = InputControlType.LeftStickRight,
				Source = KeyCodeButton( KeyCode.D )
			},
			new InputControlMapping 
			{
				Handle = "Mouse Lean Up",
				Target = InputControlType.RightStickUp,
				Source = MouseYAxis,
				SourceRange = InputRange.ZeroToPositiveInfinity,
				Raw = true,
				Scale = 0.1f
			},
			new InputControlMapping
			{
				Handle = "Mouse Lean Right",
				Target = InputControlType.RightStickDown,
				Source = MouseYAxis,
				SourceRange = InputRange.ZeroToNegativeInfinity,
				Raw = true,
				Scale = 0.1f,
				Invert = true
			},
			new InputControlMapping
			{
				Handle = "Mouse Lean Left",
				Target = InputControlType.RightStickLeft,
				Source = MouseXAxis,
				SourceRange = InputRange.ZeroToNegativeInfinity,
				Raw = true,
				Scale = 0.1f,
				Invert = true
			},
			new InputControlMapping
			{
				Handle = "Mouse Lean Right",
				Target = InputControlType.RightStickRight,
				Source = MouseXAxis,
				SourceRange = InputRange.ZeroToPositiveInfinity,
				Raw = true,
				Scale = 0.1f
			},
			new InputControlMapping 
			{
				Handle = "Arrow Lean Up",
				Target = InputControlType.RightStickUp,
				Source = KeyCodeButton( KeyCode.UpArrow ),
			},
			new InputControlMapping
			{
				Handle = "Arrow Lean Down",
				Target = InputControlType.RightStickDown,
				Source = KeyCodeButton( KeyCode.DownArrow ),
			},
			new InputControlMapping
			{
				Handle = "Arrow Lean Left",
				Target = InputControlType.RightStickLeft,
				Source = KeyCodeButton( KeyCode.LeftArrow ),
			},
			new InputControlMapping
			{
				Handle = "Arrow Lean Right",
				Target = InputControlType.RightStickRight,
				Source = KeyCodeButton( KeyCode.RightArrow ),
			},
//				new InputControlMapping {
//					Handle = "Look Z",
//					Target = InputControlType.ScrollWheel,
//					Source = MouseScrollWheel,
//					SourceRange = InputRange.Everything,
//					Raw = true,
//					Scale = 0.1f
//				},
			new InputControlMapping
			{
				Handle = "Go Droopy",
				Target = InputControlType.LeftTrigger,
				Source = KeyCodeButton( KeyCode.Q ),
			},
			new InputControlMapping 
			{
				Handle = "Bite",
				Target = InputControlType.RightTrigger,
				Source = MouseButton0
			}
		};
	}
}

