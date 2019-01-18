
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Generated on: 18.01.2019 23:49.31
public class SettingsConstants
{

    public enum Name
    {
		MusicVolume,
		SoundVolume,
		SettingText,

    }

    public static void Load()
    {
		SettingsController.Instance.AddSetting(new SettingValue()
		{
			Name = Enum.GetName(typeof(SettingsConstants.Name), Name.MusicVolume),
			Type = SettingValueType.Float,
			MinValue = "0.0f",
			DefaultValue = "0.5f",
			MaxValue = "1.0f"
		});
		SettingsController.Instance.AddSetting(new SettingValue()
		{
			Name = Enum.GetName(typeof(SettingsConstants.Name), Name.SoundVolume),
			Type = SettingValueType.Float,
			MinValue = "0.0f",
			DefaultValue = "0.7f",
			MaxValue = "1.0f"
		});
		SettingsController.Instance.AddSetting(new SettingValue()
		{
			Name = Enum.GetName(typeof(SettingsConstants.Name), Name.SettingText),
			Type = SettingValueType.String,
			MinValue = "",
			DefaultValue = "Text loaded from setting",
			MaxValue = ""
		});

    }
}
