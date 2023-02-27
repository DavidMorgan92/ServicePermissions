using Microsoft.Win32;

namespace ServicePermissions;

public static class RegistryHelper
{
	public static Dictionary<string, string?> GetProfiles(string machineName)
	{
		var baseKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName);
		var profileListKey = baseKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\ProfileList") ??
			throw new Exception("Couldn't locate user profile keys");

		var profileKeysWithImagePaths = profileListKey.GetSubKeyNames().OrderBy(k => k).Select(k =>
		{
			var profileKey = profileListKey.OpenSubKey(k) ?? throw new Exception("Couldn't locate profile key");
			var imagePathValue = profileKey.GetValue("ProfileImagePath") ?? throw new Exception("No profile image path for profile key");
			return KeyValuePair.Create(k, imagePathValue.ToString());
		});

		return new Dictionary<string, string?>(profileKeysWithImagePaths);
	}
}
