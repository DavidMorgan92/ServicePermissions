using ServicePermissions;
using Xunit;

namespace ServicePermissionsTests;

public class ServiceHelperTests
{
	[Fact]
	public void GetSecurityDescriptorTest()
	{
		var service = "dcsvc";
		ServiceHelper.GetSecurityDescriptor(".", service);
	}

	[Fact]
	public void GetServicesTest()
	{
		var services = ServiceHelper.GetServices(".");
		Assert.True(services.Any());
	}

	[Fact]
	public void AddProfileToSecurityDescriptorTest()
	{
		var securityDescriptor = @"D:(A;;CCLCSWLORC;;;AU)(A;;CCDCLCSWRPWPDTLOCRSDRCWDWO;;;BA)(A;;CCLCSWRPLO;;;IU)(A;;CCLCSWLO;;;BU)";
		var profile = @"S-1-5-21-1722612674-111608038-3564729654-1001";
		var result = ServiceHelper.AddProfileToSecurityDescriptor(securityDescriptor, profile);
		Assert.Equal(@"D:(A;;CCLCSWLORC;;;AU)(A;;CCDCLCSWRPWPDTLOCRSDRCWDWO;;;BA)(A;;CCLCSWRPLO;;;IU)(A;;CCLCSWLO;;;BU)(A;;RPWPCR;;;S-1-5-21-1722612674-111608038-3564729654-1001)", result);
	}
}
