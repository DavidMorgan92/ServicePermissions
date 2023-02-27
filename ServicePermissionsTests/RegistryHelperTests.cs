using ServicePermissions;
using System.Windows.Forms;
using Xunit;

namespace ServicePermissionsTests;

public class RegistryHelperTests
{
	[Fact]
	public void GetProfilesTest()
	{
		var keys = RegistryHelper.GetProfiles(SystemInformation.ComputerName);
		Assert.True(keys.Any());
	}
}
