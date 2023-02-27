using System.Diagnostics;
using System.DirectoryServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.ServiceProcess;

namespace ServicePermissions;

public static class ServiceHelper
{
	public static string GetSecurityDescriptor(string machineName, string serviceName)
	{
		return RunServiceController($"\"\\\\{machineName}\" sdshow \"{serviceName}\"");
	}

	public static string SetSecurityDescriptor(string machineName, string serviceName, string securityDescriptor)
	{
		return RunServiceController($"\"\\\\{machineName}\" sdset \"{serviceName}\" \"{securityDescriptor}\"");
	}

	private static string RunServiceController(string arguments)
	{
		var startInfo = new ProcessStartInfo()
		{
			FileName = "sc",
			Arguments = arguments,
			RedirectStandardOutput = true
		};

		using var process = Process.Start(startInfo) ??
			throw new Exception("Failed to start sc process");

		process.WaitForExit();
		return process.StandardOutput.ReadToEnd().Trim();
	}

	public static string AddProfileToSecurityDescriptor(string securityDescriptor, string profile)
	{
		var sd = new RawSecurityDescriptor(securityDescriptor);
		var sid = new SecurityIdentifier(profile);
		var accessMask = (int)(ActiveDirectoryRights.ReadProperty | ActiveDirectoryRights.WriteProperty | ActiveDirectoryRights.ExtendedRight);
		var ace = new CommonAce(AceFlags.None, AceQualifier.AccessAllowed, accessMask, sid, isCallback: false, opaque: null);
		sd.DiscretionaryAcl?.InsertAce(sd.DiscretionaryAcl.Count, ace);
		return sd.GetSddlForm(AccessControlSections.All);
	}

	public static IEnumerable<string> GetServices(string machineName)
	{
		var services = ServiceController.GetServices(machineName);
		return services.Select(c => c.ServiceName).OrderBy(n => n);
	}
}
