using System;
using System.Linq;
using DBus;
using org.freedesktop.DBus;

public class Program
{
	public static void Main ()
	{
		var bus = Bus.System;
		var networkManager = bus.GetObject<NetworkManager> (
			"org.freedesktop.NetworkManager",
			new ObjectPath ("/org/freedesktop/NetworkManager"));
		var devices = networkManager.GetDevices ();
		foreach (var device in devices)
		{
			Console.WriteLine (device.Introspect ());
			Console.WriteLine (device.Get ("org.freedesktop.NetworkManager.Device", "Interface"));
		}
	}
}